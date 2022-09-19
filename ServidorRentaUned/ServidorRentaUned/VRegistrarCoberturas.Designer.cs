namespace ServidorRentaUned
{
    partial class VRegistrarCoberturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegistrarCoberturas));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDCobertura = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_IDtipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_EstadoCobertura = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_TipoVehiculos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SaveCoberturas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipoVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el ID de la cobertura";
            // 
            // txt_IDCobertura
            // 
            this.txt_IDCobertura.Location = new System.Drawing.Point(7, 32);
            this.txt_IDCobertura.Name = "txt_IDCobertura";
            this.txt_IDCobertura.Size = new System.Drawing.Size(248, 26);
            this.txt_IDCobertura.TabIndex = 2;
            this.txt_IDCobertura.TextChanged += new System.EventHandler(this.txt_IDCobertura_TextChanged);
            this.txt_IDCobertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDCobertura_KeyPress);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(7, 101);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(248, 26);
            this.txt_Descripcion.TabIndex = 4;
            this.txt_Descripcion.TextChanged += new System.EventHandler(this.txt_Descripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite la descripción de la Cobertura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lista de los tipo de vehiculos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seleccione un ID del tipo de vehiculo asignar:";
            // 
            // cb_IDtipoVehiculo
            // 
            this.cb_IDtipoVehiculo.FormattingEnabled = true;
            this.cb_IDtipoVehiculo.Location = new System.Drawing.Point(374, 240);
            this.cb_IDtipoVehiculo.Name = "cb_IDtipoVehiculo";
            this.cb_IDtipoVehiculo.Size = new System.Drawing.Size(171, 26);
            this.cb_IDtipoVehiculo.TabIndex = 15;
            this.cb_IDtipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cb_IDtipoVehiculo_SelectedIndexChanged);
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(7, 174);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(248, 26);
            this.txt_Monto.TabIndex = 20;
            this.txt_Monto.TextChanged += new System.EventHandler(this.txt_Monto_TextChanged);
            this.txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto por la Cobertura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Seleccione el estado de la cobertura:";
            // 
            // cb_EstadoCobertura
            // 
            this.cb_EstadoCobertura.FormattingEnabled = true;
            this.cb_EstadoCobertura.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_EstadoCobertura.Location = new System.Drawing.Point(8, 241);
            this.cb_EstadoCobertura.Name = "cb_EstadoCobertura";
            this.cb_EstadoCobertura.Size = new System.Drawing.Size(171, 26);
            this.cb_EstadoCobertura.TabIndex = 21;
            this.cb_EstadoCobertura.SelectedIndexChanged += new System.EventHandler(this.cb_EstadoCobertura_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dGV_TipoVehiculos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_EstadoCobertura);
            this.panel1.Controls.Add(this.txt_Monto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_IDtipoVehiculo);
            this.panel1.Controls.Add(this.txt_Descripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_IDCobertura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 300);
            this.panel1.TabIndex = 24;
            // 
            // dGV_TipoVehiculos
            // 
            this.dGV_TipoVehiculos.AllowUserToAddRows = false;
            this.dGV_TipoVehiculos.AllowUserToDeleteRows = false;
            this.dGV_TipoVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_TipoVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_TipoVehiculos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_TipoVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_TipoVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TipoVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_TipoVehiculos.ColumnHeadersHeight = 30;
            this.dGV_TipoVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_TipoVehiculos.EnableHeadersVisualStyles = false;
            this.dGV_TipoVehiculos.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_TipoVehiculos.Location = new System.Drawing.Point(297, 25);
            this.dGV_TipoVehiculos.Name = "dGV_TipoVehiculos";
            this.dGV_TipoVehiculos.ReadOnly = true;
            this.dGV_TipoVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TipoVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_TipoVehiculos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_TipoVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_TipoVehiculos.Size = new System.Drawing.Size(365, 175);
            this.dGV_TipoVehiculos.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(232, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Registrar Coberturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(247, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::ServidorRentaUned.Properties.Resources.backazul;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 73);
            this.button1.TabIndex = 27;
            this.button1.Text = "Volver";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_SaveCoberturas
            // 
            this.btn_SaveCoberturas.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveCoberturas.Enabled = false;
            this.btn_SaveCoberturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveCoberturas.FlatAppearance.BorderSize = 2;
            this.btn_SaveCoberturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveCoberturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveCoberturas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCoberturas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveCoberturas.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveCoberturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveCoberturas.Location = new System.Drawing.Point(12, 341);
            this.btn_SaveCoberturas.Name = "btn_SaveCoberturas";
            this.btn_SaveCoberturas.Size = new System.Drawing.Size(686, 64);
            this.btn_SaveCoberturas.TabIndex = 26;
            this.btn_SaveCoberturas.Text = "Guardar Cobertura";
            this.btn_SaveCoberturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveCoberturas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveCoberturas.UseVisualStyleBackColor = false;
            this.btn_SaveCoberturas.Click += new System.EventHandler(this.btn_SaveCoberturas_Click);
            // 
            // VRegistrarCoberturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(707, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SaveCoberturas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VRegistrarCoberturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Coberturas";
            this.Load += new System.EventHandler(this.VRegistraCoberturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipoVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDCobertura;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_IDtipoVehiculo;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_EstadoCobertura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SaveCoberturas;
        private System.Windows.Forms.DataGridView dGV_TipoVehiculos;
    }
}