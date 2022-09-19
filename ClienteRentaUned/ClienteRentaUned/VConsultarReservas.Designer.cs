namespace ClienteRentaUned
{
    partial class VConsultarReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VConsultarReservas));
            this.label_NombreCliente = new System.Windows.Forms.Label();
            this.txt_IDReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_Reservas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BuscarReserva = new System.Windows.Forms.Button();
            this.btn_TodaReserva = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NombreCliente
            // 
            this.label_NombreCliente.AutoSize = true;
            this.label_NombreCliente.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_NombreCliente.Location = new System.Drawing.Point(12, 23);
            this.label_NombreCliente.Name = "label_NombreCliente";
            this.label_NombreCliente.Size = new System.Drawing.Size(362, 23);
            this.label_NombreCliente.TabIndex = 6;
            this.label_NombreCliente.Text = "Reservas de Nombre Apellido1 Apellido2";
            // 
            // txt_IDReserva
            // 
            this.txt_IDReserva.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDReserva.Location = new System.Drawing.Point(949, 20);
            this.txt_IDReserva.Name = "txt_IDReserva";
            this.txt_IDReserva.Size = new System.Drawing.Size(115, 26);
            this.txt_IDReserva.TabIndex = 8;
            this.txt_IDReserva.TextChanged += new System.EventHandler(this.txt_IDReserva_TextChanged);
            this.txt_IDReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDReserva_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(631, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite el ID de la Reserva a buscar:";
            // 
            // dGV_Reservas
            // 
            this.dGV_Reservas.AllowUserToAddRows = false;
            this.dGV_Reservas.AllowUserToDeleteRows = false;
            this.dGV_Reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Reservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Reservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_Reservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Reservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Reservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Reservas.ColumnHeadersHeight = 30;
            this.dGV_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Reservas.EnableHeadersVisualStyles = false;
            this.dGV_Reservas.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_Reservas.Location = new System.Drawing.Point(16, 136);
            this.dGV_Reservas.Name = "dGV_Reservas";
            this.dGV_Reservas.ReadOnly = true;
            this.dGV_Reservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Reservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Reservas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dGV_Reservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Reservas.Size = new System.Drawing.Size(1056, 247);
            this.dGV_Reservas.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClienteRentaUned.Properties.Resources.Rentaunedlogo;
            this.pictureBox1.Location = new System.Drawing.Point(445, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BuscarReserva
            // 
            this.btn_BuscarReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BuscarReserva.Enabled = false;
            this.btn_BuscarReserva.FlatAppearance.BorderSize = 0;
            this.btn_BuscarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_BuscarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarReserva.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarReserva.Image = global::ClienteRentaUned.Properties.Resources.searchcar64;
            this.btn_BuscarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarReserva.Location = new System.Drawing.Point(635, 52);
            this.btn_BuscarReserva.Name = "btn_BuscarReserva";
            this.btn_BuscarReserva.Size = new System.Drawing.Size(429, 78);
            this.btn_BuscarReserva.TabIndex = 9;
            this.btn_BuscarReserva.Text = "Buscar Reserva";
            this.btn_BuscarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_BuscarReserva.UseVisualStyleBackColor = false;
            this.btn_BuscarReserva.Click += new System.EventHandler(this.btn_BuscarReserva_Click);
            // 
            // btn_TodaReserva
            // 
            this.btn_TodaReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_TodaReserva.FlatAppearance.BorderSize = 0;
            this.btn_TodaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_TodaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TodaReserva.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TodaReserva.Image = global::ClienteRentaUned.Properties.Resources.rentcar4;
            this.btn_TodaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TodaReserva.Location = new System.Drawing.Point(12, 52);
            this.btn_TodaReserva.Name = "btn_TodaReserva";
            this.btn_TodaReserva.Size = new System.Drawing.Size(522, 78);
            this.btn_TodaReserva.TabIndex = 7;
            this.btn_TodaReserva.Text = "Mostrar todas mis reservas";
            this.btn_TodaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TodaReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_TodaReserva.UseVisualStyleBackColor = false;
            this.btn_TodaReserva.Click += new System.EventHandler(this.btn_TodaReserva_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Image = global::ClienteRentaUned.Properties.Resources.backazul;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(12, 435);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(362, 64);
            this.btn_Volver.TabIndex = 5;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // VConsultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dGV_Reservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BuscarReserva);
            this.Controls.Add(this.txt_IDReserva);
            this.Controls.Add(this.btn_TodaReserva);
            this.Controls.Add(this.label_NombreCliente);
            this.Controls.Add(this.btn_Volver);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VConsultarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Reservas";
            this.Load += new System.EventHandler(this.VConsultarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Volver;
        public System.Windows.Forms.Label label_NombreCliente;
        private System.Windows.Forms.Button btn_TodaReserva;
        private System.Windows.Forms.TextBox txt_IDReserva;
        private System.Windows.Forms.Button btn_BuscarReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV_Reservas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}