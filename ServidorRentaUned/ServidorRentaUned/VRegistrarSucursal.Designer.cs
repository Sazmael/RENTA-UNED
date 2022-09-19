namespace ServidorRentaUned
{
    partial class VRegistrarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegistrarSucursal));
            this.txt_IDSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreSucursal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DireccionSucursal = new System.Windows.Forms.TextBox();
            this.cb_EstadoSucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TelefonoSucursal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptxtSucursal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_SaveRegistroSucursal = new System.Windows.Forms.Button();
            this.ptxtSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDSucursal
            // 
            this.txt_IDSucursal.BackColor = System.Drawing.Color.White;
            this.txt_IDSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDSucursal.Location = new System.Drawing.Point(12, 91);
            this.txt_IDSucursal.Name = "txt_IDSucursal";
            this.txt_IDSucursal.Size = new System.Drawing.Size(385, 26);
            this.txt_IDSucursal.TabIndex = 0;
            this.txt_IDSucursal.Tag = "IDSucursal";
            this.txt_IDSucursal.TextChanged += new System.EventHandler(this.txt_IDSucursal_TextChanged);
            this.txt_IDSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDSucursal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el ID de la Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite el nombre de la Sucursal:";
            // 
            // txt_NombreSucursal
            // 
            this.txt_NombreSucursal.BackColor = System.Drawing.Color.White;
            this.txt_NombreSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreSucursal.Location = new System.Drawing.Point(12, 141);
            this.txt_NombreSucursal.Name = "txt_NombreSucursal";
            this.txt_NombreSucursal.Size = new System.Drawing.Size(385, 26);
            this.txt_NombreSucursal.TabIndex = 2;
            this.txt_NombreSucursal.Tag = "Nombre";
            this.txt_NombreSucursal.TextChanged += new System.EventHandler(this.txt_NombreSucursal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite la dirección de la Sucursal:";
            // 
            // txt_DireccionSucursal
            // 
            this.txt_DireccionSucursal.BackColor = System.Drawing.Color.White;
            this.txt_DireccionSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DireccionSucursal.Location = new System.Drawing.Point(12, 198);
            this.txt_DireccionSucursal.Name = "txt_DireccionSucursal";
            this.txt_DireccionSucursal.Size = new System.Drawing.Size(385, 26);
            this.txt_DireccionSucursal.TabIndex = 4;
            this.txt_DireccionSucursal.Tag = "Direccion";
            this.txt_DireccionSucursal.TextChanged += new System.EventHandler(this.txt_DireccionSucursal_TextChanged);
            // 
            // cb_EstadoSucursal
            // 
            this.cb_EstadoSucursal.BackColor = System.Drawing.Color.White;
            this.cb_EstadoSucursal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EstadoSucursal.FormattingEnabled = true;
            this.cb_EstadoSucursal.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_EstadoSucursal.Location = new System.Drawing.Point(11, 266);
            this.cb_EstadoSucursal.Name = "cb_EstadoSucursal";
            this.cb_EstadoSucursal.Size = new System.Drawing.Size(162, 26);
            this.cb_EstadoSucursal.TabIndex = 6;
            this.cb_EstadoSucursal.SelectedIndexChanged += new System.EventHandler(this.cb_EstadoSucursal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite el telefono de la Sucursal:";
            // 
            // txt_TelefonoSucursal
            // 
            this.txt_TelefonoSucursal.BackColor = System.Drawing.Color.White;
            this.txt_TelefonoSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefonoSucursal.Location = new System.Drawing.Point(8, 201);
            this.txt_TelefonoSucursal.Name = "txt_TelefonoSucursal";
            this.txt_TelefonoSucursal.Size = new System.Drawing.Size(385, 26);
            this.txt_TelefonoSucursal.TabIndex = 7;
            this.txt_TelefonoSucursal.Tag = "Telefono";
            this.txt_TelefonoSucursal.TextChanged += new System.EventHandler(this.txt_TelefonoSucursal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seleccione el estado de la Sucursal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(121, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registrar Sucursal";
            // 
            // ptxtSucursal
            // 
            this.ptxtSucursal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ptxtSucursal.Controls.Add(this.label4);
            this.ptxtSucursal.Controls.Add(this.label5);
            this.ptxtSucursal.Controls.Add(this.txt_TelefonoSucursal);
            this.ptxtSucursal.Controls.Add(this.cb_EstadoSucursal);
            this.ptxtSucursal.Controls.Add(this.label3);
            this.ptxtSucursal.Location = new System.Drawing.Point(4, 60);
            this.ptxtSucursal.Name = "ptxtSucursal";
            this.ptxtSucursal.Size = new System.Drawing.Size(399, 310);
            this.ptxtSucursal.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(154, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Volver.Image = global::ServidorRentaUned.Properties.Resources.backazul;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(4, 510);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(144, 51);
            this.btn_Volver.TabIndex = 11;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_SaveRegistroSucursal
            // 
            this.btn_SaveRegistroSucursal.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveRegistroSucursal.Enabled = false;
            this.btn_SaveRegistroSucursal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveRegistroSucursal.FlatAppearance.BorderSize = 2;
            this.btn_SaveRegistroSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveRegistroSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveRegistroSucursal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveRegistroSucursal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveRegistroSucursal.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveRegistroSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveRegistroSucursal.Location = new System.Drawing.Point(4, 385);
            this.btn_SaveRegistroSucursal.Name = "btn_SaveRegistroSucursal";
            this.btn_SaveRegistroSucursal.Size = new System.Drawing.Size(399, 64);
            this.btn_SaveRegistroSucursal.TabIndex = 10;
            this.btn_SaveRegistroSucursal.Text = "Guardar Sucursal";
            this.btn_SaveRegistroSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveRegistroSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveRegistroSucursal.UseVisualStyleBackColor = false;
            this.btn_SaveRegistroSucursal.Click += new System.EventHandler(this.btn_SaveRegistroSucursal_Click);
            // 
            // VRegistrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(409, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_SaveRegistroSucursal);
            this.Controls.Add(this.txt_DireccionSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NombreSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IDSucursal);
            this.Controls.Add(this.ptxtSucursal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VRegistrarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Sucursal";
            this.Load += new System.EventHandler(this.VRegistrarSucursal_Load);
            this.ptxtSucursal.ResumeLayout(false);
            this.ptxtSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DireccionSucursal;
        private System.Windows.Forms.ComboBox cb_EstadoSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TelefonoSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SaveRegistroSucursal;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ptxtSucursal;
    }
}