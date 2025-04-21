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
    public partial class ControlRegistros : Form
    {
        public ControlRegistros()
        {
            InitializeComponent();
            txtDescripcion.Enabled = false;
        }

        private void ControlRegistros_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoRegistro.SelectedItem != null)
            {
                string tipo = tipoRegistro.SelectedItem.ToString();

                if (tipo == "Ingreso")
                {
                    fechaRegistro.Visible = true;
                    datePickerRegistro.Visible = true;
                    datePickerRegistro.Visible = true;

                    fechaVencimiento.Visible = false;
                    datePickerVencimiento.Visible = false;
                    datePickerVencimiento.Visible = false;
                }
                else if (tipo == "Egreso")
                {
                    fechaRegistro.Visible = true;
                    datePickerRegistro.Visible = true;
                    datePickerRegistro.Visible = true;

                    fechaVencimiento.Visible = true;
                    datePickerVencimiento.Visible = true;
                    datePickerVencimiento.Visible = true;
                }
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlRegistros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = chkDescripcion.Checked;

            if (!chkDescripcion.Checked)
            {
                txtDescripcion.Text = "Descripcion";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=capitalis;Password=oracle;Data Source=localhost:1521/XE";
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string tipo = tipoRegistro.SelectedItem.ToString();
                    decimal monto = Convert.ToDecimal(txtMonto.Text);
                    string categoria = txtCategoria.Text;
                    string descripcion = chkDescripcion.Checked ? txtDescripcion.Text : null;

                    if (tipo == "Ingreso")
                    {
                        string sql = @"INSERT INTO Ingreso (monto, categoria, descripcion, fecha_registro)
                               VALUES (:monto, :categoria, :descripcion, SYSDATE)";

                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(":monto", OracleDbType.Decimal).Value = monto;
                            cmd.Parameters.Add(":categoria", OracleDbType.Varchar2).Value = categoria;

                            if (descripcion != null)
                                cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
                            else
                                cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = DBNull.Value;

                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show($"Ingreso agregado correctamente. Filas afectadas: {rowsAffected}");
                        }
                    }
                    else if (tipo == "Egreso")
                    {
                        DateTime fechaVencimiento = datePickerVencimiento.Value;

                        string sql = @"INSERT INTO Egreso (monto, descripcion, categoria, fecha_registro, fecha_vencimiento)
                               VALUES (:monto, :descripcion, :categoria, SYSDATE, :fecha_vencimiento)";

                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(":monto", OracleDbType.Decimal).Value = monto;

                            if (descripcion != null)
                                cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
                            else
                                cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = DBNull.Value;

                            cmd.Parameters.Add(":categoria", OracleDbType.Varchar2).Value = categoria;
                            cmd.Parameters.Add(":fecha_vencimiento", OracleDbType.Date).Value = fechaVencimiento;

                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show($"Egreso agregado correctamente. Filas afectadas: {rowsAffected}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fechaVencimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
