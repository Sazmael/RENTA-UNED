namespace ServidorRentaUned
{
    partial class VAsociarVehiculoSucursal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAsociarVehiculoSucursal));
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IDAsignacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_FechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Sucursales = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_Vehiculos = new System.Windows.Forms.DataGridView();
            this.dGV_Sucursales = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_SaveAsociar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dGV_VehiculosAsociados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehiculosAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(160, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vehiculos asociados a la Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione una Sucursal para asociarle vehiculos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escoja la fila del vehiculo deseado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sucursales activas";
            // 
            // txt_IDAsignacion
            // 
            this.txt_IDAsignacion.Location = new System.Drawing.Point(518, 180);
            this.txt_IDAsignacion.Name = "txt_IDAsignacion";
            this.txt_IDAsignacion.Size = new System.Drawing.Size(132, 26);
            this.txt_IDAsignacion.TabIndex = 8;
            this.txt_IDAsignacion.TextChanged += new System.EventHandler(this.txt_IDAsignacion_TextChanged);
            this.txt_IDAsignacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDAsignacion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Digite un ID de asignacion:";
            // 
            // date_FechaAsignacion
            // 
            this.date_FechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_FechaAsignacion.Location = new System.Drawing.Point(518, 82);
            this.date_FechaAsignacion.Name = "date_FechaAsignacion";
            this.date_FechaAsignacion.Size = new System.Drawing.Size(132, 26);
            this.date_FechaAsignacion.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Seleccione la fecha de asignacion:";
            // 
            // cb_Sucursales
            // 
            this.cb_Sucursales.FormattingEnabled = true;
            this.cb_Sucursales.Location = new System.Drawing.Point(518, 27);
            this.cb_Sucursales.Name = "cb_Sucursales";
            this.cb_Sucursales.Size = new System.Drawing.Size(132, 26);
            this.cb_Sucursales.TabIndex = 15;
            this.cb_Sucursales.SelectedIndexChanged += new System.EventHandler(this.cb_Sucursales_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dGV_Vehiculos);
            this.panel1.Controls.Add(this.dGV_Sucursales);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_Sucursales);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.date_FechaAsignacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_IDAsignacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 338);
            this.panel1.TabIndex = 18;
            // 
            // dGV_Vehiculos
            // 
            this.dGV_Vehiculos.AllowUserToAddRows = false;
            this.dGV_Vehiculos.AllowUserToDeleteRows = false;
            this.dGV_Vehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Vehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Vehiculos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_Vehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Vehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Vehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Vehiculos.ColumnHeadersHeight = 30;
            this.dGV_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Vehiculos.EnableHeadersVisualStyles = false;
            this.dGV_Vehiculos.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_Vehiculos.Location = new System.Drawing.Point(3, 171);
            this.dGV_Vehiculos.Name = "dGV_Vehiculos";
            this.dGV_Vehiculos.ReadOnly = true;
            this.dGV_Vehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Vehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Vehiculos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dGV_Vehiculos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Vehiculos.Size = new System.Drawing.Size(509, 153);
            this.dGV_Vehiculos.TabIndex = 30;
            this.dGV_Vehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Vehiculos_CellClick);
            // 
            // dGV_Sucursales
            // 
            this.dGV_Sucursales.AllowUserToAddRows = false;
            this.dGV_Sucursales.AllowUserToDeleteRows = false;
            this.dGV_Sucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Sucursales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Sucursales.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_Sucursales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Sucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Sucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Sucursales.ColumnHeadersHeight = 30;
            this.dGV_Sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Sucursales.EnableHeadersVisualStyles = false;
            this.dGV_Sucursales.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_Sucursales.Location = new System.Drawing.Point(51, 32);
            this.dGV_Sucursales.Name = "dGV_Sucursales";
            this.dGV_Sucursales.ReadOnly = true;
            this.dGV_Sucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Sucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_Sucursales.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_Sucursales.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_Sucursales.Size = new System.Drawing.Size(387, 115);
            this.dGV_Sucursales.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServidorRentaUned.Properties.Resources.LogoRentaUned;
            this.pictureBox1.Location = new System.Drawing.Point(506, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
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
            this.btn_Volver.Location = new System.Drawing.Point(12, 616);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(488, 53);
            this.btn_Volver.TabIndex = 24;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_SaveAsociar
            // 
            this.btn_SaveAsociar.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveAsociar.Enabled = false;
            this.btn_SaveAsociar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveAsociar.FlatAppearance.BorderSize = 2;
            this.btn_SaveAsociar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SaveAsociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAsociar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAsociar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveAsociar.Image = global::ServidorRentaUned.Properties.Resources.GuardarData;
            this.btn_SaveAsociar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveAsociar.Location = new System.Drawing.Point(12, 385);
            this.btn_SaveAsociar.Name = "btn_SaveAsociar";
            this.btn_SaveAsociar.Size = new System.Drawing.Size(720, 68);
            this.btn_SaveAsociar.TabIndex = 23;
            this.btn_SaveAsociar.Text = "Guardar Asociación";
            this.btn_SaveAsociar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveAsociar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveAsociar.UseVisualStyleBackColor = false;
            this.btn_SaveAsociar.Click += new System.EventHandler(this.btn_SaveAsociar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Asociar Vehiculo a Sucursal";
            // 
            // dGV_VehiculosAsociados
            // 
            this.dGV_VehiculosAsociados.AllowUserToAddRows = false;
            this.dGV_VehiculosAsociados.AllowUserToDeleteRows = false;
            this.dGV_VehiculosAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_VehiculosAsociados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_VehiculosAsociados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_VehiculosAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_VehiculosAsociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_VehiculosAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_VehiculosAsociados.ColumnHeadersHeight = 30;
            this.dGV_VehiculosAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_VehiculosAsociados.EnableHeadersVisualStyles = false;
            this.dGV_VehiculosAsociados.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_VehiculosAsociados.Location = new System.Drawing.Point(11, 484);
            this.dGV_VehiculosAsociados.Name = "dGV_VehiculosAsociados";
            this.dGV_VehiculosAsociados.ReadOnly = true;
            this.dGV_VehiculosAsociados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_VehiculosAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_VehiculosAsociados.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.dGV_VehiculosAsociados.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dGV_VehiculosAsociados.Size = new System.Drawing.Size(489, 126);
            this.dGV_VehiculosAsociados.TabIndex = 31;
            // 
            // VAsociarVehiculoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(738, 681);
            this.Controls.Add(this.dGV_VehiculosAsociados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_SaveAsociar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VAsociarVehiculoSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociar Vehiculos a Sucursal";
            this.Load += new System.EventHandler(this.VAsociarVehiculoSucursal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehiculosAsociados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IDAsignacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_FechaAsignacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Sucursales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_SaveAsociar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_Sucursales;
        private System.Windows.Forms.DataGridView dGV_Vehiculos;
        private System.Windows.Forms.DataGridView dGV_VehiculosAsociados;
    }
}