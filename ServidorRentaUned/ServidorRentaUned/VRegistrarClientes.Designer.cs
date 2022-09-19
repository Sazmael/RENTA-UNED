namespace ServidorRentaUned
{
    partial class VRegistrarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegistrarClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Apellido1Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellido2Cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_FechaCumpleanios = new System.Windows.Forms.DateTimePicker();
            this.check_GeneroM = new System.Windows.Forms.CheckBox();
            this.check_GeneroF = new System.Windows.Forms.CheckBox();
            this.ptxtClientes = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SaveClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.ptxtClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el ID del cliente:";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDCliente.Location = new System.Drawing.Point(16, 38);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(364, 23);
            this.txt_IDCliente.TabIndex = 2;
            this.txt_IDCliente.TextChanged += new System.EventHandler(this.txt_IDCliente_TextChanged);
            this.txt_IDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDCliente_KeyPress);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCliente.Location = new System.Drawing.Point(16, 87);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(364, 23);
            this.txt_NombreCliente.TabIndex = 4;
            this.txt_NombreCliente.TextChanged += new System.EventHandler(this.txt_NombreCliente_TextChanged);
            this.txt_NombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite el nombre del cliente:";
            // 
            // txt_Apellido1Cliente
            // 
            this.txt_Apellido1Cliente.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido1Cliente.Location = new System.Drawing.Point(16, 154);
            this.txt_Apellido1Cliente.Name = "txt_Apellido1Cliente";
            this.txt_Apellido1Cliente.Size = new System.Drawing.Size(364, 23);
            this.txt_Apellido1Cliente.TabIndex = 6;
            this.txt_Apellido1Cliente.TextChanged += new System.EventHandler(this.txt_Apellido1Cliente_TextChanged);
            this.txt_Apellido1Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido1Cliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite el primer apellido del cliente:";
            // 
            // txt_Apellido2Cliente
            // 
            this.txt_Apellido2Cliente.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido2Cliente.Location = new System.Drawing.Point(16, 217);
            this.txt_Apellido2Cliente.Name = "txt_Apellido2Cliente";
            this.txt_Apellido2Cliente.Size = new System.Drawing.Size(364, 23);
            this.txt_Apellido2Cliente.TabIndex = 8;
            this.txt_Apellido2Cliente.TextChanged += new System.EventHandler(this.txt_Apellido2Cliente_TextChanged);
            this.txt_Apellido2Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido2Cliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite el segundo apellido del cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digite la fecha de cumpleaños del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Digite el genero del cliente:";
            // 
            // date_FechaCumpleanios
            // 
            this.date_FechaCumpleanios.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechaCumpleanios.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_FechaCumpleanios.Location = new System.Drawing.Point(16, 273);
            this.date_FechaCumpleanios.Name = "date_FechaCumpleanios";
            this.date_FechaCumpleanios.Size = new System.Drawing.Size(129, 26);
            this.date_FechaCumpleanios.TabIndex = 11;
            // 
            // check_GeneroM
            // 
            this.check_GeneroM.AutoSize = true;
            this.check_GeneroM.Location = new System.Drawing.Point(16, 342);
            this.check_GeneroM.Name = "check_GeneroM";
            this.check_GeneroM.Size = new System.Drawing.Size(124, 22);
            this.check_GeneroM.TabIndex = 12;
            this.check_GeneroM.Text = "M (Masculino)";
            this.check_GeneroM.UseVisualStyleBackColor = true;
            this.check_GeneroM.CheckedChanged += new System.EventHandler(this.check_GeneroM_CheckedChanged);
            // 
            // check_GeneroF
            // 
            this.check_GeneroF.AutoSize = true;
            this.check_GeneroF.Location = new System.Drawing.Point(16, 370);
            this.check_GeneroF.Name = "check_GeneroF";
            this.check_GeneroF.Size = new System.Drawing.Size(115, 22);
            this.check_GeneroF.TabIndex = 13;
            this.check_GeneroF.Text = "F (Femenino)";
            this.check_GeneroF.UseVisualStyleBackColor = true;
            this.check_GeneroF.CheckedChanged += new System.EventHandler(this.check_GeneroF_CheckedChanged);
            // 
            // ptxtClientes
            // 
            this.ptxtClientes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ptxtClientes.Controls.Add(this.txt_Apellido2Cliente);
            this.ptxtClientes.Controls.Add(this.check_GeneroF);
            this.ptxtClientes.Controls.Add(this.label4);
            this.ptxtClientes.Controls.Add(this.check_GeneroM);
            this.ptxtClientes.Controls.Add(this.date_FechaCumpleanios);
            this.ptxtClientes.Controls.Add(this.txt_Apellido1Cliente);
            this.ptxtClientes.Controls.Add(this.label3);
            this.ptxtClientes.Controls.Add(this.label5);
            this.ptxtClientes.Controls.Add(this.label6);
            this.ptxtClientes.Controls.Add(this.txt_NombreCliente);
            this.ptxtClientes.Controls.Add(this.label2);
            this.ptxtClientes.Controls.Add(this.txt_IDCliente);
            this.ptxtClientes.Controls.Add(this.label1);
            this.ptxtClientes.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptxtClientes.Location = new System.Drawing.Point(14, 49);
            this.ptxtClientes.Name = "ptxtClientes";
            this.ptxtClientes.Size = new System.Drawing.Size(383, 395);
            this.ptxtClientes.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(109, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registrar Clientes";
            // 
            // btn_SaveClientes
            // 
            this.btn_SaveClientes.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveClientes.Enabled = false;
            this.btn_SaveClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveClientes.FlatAppearance.BorderSize = 2;
            this.btn_SaveClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveClientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveClientes.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveClientes.Location = new System.Drawing.Point(14, 450);
            this.btn_SaveClientes.Name = "btn_SaveClientes";
            this.btn_SaveClientes.Size = new System.Drawing.Size(383, 64);
            this.btn_SaveClientes.TabIndex = 17;
            this.btn_SaveClientes.Text = "Guardar Cliente";
            this.btn_SaveClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveClientes.UseVisualStyleBackColor = false;
            this.btn_SaveClientes.Click += new System.EventHandler(this.btn_SaveClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(148, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
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
            this.btn_Volver.Location = new System.Drawing.Point(14, 547);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(130, 62);
            this.btn_Volver.TabIndex = 18;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // VRegistrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(409, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_SaveClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ptxtClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VRegistrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Clientes";
            this.Click += new System.EventHandler(this.btn_SaveClientes_Click);
            this.ptxtClientes.ResumeLayout(false);
            this.ptxtClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Apellido1Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellido2Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_FechaCumpleanios;
        private System.Windows.Forms.CheckBox check_GeneroM;
        private System.Windows.Forms.CheckBox check_GeneroF;
        private System.Windows.Forms.Panel ptxtClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SaveClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Volver;
    }
}