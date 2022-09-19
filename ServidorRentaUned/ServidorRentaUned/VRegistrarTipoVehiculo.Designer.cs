namespace ServidorRentaUned
{
    partial class VRegistrarTipoVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegistrarTipoVehiculo));
            this.txt_IDTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DescripcionTipoVehiculo = new System.Windows.Forms.TextBox();
            this.cb_EstadoTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_SaveTipoVehiculo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDTipoVehiculo
            // 
            this.txt_IDTipoVehiculo.Location = new System.Drawing.Point(12, 32);
            this.txt_IDTipoVehiculo.Name = "txt_IDTipoVehiculo";
            this.txt_IDTipoVehiculo.Size = new System.Drawing.Size(370, 26);
            this.txt_IDTipoVehiculo.TabIndex = 0;
            this.txt_IDTipoVehiculo.TextChanged += new System.EventHandler(this.txt_IDTipoVehiculo_TextChanged);
            this.txt_IDTipoVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDTipoVehiculo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite el ID del tipo de vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite la descripción del tipo de vehiculo:";
            // 
            // txt_DescripcionTipoVehiculo
            // 
            this.txt_DescripcionTipoVehiculo.Location = new System.Drawing.Point(12, 112);
            this.txt_DescripcionTipoVehiculo.Name = "txt_DescripcionTipoVehiculo";
            this.txt_DescripcionTipoVehiculo.Size = new System.Drawing.Size(370, 26);
            this.txt_DescripcionTipoVehiculo.TabIndex = 3;
            this.txt_DescripcionTipoVehiculo.TextChanged += new System.EventHandler(this.txt_DescripcionTipoVehiculo_TextChanged);
            // 
            // cb_EstadoTipoVehiculo
            // 
            this.cb_EstadoTipoVehiculo.FormattingEnabled = true;
            this.cb_EstadoTipoVehiculo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_EstadoTipoVehiculo.Location = new System.Drawing.Point(12, 190);
            this.cb_EstadoTipoVehiculo.Name = "cb_EstadoTipoVehiculo";
            this.cb_EstadoTipoVehiculo.Size = new System.Drawing.Size(129, 26);
            this.cb_EstadoTipoVehiculo.TabIndex = 5;
            this.cb_EstadoTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cb_EstadoTipoVehiculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione el estado del Tipo de vehiculo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_EstadoTipoVehiculo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_DescripcionTipoVehiculo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_IDTipoVehiculo);
            this.panel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 249);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(88, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Registrar Tipo de Vehiculo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(159, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 94);
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
            this.btn_Volver.Location = new System.Drawing.Point(12, 402);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(141, 62);
            this.btn_Volver.TabIndex = 21;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_SaveTipoVehiculo
            // 
            this.btn_SaveTipoVehiculo.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveTipoVehiculo.Enabled = false;
            this.btn_SaveTipoVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveTipoVehiculo.FlatAppearance.BorderSize = 2;
            this.btn_SaveTipoVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveTipoVehiculo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveTipoVehiculo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveTipoVehiculo.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveTipoVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveTipoVehiculo.Location = new System.Drawing.Point(11, 300);
            this.btn_SaveTipoVehiculo.Name = "btn_SaveTipoVehiculo";
            this.btn_SaveTipoVehiculo.Size = new System.Drawing.Size(386, 64);
            this.btn_SaveTipoVehiculo.TabIndex = 20;
            this.btn_SaveTipoVehiculo.Text = "Guardar Tipo de Vehiculo";
            this.btn_SaveTipoVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveTipoVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveTipoVehiculo.UseVisualStyleBackColor = false;
            this.btn_SaveTipoVehiculo.Click += new System.EventHandler(this.btn_SaveTipoVehiculo_Click);
            // 
            // VRegistrarTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(409, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_SaveTipoVehiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VRegistrarTipoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar tipo de vehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDTipoVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DescripcionTipoVehiculo;
        private System.Windows.Forms.ComboBox cb_EstadoTipoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_SaveTipoVehiculo;
    }
}