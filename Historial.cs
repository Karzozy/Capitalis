using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Capitalis
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            rbIngresos.Checked = true;
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            string connectionString = "User Id=capitalis;Password=oracle;Data Source=localhost:1521/XE";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = "";
                bool esIngreso = rbIngresos.Checked;

                if (esIngreso)
                {
                    sql = @"
                SELECT monto, categoria, descripcion, fecha_registro 
                FROM Ingreso
                WHERE fecha_registro BETWEEN :desde AND :hasta";
                }
                else
                {
                    sql = @"
                SELECT monto, categoria, descripcion, fecha_registro, fecha_vencimiento 
                FROM Egreso
                WHERE fecha_registro BETWEEN :desde AND :hasta";
                }

                if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    sql += " AND LOWER(categoria) LIKE :categoria";
                }

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":desde", OracleDbType.Date).Value = dtpDesde.Value.Date;
                    cmd.Parameters.Add(":hasta", OracleDbType.Date).Value = dtpHasta.Value.Date;

                    if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                    {
                        cmd.Parameters.Add(":categoria", OracleDbType.Varchar2).Value = "%" + txtCategoria.Text.ToLower() + "%";
                    }

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvHistorial.DataSource = dt;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           CargarHistorial();
        }

        private void rbIngresos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngresos.Checked) CargarHistorial();
        }

        private void rbEgresos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEgresos.Checked) CargarHistorial();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
