namespace ServidorRentaUned
{
    partial class VRegistrarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegistrarVehiculos));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDPlaca = new System.Windows.Forms.TextBox();
            this.txt_ModeloVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MarcaVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_IDtipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txt_CostoAlquilerVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KilometrajeVehiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_TipoVehiculos2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_SaveVehiculos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipoVehiculos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el ID de placa del Vehiculo:";
            // 
            // txt_IDPlaca
            // 
            this.txt_IDPlaca.Location = new System.Drawing.Point(6, 30);
            this.txt_IDPlaca.Name = "txt_IDPlaca";
            this.txt_IDPlaca.Size = new System.Drawing.Size(276, 26);
            this.txt_IDPlaca.TabIndex = 2;
            this.txt_IDPlaca.TextChanged += new System.EventHandler(this.txt_IDPlaca_TextChanged);
            this.txt_IDPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDPlaca_KeyPress);
            // 
            // txt_ModeloVehiculo
            // 
            this.txt_ModeloVehiculo.Location = new System.Drawing.Point(5, 150);
            this.txt_ModeloVehiculo.Name = "txt_ModeloVehiculo";
            this.txt_ModeloVehiculo.Size = new System.Drawing.Size(276, 26);
            this.txt_ModeloVehiculo.TabIndex = 4;
            this.txt_ModeloVehiculo.TextChanged += new System.EventHandler(this.txt_ModeloVehiculo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite el modelo del Vehiculo:";
            // 
            // txt_MarcaVehiculo
            // 
            this.txt_MarcaVehiculo.Location = new System.Drawing.Point(7, 90);
            this.txt_MarcaVehiculo.Name = "txt_MarcaVehiculo";
            this.txt_MarcaVehiculo.Size = new System.Drawing.Size(276, 26);
            this.txt_MarcaVehiculo.TabIndex = 6;
            this.txt_MarcaVehiculo.TextChanged += new System.EventHandler(this.txt_MarcaVehiculo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite la marca del Vehiculo:";
            // 
            // cb_IDtipoVehiculo
            // 
            this.cb_IDtipoVehiculo.FormattingEnabled = true;
            this.cb_IDtipoVehiculo.Location = new System.Drawing.Point(375, 267);
            this.cb_IDtipoVehiculo.Name = "cb_IDtipoVehiculo";
            this.cb_IDtipoVehiculo.Size = new System.Drawing.Size(201, 26);
            this.cb_IDtipoVehiculo.TabIndex = 7;
            this.cb_IDtipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cb_IDtipoVehiculo_SelectedIndexChanged);
            // 
            // txt_CostoAlquilerVehiculo
            // 
            this.txt_CostoAlquilerVehiculo.Location = new System.Drawing.Point(7, 207);
            this.txt_CostoAlquilerVehiculo.Name = "txt_CostoAlquilerVehiculo";
            this.txt_CostoAlquilerVehiculo.Size = new System.Drawing.Size(276, 26);
            this.txt_CostoAlquilerVehiculo.TabIndex = 9;
            this.txt_CostoAlquilerVehiculo.TextChanged += new System.EventHandler(this.txt_CostoAlquilerVehiculo_TextChanged);
            this.txt_CostoAlquilerVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CostoAlquilerVehiculo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite el costo del alquiler del Vehiculo:";
            // 
            // txt_KilometrajeVehiculo
            // 
            this.txt_KilometrajeVehiculo.Location = new System.Drawing.Point(7, 267);
            this.txt_KilometrajeVehiculo.Name = "txt_KilometrajeVehiculo";
            this.txt_KilometrajeVehiculo.Size = new System.Drawing.Size(276, 26);
            this.txt_KilometrajeVehiculo.TabIndex = 11;
            this.txt_KilometrajeVehiculo.TextChanged += new System.EventHandler(this.txt_KilometrajeVehiculo_TextChanged);
            this.txt_KilometrajeVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KilometrajeVehiculo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Digite el kilometraje del Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione un ID del tipo de vehiculo asignar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lista de los tipo de vehiculos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dGV_TipoVehiculos2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_KilometrajeVehiculo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_CostoAlquilerVehiculo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_IDtipoVehiculo);
            this.panel1.Controls.Add(this.txt_MarcaVehiculo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ModeloVehiculo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_IDPlaca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 315);
            this.panel1.TabIndex = 16;
            // 
            // dGV_TipoVehiculos2
            // 
            this.dGV_TipoVehiculos2.AllowUserToAddRows = false;
            this.dGV_TipoVehiculos2.AllowUserToDeleteRows = false;
            this.dGV_TipoVehiculos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_TipoVehiculos2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_TipoVehiculos2.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_TipoVehiculos2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_TipoVehiculos2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TipoVehiculos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_TipoVehiculos2.ColumnHeadersHeight = 30;
            this.dGV_TipoVehiculos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_TipoVehiculos2.EnableHeadersVisualStyles = false;
            this.dGV_TipoVehiculos2.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_TipoVehiculos2.Location = new System.Drawing.Point(306, 20);
            this.dGV_TipoVehiculos2.Name = "dGV_TipoVehiculos2";
            this.dGV_TipoVehiculos2.ReadOnly = true;
            this.dGV_TipoVehiculos2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_TipoVehiculos2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_TipoVehiculos2.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dGV_TipoVehiculos2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_TipoVehiculos2.Size = new System.Drawing.Size(332, 213);
            this.dGV_TipoVehiculos2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(228, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Volver.Image = global::ServidorRentaUned.Properties.Resources.backazul;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(6, 487);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(216, 62);
            this.btn_Volver.TabIndex = 21;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_SaveVehiculos
            // 
            this.btn_SaveVehiculos.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveVehiculos.Enabled = false;
            this.btn_SaveVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveVehiculos.FlatAppearance.BorderSize = 2;
            this.btn_SaveVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveVehiculos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveVehiculos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveVehiculos.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveVehiculos.Location = new System.Drawing.Point(6, 374);
            this.btn_SaveVehiculos.Name = "btn_SaveVehiculos";
            this.btn_SaveVehiculos.Size = new System.Drawing.Size(641, 64);
            this.btn_SaveVehiculos.TabIndex = 20;
            this.btn_SaveVehiculos.Text = "Guardar Vehículos";
            this.btn_SaveVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveVehiculos.UseVisualStyleBackColor = false;
            this.btn_SaveVehiculos.Click += new System.EventHandler(this.btn_SaveVehiculos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(224, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Registrar Vehículos";
            // 
            // VRegistrarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(652, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_SaveVehiculos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VRegistrarVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Vehiculos";
            this.Load += new System.EventHandler(this.VRegistarVehiculos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TipoVehiculos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDPlaca;
        private System.Windows.Forms.TextBox txt_ModeloVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MarcaVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_IDtipoVehiculo;
        private System.Windows.Forms.TextBox txt_CostoAlquilerVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KilometrajeVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_SaveVehiculos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dGV_TipoVehiculos2;
    }
}