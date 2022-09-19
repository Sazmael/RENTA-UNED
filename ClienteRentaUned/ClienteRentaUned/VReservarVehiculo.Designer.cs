namespace ClienteRentaUned
{
    partial class VReservarVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VReservarVehiculo));
            this.label_NombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.date_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSucursalesActivas = new System.Windows.Forms.ComboBox();
            this.dGV_Coberturas = new System.Windows.Forms.DataGridView();
            this.DescripcionCobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_VehiculosSucursalAsoc = new System.Windows.Forms.DataGridView();
            this.dGV_InfoReserva = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_InfoReserva = new System.Windows.Forms.Button();
            this.btn_SaveReserva = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Coberturas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehiculosSucursalAsoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_InfoReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NombreCliente
            // 
            this.label_NombreCliente.AutoSize = true;
            this.label_NombreCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreCliente.Location = new System.Drawing.Point(-1, 0);
            this.label_NombreCliente.Name = "label_NombreCliente";
            this.label_NombreCliente.Size = new System.Drawing.Size(211, 19);
            this.label_NombreCliente.TabIndex = 3;
            this.label_NombreCliente.Text = "Nombre Apellido1 Apellido2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una Sucursal para mostrar los Vehiculos disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(261, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Click para seleccionar un vehiculo de la Sucursal";
            // 
            // date_FechaInicio
            // 
            this.date_FechaInicio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_FechaInicio.Location = new System.Drawing.Point(447, 301);
            this.date_FechaInicio.MinDate = new System.DateTime(2022, 8, 9, 0, 0, 0, 0);
            this.date_FechaInicio.Name = "date_FechaInicio";
            this.date_FechaInicio.Size = new System.Drawing.Size(115, 26);
            this.date_FechaInicio.TabIndex = 19;
            this.date_FechaInicio.Value = new System.DateTime(2022, 8, 9, 0, 0, 0, 0);
            // 
            // date_FechaFin
            // 
            this.date_FechaFin.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_FechaFin.Location = new System.Drawing.Point(630, 301);
            this.date_FechaFin.MinDate = new System.DateTime(2022, 8, 9, 0, 0, 0, 0);
            this.date_FechaFin.Name = "date_FechaFin";
            this.date_FechaFin.Size = new System.Drawing.Size(115, 26);
            this.date_FechaFin.TabIndex = 20;
            this.date_FechaFin.Value = new System.DateTime(2022, 8, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(412, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha inicio de la Reserva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(614, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha fin de la Reserva:";
            // 
            // cbSucursalesActivas
            // 
            this.cbSucursalesActivas.FormattingEnabled = true;
            this.cbSucursalesActivas.Location = new System.Drawing.Point(281, 35);
            this.cbSucursalesActivas.Name = "cbSucursalesActivas";
            this.cbSucursalesActivas.Size = new System.Drawing.Size(210, 21);
            this.cbSucursalesActivas.TabIndex = 23;
            this.cbSucursalesActivas.SelectionChangeCommitted += new System.EventHandler(this.cbSucursalesActivas_SelectionChangeCommitted);
            // 
            // dGV_Coberturas
            // 
            this.dGV_Coberturas.AllowUserToAddRows = false;
            this.dGV_Coberturas.AllowUserToDeleteRows = false;
            this.dGV_Coberturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Coberturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Coberturas.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_Coberturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Coberturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Coberturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Coberturas.ColumnHeadersHeight = 30;
            this.dGV_Coberturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Coberturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionCobertura,
            this.Monto,
            this.check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Coberturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Coberturas.EnableHeadersVisualStyles = false;
            this.dGV_Coberturas.Location = new System.Drawing.Point(13, 263);
            this.dGV_Coberturas.Name = "dGV_Coberturas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Coberturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Coberturas.RowHeadersVisible = false;
            this.dGV_Coberturas.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_Coberturas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Coberturas.Size = new System.Drawing.Size(374, 116);
            this.dGV_Coberturas.TabIndex = 27;
            this.dGV_Coberturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Coberturas_CellContentClick);
            // 
            // DescripcionCobertura
            // 
            this.DescripcionCobertura.HeaderText = "Tipo de Cobertura";
            this.DescripcionCobertura.Name = "DescripcionCobertura";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // check
            // 
            this.check.HeaderText = "Marcar";
            this.check.Name = "check";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(10, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Marque los tipos de Coberturas deseados en el alquiler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "#Calcule la reserva antes de Confirmarla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(444, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Seleccione las fechas a Reservar el Vehiculo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dGV_VehiculosSucursalAsoc);
            this.panel1.Controls.Add(this.cbSucursalesActivas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.date_FechaFin);
            this.panel1.Controls.Add(this.date_FechaInicio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dGV_Coberturas);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(49, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 384);
            this.panel1.TabIndex = 33;
            // 
            // dGV_VehiculosSucursalAsoc
            // 
            this.dGV_VehiculosSucursalAsoc.AllowUserToAddRows = false;
            this.dGV_VehiculosSucursalAsoc.AllowUserToDeleteRows = false;
            this.dGV_VehiculosSucursalAsoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_VehiculosSucursalAsoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_VehiculosSucursalAsoc.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGV_VehiculosSucursalAsoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_VehiculosSucursalAsoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_VehiculosSucursalAsoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_VehiculosSucursalAsoc.ColumnHeadersHeight = 30;
            this.dGV_VehiculosSucursalAsoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_VehiculosSucursalAsoc.EnableHeadersVisualStyles = false;
            this.dGV_VehiculosSucursalAsoc.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_VehiculosSucursalAsoc.Location = new System.Drawing.Point(13, 81);
            this.dGV_VehiculosSucursalAsoc.Name = "dGV_VehiculosSucursalAsoc";
            this.dGV_VehiculosSucursalAsoc.ReadOnly = true;
            this.dGV_VehiculosSucursalAsoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_VehiculosSucursalAsoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_VehiculosSucursalAsoc.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dGV_VehiculosSucursalAsoc.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_VehiculosSucursalAsoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_VehiculosSucursalAsoc.Size = new System.Drawing.Size(766, 158);
            this.dGV_VehiculosSucursalAsoc.TabIndex = 33;
            this.dGV_VehiculosSucursalAsoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_VehiculosSucursalAsoc_CellMouseClick);
            // 
            // dGV_InfoReserva
            // 
            this.dGV_InfoReserva.AllowUserToAddRows = false;
            this.dGV_InfoReserva.AllowUserToDeleteRows = false;
            this.dGV_InfoReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_InfoReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_InfoReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dGV_InfoReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_InfoReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_InfoReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_InfoReserva.ColumnHeadersHeight = 30;
            this.dGV_InfoReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_InfoReserva.EnableHeadersVisualStyles = false;
            this.dGV_InfoReserva.GridColor = System.Drawing.Color.SteelBlue;
            this.dGV_InfoReserva.Location = new System.Drawing.Point(49, 465);
            this.dGV_InfoReserva.Name = "dGV_InfoReserva";
            this.dGV_InfoReserva.ReadOnly = true;
            this.dGV_InfoReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_InfoReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dGV_InfoReserva.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dGV_InfoReserva.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dGV_InfoReserva.Size = new System.Drawing.Size(790, 70);
            this.dGV_InfoReserva.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClienteRentaUned.Properties.Resources.Rentaunedlogo;
            this.pictureBox1.Location = new System.Drawing.Point(315, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btn_InfoReserva
            // 
            this.btn_InfoReserva.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_InfoReserva.Enabled = false;
            this.btn_InfoReserva.FlatAppearance.BorderSize = 0;
            this.btn_InfoReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btn_InfoReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoReserva.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoReserva.Image = global::ClienteRentaUned.Properties.Resources.calculadora;
            this.btn_InfoReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InfoReserva.Location = new System.Drawing.Point(49, 415);
            this.btn_InfoReserva.Name = "btn_InfoReserva";
            this.btn_InfoReserva.Size = new System.Drawing.Size(790, 44);
            this.btn_InfoReserva.TabIndex = 30;
            this.btn_InfoReserva.Text = "Calcular Reserva";
            this.btn_InfoReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InfoReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_InfoReserva.UseVisualStyleBackColor = false;
            this.btn_InfoReserva.Click += new System.EventHandler(this.btn_InfoReserva_Click);
            // 
            // btn_SaveReserva
            // 
            this.btn_SaveReserva.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveReserva.Enabled = false;
            this.btn_SaveReserva.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SaveReserva.FlatAppearance.BorderSize = 2;
            this.btn_SaveReserva.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SaveReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveReserva.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveReserva.Image = global::ClienteRentaUned.Properties.Resources.rentcar2;
            this.btn_SaveReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveReserva.Location = new System.Drawing.Point(49, 541);
            this.btn_SaveReserva.Name = "btn_SaveReserva";
            this.btn_SaveReserva.Size = new System.Drawing.Size(790, 63);
            this.btn_SaveReserva.TabIndex = 25;
            this.btn_SaveReserva.Text = "Confirmar Reserva";
            this.btn_SaveReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SaveReserva.UseVisualStyleBackColor = false;
            this.btn_SaveReserva.Click += new System.EventHandler(this.btn_SaveReserva_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Image = global::ClienteRentaUned.Properties.Resources.backazul;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(12, 628);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(297, 51);
            this.btn_Volver.TabIndex = 4;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // VReservarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(879, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dGV_InfoReserva);
            this.Controls.Add(this.btn_InfoReserva);
            this.Controls.Add(this.btn_SaveReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.label_NombreCliente);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VReservarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas de Vehiculos";
            this.Load += new System.EventHandler(this.VReservarVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Coberturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehiculosSucursalAsoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_InfoReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_NombreCliente;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_FechaInicio;
        private System.Windows.Forms.DateTimePicker date_FechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSucursalesActivas;
        private System.Windows.Forms.Button btn_SaveReserva;
        private System.Windows.Forms.DataGridView dGV_Coberturas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.Button btn_InfoReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGV_VehiculosSucursalAsoc;
        private System.Windows.Forms.DataGridView dGV_InfoReserva;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}