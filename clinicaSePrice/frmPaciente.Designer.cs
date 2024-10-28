namespace clinicaSePrice
{
    partial class frmPaciente
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            pnlSide = new Panel();
            btnMenuPac = new Button();
            btnTurnoPac = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            dgvPacientes = new DataGridView();
            pnlBuscarP = new Panel();
            txtBuscarP = new TextBox();
            grpNuevoPac = new GroupBox();
            cboSexo = new ComboBox();
            cboCoberturaP = new ComboBox();
            lblCoberturaP = new Label();
            dtpFecNacP = new DateTimePicker();
            lblFecNacP = new Label();
            lblSexo = new Label();
            txtDNI = new TextBox();
            lblDNIP = new Label();
            txtCorreoP = new TextBox();
            lblCorreoP = new Label();
            txtTelP = new TextBox();
            lblTelP = new Label();
            txtApeP = new TextBox();
            lblApeP = new Label();
            txtNombreP = new TextBox();
            lblNombre = new Label();
            btnRegistrarP = new Button();
            picSearch = new PictureBox();
            btnNuevoP = new Button();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            pnlBuscarP.SuspendLayout();
            grpNuevoPac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnMenuPac);
            pnlSide.Controls.Add(btnTurnoPac);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(250, 603);
            pnlSide.TabIndex = 1;
            // 
            // btnMenuPac
            // 
            btnMenuPac.FlatAppearance.BorderSize = 0;
            btnMenuPac.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnMenuPac.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnMenuPac.FlatStyle = FlatStyle.Flat;
            btnMenuPac.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuPac.ForeColor = Color.White;
            btnMenuPac.Image = (Image)resources.GetObject("btnMenuPac.Image");
            btnMenuPac.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuPac.Location = new Point(0, 540);
            btnMenuPac.Name = "btnMenuPac";
            btnMenuPac.Size = new Size(250, 42);
            btnMenuPac.TabIndex = 7;
            btnMenuPac.Text = "Menú";
            btnMenuPac.UseVisualStyleBackColor = true;
            btnMenuPac.Click += btnMenuPac_Click;
            // 
            // btnTurnoPac
            // 
            btnTurnoPac.BackColor = Color.FromArgb(33, 32, 43);
            btnTurnoPac.FlatAppearance.BorderSize = 0;
            btnTurnoPac.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnTurnoPac.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnTurnoPac.FlatStyle = FlatStyle.Flat;
            btnTurnoPac.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurnoPac.ForeColor = Color.White;
            btnTurnoPac.Image = (Image)resources.GetObject("btnTurnoPac.Image");
            btnTurnoPac.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnoPac.Location = new Point(-1, 193);
            btnTurnoPac.Name = "btnTurnoPac";
            btnTurnoPac.Size = new Size(250, 42);
            btnTurnoPac.TabIndex = 3;
            btnTurnoPac.Text = "Turnos";
            btnTurnoPac.UseVisualStyleBackColor = false;
            // 
            // lblSePrice
            // 
            lblSePrice.AutoSize = true;
            lblSePrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSePrice.ForeColor = Color.White;
            lblSePrice.Location = new Point(110, 48);
            lblSePrice.Name = "lblSePrice";
            lblSePrice.Size = new Size(93, 32);
            lblSePrice.TabIndex = 2;
            lblSePrice.Text = "SePrice";
            // 
            // lblClinica
            // 
            lblClinica.AutoSize = true;
            lblClinica.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinica.ForeColor = Color.White;
            lblClinica.Location = new Point(108, 21);
            lblClinica.Name = "lblClinica";
            lblClinica.Size = new Size(104, 32);
            lblClinica.TabIndex = 1;
            lblClinica.Text = "CLINICA";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(13, 13);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(114, 77);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(283, 294);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(961, 263);
            dgvPacientes.TabIndex = 2;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // pnlBuscarP
            // 
            pnlBuscarP.BackColor = Color.White;
            pnlBuscarP.Controls.Add(txtBuscarP);
            pnlBuscarP.Location = new Point(860, 249);
            pnlBuscarP.Name = "pnlBuscarP";
            pnlBuscarP.Size = new Size(326, 39);
            pnlBuscarP.TabIndex = 3;
            // 
            // txtBuscarP
            // 
            txtBuscarP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarP.Location = new Point(6, 7);
            txtBuscarP.Name = "txtBuscarP";
            txtBuscarP.Size = new Size(310, 32);
            txtBuscarP.TabIndex = 0;
            txtBuscarP.TextChanged += txtBuscarP_TextChanged;
            // 
            // grpNuevoPac
            // 
            grpNuevoPac.BackColor = Color.White;
            grpNuevoPac.Controls.Add(cboSexo);
            grpNuevoPac.Controls.Add(cboCoberturaP);
            grpNuevoPac.Controls.Add(lblCoberturaP);
            grpNuevoPac.Controls.Add(dtpFecNacP);
            grpNuevoPac.Controls.Add(lblFecNacP);
            grpNuevoPac.Controls.Add(lblSexo);
            grpNuevoPac.Controls.Add(txtDNI);
            grpNuevoPac.Controls.Add(lblDNIP);
            grpNuevoPac.Controls.Add(txtCorreoP);
            grpNuevoPac.Controls.Add(lblCorreoP);
            grpNuevoPac.Controls.Add(txtTelP);
            grpNuevoPac.Controls.Add(lblTelP);
            grpNuevoPac.Controls.Add(txtApeP);
            grpNuevoPac.Controls.Add(lblApeP);
            grpNuevoPac.Controls.Add(txtNombreP);
            grpNuevoPac.Controls.Add(lblNombre);
            grpNuevoPac.Location = new Point(283, 12);
            grpNuevoPac.Name = "grpNuevoPac";
            grpNuevoPac.Size = new Size(961, 198);
            grpNuevoPac.TabIndex = 4;
            grpNuevoPac.TabStop = false;
            grpNuevoPac.Text = "NUEVO PACIENTE";
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboSexo.Location = new Point(498, 135);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(208, 28);
            cboSexo.TabIndex = 16;
            // 
            // cboCoberturaP
            // 
            cboCoberturaP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCoberturaP.FormattingEnabled = true;
            cboCoberturaP.Items.AddRange(new object[] { "Sí", "No" });
            cboCoberturaP.Location = new Point(733, 135);
            cboCoberturaP.Name = "cboCoberturaP";
            cboCoberturaP.Size = new Size(208, 28);
            cboCoberturaP.TabIndex = 15;
            // 
            // lblCoberturaP
            // 
            lblCoberturaP.AutoSize = true;
            lblCoberturaP.Location = new Point(733, 110);
            lblCoberturaP.Name = "lblCoberturaP";
            lblCoberturaP.Size = new Size(168, 20);
            lblCoberturaP.TabIndex = 14;
            lblCoberturaP.Text = "Tiene Cobertura Médica";
            // 
            // dtpFecNacP
            // 
            dtpFecNacP.CustomFormat = "dd/MM/yyyy";
            dtpFecNacP.Format = DateTimePickerFormat.Custom;
            dtpFecNacP.Location = new Point(733, 59);
            dtpFecNacP.MaxDate = new DateTime(8888, 10, 17, 0, 0, 0, 0);
            dtpFecNacP.Name = "dtpFecNacP";
            dtpFecNacP.Size = new Size(208, 27);
            dtpFecNacP.TabIndex = 13;
            dtpFecNacP.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // lblFecNacP
            // 
            lblFecNacP.AutoSize = true;
            lblFecNacP.Location = new Point(733, 34);
            lblFecNacP.Name = "lblFecNacP";
            lblFecNacP.Size = new Size(146, 20);
            lblFecNacP.TabIndex = 12;
            lblFecNacP.Text = "Fecha de nacimiento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(498, 110);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(15, 135);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(212, 27);
            txtDNI.TabIndex = 5;
            // 
            // lblDNIP
            // 
            lblDNIP.AutoSize = true;
            lblDNIP.Location = new Point(15, 110);
            lblDNIP.Name = "lblDNIP";
            lblDNIP.Size = new Size(35, 20);
            lblDNIP.TabIndex = 4;
            lblDNIP.Text = "DNI";
            // 
            // txtCorreoP
            // 
            txtCorreoP.Location = new Point(498, 59);
            txtCorreoP.Name = "txtCorreoP";
            txtCorreoP.Size = new Size(212, 27);
            txtCorreoP.TabIndex = 9;
            // 
            // lblCorreoP
            // 
            lblCorreoP.AutoSize = true;
            lblCorreoP.Location = new Point(498, 34);
            lblCorreoP.Name = "lblCorreoP";
            lblCorreoP.Size = new Size(54, 20);
            lblCorreoP.TabIndex = 8;
            lblCorreoP.Text = "Correo";
            // 
            // txtTelP
            // 
            txtTelP.Location = new Point(256, 135);
            txtTelP.MaxLength = 15;
            txtTelP.Name = "txtTelP";
            txtTelP.Size = new Size(212, 27);
            txtTelP.TabIndex = 7;
            // 
            // lblTelP
            // 
            lblTelP.AutoSize = true;
            lblTelP.Location = new Point(256, 110);
            lblTelP.Name = "lblTelP";
            lblTelP.Size = new Size(67, 20);
            lblTelP.TabIndex = 6;
            lblTelP.Text = "Teléfono";
            // 
            // txtApeP
            // 
            txtApeP.Location = new Point(256, 59);
            txtApeP.MaxLength = 50;
            txtApeP.Name = "txtApeP";
            txtApeP.Size = new Size(212, 27);
            txtApeP.TabIndex = 3;
            // 
            // lblApeP
            // 
            lblApeP.AutoSize = true;
            lblApeP.Location = new Point(256, 34);
            lblApeP.Name = "lblApeP";
            lblApeP.Size = new Size(66, 20);
            lblApeP.TabIndex = 2;
            lblApeP.Text = "Apellido";
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(15, 59);
            txtNombreP.MaxLength = 50;
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(212, 27);
            txtNombreP.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnRegistrarP
            // 
            btnRegistrarP.BackColor = Color.FromArgb(33, 32, 43);
            btnRegistrarP.FlatAppearance.BorderSize = 0;
            btnRegistrarP.FlatStyle = FlatStyle.Flat;
            btnRegistrarP.ForeColor = Color.White;
            btnRegistrarP.Image = (Image)resources.GetObject("btnRegistrarP.Image");
            btnRegistrarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarP.Location = new Point(285, 249);
            btnRegistrarP.Name = "btnRegistrarP";
            btnRegistrarP.Size = new Size(173, 37);
            btnRegistrarP.TabIndex = 5;
            btnRegistrarP.Text = "REGISTRAR";
            btnRegistrarP.UseVisualStyleBackColor = false;
            btnRegistrarP.Click += btnRegistrarP_Click;
            // 
            // picSearch
            // 
            picSearch.BackColor = Color.FromArgb(33, 32, 43);
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(1182, 249);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(62, 39);
            picSearch.SizeMode = PictureBoxSizeMode.CenterImage;
            picSearch.TabIndex = 6;
            picSearch.TabStop = false;
            // 
            // btnNuevoP
            // 
            btnNuevoP.BackColor = Color.FromArgb(33, 32, 43);
            btnNuevoP.FlatAppearance.BorderSize = 0;
            btnNuevoP.FlatStyle = FlatStyle.Flat;
            btnNuevoP.ForeColor = Color.White;
            btnNuevoP.Image = (Image)resources.GetObject("btnNuevoP.Image");
            btnNuevoP.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoP.Location = new Point(667, 250);
            btnNuevoP.Name = "btnNuevoP";
            btnNuevoP.Size = new Size(173, 37);
            btnNuevoP.TabIndex = 7;
            btnNuevoP.Text = "NUEVO";
            btnNuevoP.UseVisualStyleBackColor = false;
            btnNuevoP.Click += btnNuevoP_Click;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(btnNuevoP);
            Controls.Add(picSearch);
            Controls.Add(btnRegistrarP);
            Controls.Add(grpNuevoPac);
            Controls.Add(pnlBuscarP);
            Controls.Add(dgvPacientes);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 650);
            Name = "frmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PACIENTES";
            Load += frmPaciente_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            pnlBuscarP.ResumeLayout(false);
            pnlBuscarP.PerformLayout();
            grpNuevoPac.ResumeLayout(false);
            grpNuevoPac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Button btnMenuPac;
        private Label lblSePrice;
        private Label lblClinica;
        private PictureBox picLogo;
        private Button btnTurnoPac;
        private DataGridView dgvPacientes;
        private Panel pnlBuscarP;
        private GroupBox grpNuevoPac;
        private Label lblNombre;
        private TextBox txtNombreP;
        private TextBox txtApeP;
        private Label lblApeP;
        private TextBox txtTelP;
        private Label lblTelP;
        private TextBox txtDNI;
        private Label lblDNIP;
        private Label lblSexo;
        private TextBox txtCorreoP;
        private Label lblCorreoP;
        private Label lblFecNacP;
        private DateTimePicker dtpFecNacP;
        private Label lblCoberturaP;
        private ComboBox cboCoberturaP;
        private Button btnRegistrarP;
        private ComboBox cboSexo;
        private PictureBox picSearch;
        private TextBox txtBuscarP;
        private Button btnNuevoP;
    }
}