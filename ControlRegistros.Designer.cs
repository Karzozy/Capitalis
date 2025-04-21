namespace Capitalis
{
    partial class ControlRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipoRegistro = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.datePickerRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.datePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.chkDescripcion = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbControlregistro = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TipodeRegistro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaRegistro = new System.Windows.Forms.Label();
            this.fechaVencimiento = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoRegistro
            // 
            this.tipoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.tipoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipoRegistro.FormattingEnabled = true;
            this.tipoRegistro.Items.AddRange(new object[] {
            "Ingreso",
            "Egreso"});
            this.tipoRegistro.Location = new System.Drawing.Point(484, 85);
            this.tipoRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoRegistro.Name = "tipoRegistro";
            this.tipoRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipoRegistro.Size = new System.Drawing.Size(245, 24);
            this.tipoRegistro.TabIndex = 0;
            this.tipoRegistro.SelectedIndexChanged += new System.EventHandler(this.tipoRegistro_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMonto.Location = new System.Drawing.Point(484, 139);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(245, 22);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datePickerRegistro
            // 
            this.datePickerRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerRegistro.Location = new System.Drawing.Point(484, 252);
            this.datePickerRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerRegistro.Name = "datePickerRegistro";
            this.datePickerRegistro.Size = new System.Drawing.Size(245, 35);
            this.datePickerRegistro.TabIndex = 4;
            this.datePickerRegistro.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtCategoria.Location = new System.Drawing.Point(484, 196);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(245, 22);
            this.txtCategoria.TabIndex = 5;
            this.txtCategoria.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // datePickerVencimiento
            // 
            this.datePickerVencimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.datePickerVencimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerVencimiento.Location = new System.Drawing.Point(484, 321);
            this.datePickerVencimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerVencimiento.Name = "datePickerVencimiento";
            this.datePickerVencimiento.Size = new System.Drawing.Size(245, 35);
            this.datePickerVencimiento.TabIndex = 6;
            this.datePickerVencimiento.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(484, 396);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 29);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolverMenu.FlatAppearance.BorderSize = 0;
            this.btnVolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenu.Location = new System.Drawing.Point(29, 431);
            this.btnVolverMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(123, 32);
            this.btnVolverMenu.TabIndex = 8;
            this.btnVolverMenu.Text = "Regresar";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.AutoSize = true;
            this.chkDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.chkDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.chkDescripcion.Location = new System.Drawing.Point(477, 362);
            this.chkDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(234, 29);
            this.chkDescripcion.TabIndex = 9;
            this.chkDescripcion.Text = "¿Agregar Descripcion?";
            this.chkDescripcion.UseVisualStyleBackColor = false;
            this.chkDescripcion.CheckedChanged += new System.EventHandler(this.chkDescripcion_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.btnGuardar.FlatAppearance.BorderSize = 6;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(752, 393);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capitalis.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(479, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categoria*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(479, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monto*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbControlregistro
            // 
            this.lbControlregistro.AutoSize = true;
            this.lbControlregistro.BackColor = System.Drawing.Color.Transparent;
            this.lbControlregistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControlregistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.lbControlregistro.Location = new System.Drawing.Point(-3, -4);
            this.lbControlregistro.Name = "lbControlregistro";
            this.lbControlregistro.Size = new System.Drawing.Size(403, 92);
            this.lbControlregistro.TabIndex = 15;
            this.lbControlregistro.Text = "Centro de ingresos \r\ny egresos ";
            this.lbControlregistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.pictureBox3.Location = new System.Drawing.Point(412, -4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(495, 510);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // TipodeRegistro
            // 
            this.TipodeRegistro.AutoSize = true;
            this.TipodeRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.TipodeRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipodeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.TipodeRegistro.Location = new System.Drawing.Point(479, 53);
            this.TipodeRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipodeRegistro.Name = "TipodeRegistro";
            this.TipodeRegistro.Size = new System.Drawing.Size(208, 28);
            this.TipodeRegistro.TabIndex = 16;
            this.TipodeRegistro.Text = "Tipo de registro*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(431, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registre sus egresos o ingresos";
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.AutoSize = true;
            this.fechaRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.fechaRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.fechaRegistro.Location = new System.Drawing.Point(479, 223);
            this.fechaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.Size = new System.Drawing.Size(227, 28);
            this.fechaRegistro.TabIndex = 18;
            this.fechaRegistro.Text = "Fecha de registro*";
            this.fechaRegistro.Visible = false;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.AutoSize = true;
            this.fechaVencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.fechaVencimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.fechaVencimiento.Location = new System.Drawing.Point(479, 290);
            this.fechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Size = new System.Drawing.Size(274, 28);
            this.fechaVencimiento.TabIndex = 19;
            this.fechaVencimiento.Text = "Fecha de vencimiento*";
            this.fechaVencimiento.Visible = false;
            this.fechaVencimiento.Click += new System.EventHandler(this.fechaVencimiento_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(49)))), ((int)(((byte)(132)))));
            this.pictureBox2.Image = global::Capitalis.Properties.Resources.bancolombia;
            this.pictureBox2.Location = new System.Drawing.Point(635, 412);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // ControlRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 489);
            this.Controls.Add(this.fechaVencimiento);
            this.Controls.Add(this.fechaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipodeRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.datePickerVencimiento);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.datePickerRegistro);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.tipoRegistro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbControlregistro);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlRegistros";
            this.Text = "ControlRegistros";
            this.Load += new System.EventHandler(this.ControlRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoRegistro;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker datePickerRegistro;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker datePickerVencimiento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.CheckBox chkDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbControlregistro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TipodeRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fechaRegistro;
        private System.Windows.Forms.Label fechaVencimiento;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}