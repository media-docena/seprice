namespace clinicaSePrice
{
    partial class frmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurno));
            pnlSideT = new Panel();
            btnMenuT = new Button();
            btnTurnoT = new Button();
            lblSePriceT = new Label();
            lblClinicaT = new Label();
            picLogoT = new PictureBox();
            dgvAgendaTurnos = new DataGridView();
            lblEspeT = new Label();
            lblMedicoT = new Label();
            lblFechaT = new Label();
            cboEspeT = new ComboBox();
            cboMedicoT = new ComboBox();
            dtpFechaT = new DateTimePicker();
            btnBuscarT = new Button();
            lblMensajeT = new Label();
            btnVolverAPacientes = new Button();
            pnlSideT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendaTurnos).BeginInit();
            SuspendLayout();
            // 
            // pnlSideT
            // 
            pnlSideT.BackColor = Color.FromArgb(100, 97, 129);
            pnlSideT.Controls.Add(btnMenuT);
            pnlSideT.Controls.Add(btnTurnoT);
            pnlSideT.Controls.Add(lblSePriceT);
            pnlSideT.Controls.Add(lblClinicaT);
            pnlSideT.Controls.Add(picLogoT);
            pnlSideT.Dock = DockStyle.Left;
            pnlSideT.Location = new Point(0, 0);
            pnlSideT.Name = "pnlSideT";
            pnlSideT.Size = new Size(250, 600);
            pnlSideT.TabIndex = 2;
            // 
            // btnMenuT
            // 
            btnMenuT.FlatAppearance.BorderSize = 0;
            btnMenuT.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnMenuT.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnMenuT.FlatStyle = FlatStyle.Flat;
            btnMenuT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuT.ForeColor = Color.White;
            btnMenuT.Image = (Image)resources.GetObject("btnMenuT.Image");
            btnMenuT.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuT.Location = new Point(0, 540);
            btnMenuT.Name = "btnMenuT";
            btnMenuT.Size = new Size(250, 42);
            btnMenuT.TabIndex = 7;
            btnMenuT.Text = "Menú";
            btnMenuT.UseVisualStyleBackColor = true;
            btnMenuT.Click += btnMenuT_Click;
            // 
            // btnTurnoT
            // 
            btnTurnoT.BackColor = Color.FromArgb(33, 32, 43);
            btnTurnoT.FlatAppearance.BorderSize = 0;
            btnTurnoT.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnTurnoT.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnTurnoT.FlatStyle = FlatStyle.Flat;
            btnTurnoT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurnoT.ForeColor = Color.White;
            btnTurnoT.Image = (Image)resources.GetObject("btnTurnoT.Image");
            btnTurnoT.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnoT.Location = new Point(-1, 193);
            btnTurnoT.Name = "btnTurnoT";
            btnTurnoT.Size = new Size(250, 42);
            btnTurnoT.TabIndex = 3;
            btnTurnoT.Text = "Turnos";
            btnTurnoT.UseVisualStyleBackColor = false;
            // 
            // lblSePriceT
            // 
            lblSePriceT.AutoSize = true;
            lblSePriceT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSePriceT.ForeColor = Color.White;
            lblSePriceT.Location = new Point(110, 48);
            lblSePriceT.Name = "lblSePriceT";
            lblSePriceT.Size = new Size(93, 32);
            lblSePriceT.TabIndex = 2;
            lblSePriceT.Text = "SePrice";
            // 
            // lblClinicaT
            // 
            lblClinicaT.AutoSize = true;
            lblClinicaT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicaT.ForeColor = Color.White;
            lblClinicaT.Location = new Point(108, 21);
            lblClinicaT.Name = "lblClinicaT";
            lblClinicaT.Size = new Size(104, 32);
            lblClinicaT.TabIndex = 1;
            lblClinicaT.Text = "CLINICA";
            // 
            // picLogoT
            // 
            picLogoT.Image = (Image)resources.GetObject("picLogoT.Image");
            picLogoT.Location = new Point(13, 13);
            picLogoT.Name = "picLogoT";
            picLogoT.Size = new Size(114, 77);
            picLogoT.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoT.TabIndex = 0;
            picLogoT.TabStop = false;
            // 
            // dgvAgendaTurnos
            // 
            dgvAgendaTurnos.AllowUserToAddRows = false;
            dgvAgendaTurnos.AllowUserToDeleteRows = false;
            dgvAgendaTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendaTurnos.Location = new Point(281, 242);
            dgvAgendaTurnos.Name = "dgvAgendaTurnos";
            dgvAgendaTurnos.ReadOnly = true;
            dgvAgendaTurnos.RowHeadersWidth = 51;
            dgvAgendaTurnos.Size = new Size(972, 314);
            dgvAgendaTurnos.TabIndex = 3;
            dgvAgendaTurnos.CellContentClick += dgvAgendaTurnos_CellContentClick;
            // 
            // lblEspeT
            // 
            lblEspeT.AutoSize = true;
            lblEspeT.Location = new Point(414, 47);
            lblEspeT.Name = "lblEspeT";
            lblEspeT.Size = new Size(93, 20);
            lblEspeT.TabIndex = 4;
            lblEspeT.Text = "Especialidad";
            // 
            // lblMedicoT
            // 
            lblMedicoT.AutoSize = true;
            lblMedicoT.Location = new Point(696, 48);
            lblMedicoT.Name = "lblMedicoT";
            lblMedicoT.Size = new Size(59, 20);
            lblMedicoT.TabIndex = 5;
            lblMedicoT.Text = "Médico";
            // 
            // lblFechaT
            // 
            lblFechaT.AutoSize = true;
            lblFechaT.Location = new Point(415, 140);
            lblFechaT.Name = "lblFechaT";
            lblFechaT.Size = new Size(47, 20);
            lblFechaT.TabIndex = 6;
            lblFechaT.Text = "Fecha";
            // 
            // cboEspeT
            // 
            cboEspeT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspeT.FormattingEnabled = true;
            cboEspeT.Location = new Point(415, 75);
            cboEspeT.Name = "cboEspeT";
            cboEspeT.Size = new Size(248, 28);
            cboEspeT.TabIndex = 7;
            cboEspeT.SelectedValueChanged += cboEspeT_SelectedValueChanged;
            // 
            // cboMedicoT
            // 
            cboMedicoT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedicoT.FormattingEnabled = true;
            cboMedicoT.Location = new Point(697, 75);
            cboMedicoT.Name = "cboMedicoT";
            cboMedicoT.Size = new Size(248, 28);
            cboMedicoT.TabIndex = 8;
            // 
            // dtpFechaT
            // 
            dtpFechaT.Format = DateTimePickerFormat.Custom;
            dtpFechaT.Location = new Point(415, 169);
            dtpFechaT.Name = "dtpFechaT";
            dtpFechaT.Size = new Size(250, 27);
            dtpFechaT.TabIndex = 9;
            // 
            // btnBuscarT
            // 
            btnBuscarT.BackColor = Color.FromArgb(33, 32, 43);
            btnBuscarT.FlatAppearance.BorderSize = 0;
            btnBuscarT.FlatStyle = FlatStyle.Flat;
            btnBuscarT.ForeColor = Color.White;
            btnBuscarT.Image = (Image)resources.GetObject("btnBuscarT.Image");
            btnBuscarT.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarT.Location = new Point(971, 120);
            btnBuscarT.Name = "btnBuscarT";
            btnBuscarT.Size = new Size(173, 37);
            btnBuscarT.TabIndex = 10;
            btnBuscarT.Text = "BUSCAR";
            btnBuscarT.UseVisualStyleBackColor = false;
            btnBuscarT.Click += btnBuscarT_Click;
            // 
            // lblMensajeT
            // 
            lblMensajeT.AutoSize = true;
            lblMensajeT.BackColor = Color.White;
            lblMensajeT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeT.Location = new Point(514, 391);
            lblMensajeT.Name = "lblMensajeT";
            lblMensajeT.Size = new Size(481, 23);
            lblMensajeT.TabIndex = 11;
            lblMensajeT.Text = "No se encontraron turnos disponibles para la fecha indicada...";
            // 
            // btnVolverAPacientes
            // 
            btnVolverAPacientes.FlatAppearance.BorderSize = 0;
            btnVolverAPacientes.FlatStyle = FlatStyle.Flat;
            btnVolverAPacientes.Image = (Image)resources.GetObject("btnVolverAPacientes.Image");
            btnVolverAPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolverAPacientes.Location = new Point(256, 5);
            btnVolverAPacientes.Name = "btnVolverAPacientes";
            btnVolverAPacientes.Size = new Size(159, 41);
            btnVolverAPacientes.TabIndex = 12;
            btnVolverAPacientes.Text = "PACIENTES";
            btnVolverAPacientes.UseVisualStyleBackColor = true;
            btnVolverAPacientes.Click += btnVolverAPacientes_Click;
            // 
            // frmTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 600);
            Controls.Add(btnVolverAPacientes);
            Controls.Add(lblMensajeT);
            Controls.Add(btnBuscarT);
            Controls.Add(dtpFechaT);
            Controls.Add(cboMedicoT);
            Controls.Add(cboEspeT);
            Controls.Add(lblFechaT);
            Controls.Add(lblMedicoT);
            Controls.Add(lblEspeT);
            Controls.Add(dgvAgendaTurnos);
            Controls.Add(pnlSideT);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 647);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 647);
            Name = "frmTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TURNOS";
            Load += frmTurno_Load;
            pnlSideT.ResumeLayout(false);
            pnlSideT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendaTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideT;
        private Button btnMenuT;
        private Button btnTurnoT;
        private Label lblSePriceT;
        private Label lblClinicaT;
        private PictureBox picLogoT;
        private DataGridView dgvAgendaTurnos;
        private Label lblEspeT;
        private Label lblMedicoT;
        private Label lblFechaT;
        private ComboBox cboEspeT;
        private ComboBox cboMedicoT;
        private DateTimePicker dtpFechaT;
        private Button btnBuscarT;
        private Label lblMensajeT;
        private Button btnVolverAPacientes;
    }
}