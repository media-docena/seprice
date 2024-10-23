namespace clinicaSePrice
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSide = new Panel();
            btnMenu = new Button();
            btnAgenda = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            picRol = new PictureBox();
            panel1 = new Panel();
            btnRegistrarPago = new Button();
            lblFecAgenda = new Label();
            btnCancelarTurno = new Button();
            dtpFecAgenda = new DateTimePicker();
            btnConfirmarTurno = new Button();
            lblMedico = new Label();
            btnBuscarAgenda = new Button();
            cboMedico = new ComboBox();
            dtgvAgendaDiaria = new DataGridView();
            tabControl1 = new TabControl();
            tabPageAgenda = new TabPage();
            tabPagePago = new TabPage();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            lblFormaPago = new Label();
            cboFormaPago = new ComboBox();
            btnConfirmarRegPag = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            panel3 = new Panel();
            idTurno = new DataGridViewTextBoxColumn();
            inicioTurno = new DataGridViewTextBoxColumn();
            idPaciente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            checkBox = new DataGridViewCheckBoxColumn();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRol).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAgendaDiaria).BeginInit();
            tabControl1.SuspendLayout();
            tabPageAgenda.SuspendLayout();
            tabPagePago.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnMenu);
            pnlSide.Controls.Add(btnAgenda);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Margin = new Padding(3, 2, 3, 2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(219, 458);
            pnlSide.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 405);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(219, 32);
            btnMenu.TabIndex = 8;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = Color.FromArgb(33, 32, 43);
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgenda.Location = new Point(-1, 184);
            btnAgenda.Margin = new Padding(3, 2, 3, 2);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(219, 32);
            btnAgenda.TabIndex = 4;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = false;
            // 
            // lblSePrice
            // 
            lblSePrice.AutoSize = true;
            lblSePrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSePrice.ForeColor = Color.White;
            lblSePrice.Location = new Point(96, 36);
            lblSePrice.Name = "lblSePrice";
            lblSePrice.Size = new Size(74, 25);
            lblSePrice.TabIndex = 2;
            lblSePrice.Text = "SePrice";
            // 
            // lblClinica
            // 
            lblClinica.AutoSize = true;
            lblClinica.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinica.ForeColor = Color.White;
            lblClinica.Location = new Point(94, 16);
            lblClinica.Name = "lblClinica";
            lblClinica.Size = new Size(85, 25);
            lblClinica.TabIndex = 1;
            lblClinica.Text = "CLINICA";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(11, 10);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 58);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // picRol
            // 
            picRol.Image = (Image)resources.GetObject("picRol.Image");
            picRol.Location = new Point(0, 1);
            picRol.Margin = new Padding(3, 2, 3, 2);
            picRol.Name = "picRol";
            picRol.Size = new Size(89, 119);
            picRol.SizeMode = PictureBoxSizeMode.Zoom;
            picRol.TabIndex = 2;
            picRol.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarPago);
            panel1.Controls.Add(lblFecAgenda);
            panel1.Controls.Add(btnCancelarTurno);
            panel1.Controls.Add(dtpFecAgenda);
            panel1.Controls.Add(btnConfirmarTurno);
            panel1.Controls.Add(lblMedico);
            panel1.Controls.Add(btnBuscarAgenda);
            panel1.Controls.Add(cboMedico);
            panel1.Controls.Add(picRol);
            panel1.Location = new Point(437, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 120);
            panel1.TabIndex = 3;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.FromArgb(33, 32, 43);
            btnRegistrarPago.FlatAppearance.BorderSize = 0;
            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.ForeColor = Color.White;
            btnRegistrarPago.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPago.Location = new Point(308, 89);
            btnRegistrarPago.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(151, 28);
            btnRegistrarPago.TabIndex = 10;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // lblFecAgenda
            // 
            lblFecAgenda.AutoSize = true;
            lblFecAgenda.Location = new Point(95, 45);
            lblFecAgenda.Name = "lblFecAgenda";
            lblFecAgenda.Size = new Size(115, 15);
            lblFecAgenda.TabIndex = 19;
            lblFecAgenda.Text = "Fecha Agenda Diaria";
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.BackColor = Color.Maroon;
            btnCancelarTurno.FlatAppearance.BorderSize = 0;
            btnCancelarTurno.FlatStyle = FlatStyle.Flat;
            btnCancelarTurno.ForeColor = Color.White;
            btnCancelarTurno.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarTurno.Location = new Point(308, 46);
            btnCancelarTurno.Margin = new Padding(3, 2, 3, 2);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(151, 28);
            btnCancelarTurno.TabIndex = 9;
            btnCancelarTurno.Text = "Cancelar Turno";
            btnCancelarTurno.UseVisualStyleBackColor = false;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // dtpFecAgenda
            // 
            dtpFecAgenda.CustomFormat = "dd/MM/yyyy";
            dtpFecAgenda.Format = DateTimePickerFormat.Custom;
            dtpFecAgenda.Location = new Point(95, 62);
            dtpFecAgenda.Margin = new Padding(3, 2, 3, 2);
            dtpFecAgenda.MaxDate = new DateTime(8888, 10, 17, 0, 0, 0, 0);
            dtpFecAgenda.Name = "dtpFecAgenda";
            dtpFecAgenda.Size = new Size(182, 23);
            dtpFecAgenda.TabIndex = 18;
            dtpFecAgenda.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // btnConfirmarTurno
            // 
            btnConfirmarTurno.BackColor = Color.Green;
            btnConfirmarTurno.FlatAppearance.BorderSize = 0;
            btnConfirmarTurno.FlatStyle = FlatStyle.Flat;
            btnConfirmarTurno.ForeColor = Color.White;
            btnConfirmarTurno.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarTurno.Location = new Point(308, 3);
            btnConfirmarTurno.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarTurno.Name = "btnConfirmarTurno";
            btnConfirmarTurno.Size = new Size(151, 28);
            btnConfirmarTurno.TabIndex = 8;
            btnConfirmarTurno.Text = "Confirmar Turno";
            btnConfirmarTurno.UseVisualStyleBackColor = false;
            btnConfirmarTurno.Click += btnConfirmarTurno_Click;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(95, 3);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(47, 15);
            lblMedico.TabIndex = 20;
            lblMedico.Text = "Medico";
            // 
            // btnBuscarAgenda
            // 
            btnBuscarAgenda.BackColor = Color.FromArgb(33, 32, 43);
            btnBuscarAgenda.FlatAppearance.BorderSize = 0;
            btnBuscarAgenda.FlatStyle = FlatStyle.Flat;
            btnBuscarAgenda.ForeColor = Color.White;
            btnBuscarAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarAgenda.Location = new Point(108, 89);
            btnBuscarAgenda.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAgenda.Name = "btnBuscarAgenda";
            btnBuscarAgenda.Size = new Size(151, 28);
            btnBuscarAgenda.TabIndex = 6;
            btnBuscarAgenda.Text = "BUSCAR";
            btnBuscarAgenda.UseVisualStyleBackColor = false;
            btnBuscarAgenda.Click += btnBuscarAgenda_Click;
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.FormattingEnabled = true;
            cboMedico.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboMedico.Location = new Point(95, 20);
            cboMedico.Margin = new Padding(3, 2, 3, 2);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(182, 23);
            cboMedico.TabIndex = 17;
            // 
            // dtgvAgendaDiaria
            // 
            dtgvAgendaDiaria.AllowUserToAddRows = false;
            dtgvAgendaDiaria.AllowUserToDeleteRows = false;
            dtgvAgendaDiaria.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAgendaDiaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAgendaDiaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAgendaDiaria.Columns.AddRange(new DataGridViewColumn[] { idTurno, inicioTurno, idPaciente, nombre, apellido, dni, checkBox });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvAgendaDiaria.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvAgendaDiaria.Dock = DockStyle.Fill;
            dtgvAgendaDiaria.GridColor = Color.DarkGray;
            dtgvAgendaDiaria.Location = new Point(3, 3);
            dtgvAgendaDiaria.Name = "dtgvAgendaDiaria";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 97, 129);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvAgendaDiaria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dtgvAgendaDiaria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgvAgendaDiaria.Size = new Size(733, 286);
            dtgvAgendaDiaria.TabIndex = 4;
            dtgvAgendaDiaria.CellContentClick += dtgvAgendaDiaria_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAgenda);
            tabControl1.Controls.Add(tabPagePago);
            tabControl1.Location = new Point(303, 138);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(747, 320);
            tabControl1.TabIndex = 6;
            // 
            // tabPageAgenda
            // 
            tabPageAgenda.BackColor = Color.White;
            tabPageAgenda.Controls.Add(dtgvAgendaDiaria);
            tabPageAgenda.ForeColor = Color.White;
            tabPageAgenda.Location = new Point(4, 24);
            tabPageAgenda.Name = "tabPageAgenda";
            tabPageAgenda.Padding = new Padding(3);
            tabPageAgenda.Size = new Size(739, 292);
            tabPageAgenda.TabIndex = 0;
            // 
            // tabPagePago
            // 
            tabPagePago.BackColor = Color.White;
            tabPagePago.Controls.Add(panel2);
            tabPagePago.ForeColor = Color.White;
            tabPagePago.Location = new Point(4, 24);
            tabPagePago.Name = "tabPagePago";
            tabPagePago.Padding = new Padding(3);
            tabPagePago.Size = new Size(739, 292);
            tabPagePago.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(lblFormaPago);
            panel2.Controls.Add(cboFormaPago);
            panel2.Controls.Add(btnConfirmarRegPag);
            panel2.Controls.Add(txtMonto);
            panel2.Controls.Add(lblMonto);
            panel2.Location = new Point(130, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 253);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(33, 32, 43);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(305, 221);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(151, 28);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.BackColor = Color.Transparent;
            lblFormaPago.ForeColor = Color.Black;
            lblFormaPago.Location = new Point(187, 77);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 26;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cboFormaPago.Location = new Point(187, 95);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(182, 23);
            cboFormaPago.TabIndex = 25;
            cboFormaPago.SelectedIndexChanged += cboFormaPago_SelectedIndexChanged;
            // 
            // btnConfirmarRegPag
            // 
            btnConfirmarRegPag.BackColor = Color.FromArgb(33, 32, 43);
            btnConfirmarRegPag.FlatAppearance.BorderSize = 0;
            btnConfirmarRegPag.FlatStyle = FlatStyle.Flat;
            btnConfirmarRegPag.ForeColor = Color.White;
            btnConfirmarRegPag.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarRegPag.Location = new Point(158, 123);
            btnConfirmarRegPag.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarRegPag.Name = "btnConfirmarRegPag";
            btnConfirmarRegPag.Size = new Size(151, 28);
            btnConfirmarRegPag.TabIndex = 21;
            btnConfirmarRegPag.Text = "Confirmar Registro";
            btnConfirmarRegPag.UseVisualStyleBackColor = false;
            btnConfirmarRegPag.Click += btnConfirmarRegPag_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(187, 51);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(182, 23);
            txtMonto.TabIndex = 24;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.ForeColor = Color.Black;
            lblMonto.Location = new Point(187, 33);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 23;
            lblMonto.Text = "Monto";
            // 
            // panel3
            // 
            panel3.Location = new Point(303, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 27);
            panel3.TabIndex = 7;
            // 
            // idTurno
            // 
            idTurno.HeaderText = "ID Turno";
            idTurno.Name = "idTurno";
            idTurno.ReadOnly = true;
            idTurno.Resizable = DataGridViewTriState.True;
            idTurno.Visible = false;
            idTurno.Width = 80;
            // 
            // inicioTurno
            // 
            inicioTurno.HeaderText = "Hora Inicio";
            inicioTurno.Name = "inicioTurno";
            inicioTurno.ReadOnly = true;
            inicioTurno.Resizable = DataGridViewTriState.True;
            inicioTurno.Width = 142;
            // 
            // idPaciente
            // 
            idPaciente.HeaderText = "ID Paciente";
            idPaciente.Name = "idPaciente";
            idPaciente.ReadOnly = true;
            idPaciente.Resizable = DataGridViewTriState.True;
            idPaciente.Visible = false;
            idPaciente.Width = 90;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre Paciente";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Resizable = DataGridViewTriState.True;
            nombre.Width = 180;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido Paciente";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Resizable = DataGridViewTriState.True;
            apellido.Width = 180;
            // 
            // dni
            // 
            dni.HeaderText = "DNI Paciente";
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Resizable = DataGridViewTriState.True;
            dni.Width = 150;
            // 
            // checkBox
            // 
            checkBox.HeaderText = "";
            checkBox.Name = "checkBox";
            checkBox.Resizable = DataGridViewTriState.False;
            checkBox.Width = 40;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 458);
            Controls.Add(panel3);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(pnlSide);
            MaximumSize = new Size(1140, 497);
            MinimumSize = new Size(1140, 497);
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGENDA";
            Load += frmAgenda_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRol).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAgendaDiaria).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageAgenda.ResumeLayout(false);
            tabPagePago.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Button btnAgenda;
        private Label lblSePrice;
        private Label lblClinica;
        private PictureBox picLogo;
        private Button btnMenu;
        private PictureBox picRol;
        private Panel panel1;
        private ComboBox cboMedico;
        private DateTimePicker dtpFecAgenda;
        private Label lblFecAgenda;
        private Label lblMedico;
        private Button btnBuscarAgenda;
        private Button button1;
        private Button btnConfirmarTurno;
        private Button btnRegistrarPago;
        private Button btnCancelarTurno;
        private DataGridView dtgvAgendaDiaria;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPageAgenda;
        private TabPage tabPagePago;
        private Button btnVolver;
        private Button btnConfirmarRegPag;
        private Panel panel2;
        private Label lblFormaPago;
        private ComboBox cboFormaPago;
        private TextBox txtMonto;
        private Label lblMonto;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridViewTextBoxColumn idTurno;
        private DataGridViewTextBoxColumn inicioTurno;
        private DataGridViewTextBoxColumn idPaciente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewCheckBoxColumn checkBox;
    }
}