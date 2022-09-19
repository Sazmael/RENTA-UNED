namespace ClienteRentaUned
{
    partial class VLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDClienteLog = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.label_EstadoOnline = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(323, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite su numero de Identificación:";
            // 
            // txt_IDClienteLog
            // 
            this.txt_IDClienteLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_IDClienteLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDClienteLog.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDClienteLog.ForeColor = System.Drawing.Color.Silver;
            this.txt_IDClienteLog.Location = new System.Drawing.Point(327, 116);
            this.txt_IDClienteLog.Name = "txt_IDClienteLog";
            this.txt_IDClienteLog.Size = new System.Drawing.Size(364, 20);
            this.txt_IDClienteLog.TabIndex = 1;
            this.txt_IDClienteLog.Text = "IDENTIFICACIÓN";
            this.txt_IDClienteLog.TextChanged += new System.EventHandler(this.txt_IDClienteLog_TextChanged);
            this.txt_IDClienteLog.Enter += new System.EventHandler(this.txt_IDClienteLog_Enter);
            this.txt_IDClienteLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDClienteLog_KeyPress);
            this.txt_IDClienteLog.Leave += new System.EventHandler(this.txt_IDClienteLog_Leave);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Blue;
            this.btn_Ingresar.Enabled = false;
            this.btn_Ingresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Ingresar.FlatAppearance.BorderSize = 2;
            this.btn_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(327, 174);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(364, 50);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // label_EstadoOnline
            // 
            this.label_EstadoOnline.AutoSize = true;
            this.label_EstadoOnline.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EstadoOnline.ForeColor = System.Drawing.Color.Red;
            this.label_EstadoOnline.Location = new System.Drawing.Point(40, 116);
            this.label_EstadoOnline.Name = "label_EstadoOnline";
            this.label_EstadoOnline.Size = new System.Drawing.Size(58, 19);
            this.label_EstadoOnline.TabIndex = 6;
            this.label_EstadoOnline.Text = "Estado";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Location = new System.Drawing.Point(634, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 47);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btn_Conectar);
            this.panel1.Controls.Add(this.btn_Desconectar);
            this.panel1.Controls.Add(this.label_EstadoOnline);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 359);
            this.panel1.TabIndex = 8;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.Lime;
            this.btn_Conectar.FlatAppearance.BorderSize = 0;
            this.btn_Conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conectar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Conectar.Image = global::ClienteRentaUned.Properties.Resources.turnon;
            this.btn_Conectar.Location = new System.Drawing.Point(8, 175);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(246, 73);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "Conectar con servidor";
            this.btn_Conectar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.BackColor = System.Drawing.Color.Red;
            this.btn_Desconectar.FlatAppearance.BorderSize = 0;
            this.btn_Desconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Desconectar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desconectar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Desconectar.Image = global::ClienteRentaUned.Properties.Resources.turnoff2;
            this.btn_Desconectar.Location = new System.Drawing.Point(8, 267);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(246, 73);
            this.btn_Desconectar.TabIndex = 2;
            this.btn_Desconectar.Text = "Desconectar del servidor";
            this.btn_Desconectar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Desconectar.UseVisualStyleBackColor = false;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox1.Image = global::ClienteRentaUned.Properties.Resources.Rentaunedlogo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(327, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 3);
            this.panel2.TabIndex = 9;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.Red;
            this.label_Login.Location = new System.Drawing.Point(444, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(100, 33);
            this.label_Login.TabIndex = 10;
            this.label_Login.Text = "LOGIN";
            // 
            // VLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(765, 359);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_IDClienteLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDClienteLog;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Desconectar;
        private System.Windows.Forms.Label label_EstadoOnline;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}