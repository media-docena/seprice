namespace clinicaSePrice
{
    partial class frmHistoriaClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoriaClinica));
            pnlSide = new Panel();
            btnMenuHC = new Button();
            btnDeHC = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            btnNuevaHC = new Button();
            picSearchHC = new PictureBox();
            btnRegistrarHC = new Button();
            grpNuevaHC = new GroupBox();
            txtAntecPac = new TextBox();
            lblAntecPac = new Label();
            txtDNIPac = new TextBox();
            lblDNIPac = new Label();
            txtMedicPac = new TextBox();
            lblMedicamentosP = new Label();
            txtEnfPac = new TextBox();
            lblEnfPac = new Label();
            txtAlergiaPac = new TextBox();
            lblAlergiasP = new Label();
            pnlBuscarHC = new Panel();
            txtBuscarHC = new TextBox();
            dgvHC = new DataGridView();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearchHC).BeginInit();
            grpNuevaHC.SuspendLayout();
            pnlBuscarHC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHC).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnMenuHC);
            pnlSide.Controls.Add(btnDeHC);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(250, 603);
            pnlSide.TabIndex = 1;
            // 
            // btnMenuHC
            // 
            btnMenuHC.FlatAppearance.BorderSize = 0;
            btnMenuHC.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnMenuHC.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnMenuHC.FlatStyle = FlatStyle.Flat;
            btnMenuHC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuHC.ForeColor = Color.White;
            btnMenuHC.Image = (Image)resources.GetObject("btnMenuHC.Image");
            btnMenuHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuHC.Location = new Point(0, 540);
            btnMenuHC.Name = "btnMenuHC";
            btnMenuHC.Size = new Size(250, 42);
            btnMenuHC.TabIndex = 7;
            btnMenuHC.Text = "Menú";
            btnMenuHC.UseVisualStyleBackColor = true;
            btnMenuHC.Click += btnMenuHC_Click;
            // 
            // btnDeHC
            // 
            btnDeHC.BackColor = Color.FromArgb(33, 32, 43);
            btnDeHC.FlatAppearance.BorderSize = 0;
            btnDeHC.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnDeHC.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnDeHC.FlatStyle = FlatStyle.Flat;
            btnDeHC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeHC.ForeColor = Color.White;
            btnDeHC.Image = (Image)resources.GetObject("btnDeHC.Image");
            btnDeHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeHC.Location = new Point(0, 350);
            btnDeHC.Name = "btnDeHC";
            btnDeHC.Size = new Size(250, 42);
            btnDeHC.TabIndex = 6;
            btnDeHC.Text = "Historia Clínica";
            btnDeHC.UseVisualStyleBackColor = false;
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
            // btnNuevaHC
            // 
            btnNuevaHC.BackColor = Color.FromArgb(33, 32, 43);
            btnNuevaHC.FlatAppearance.BorderSize = 0;
            btnNuevaHC.FlatStyle = FlatStyle.Flat;
            btnNuevaHC.ForeColor = Color.White;
            btnNuevaHC.Image = (Image)resources.GetObject("btnNuevaHC.Image");
            btnNuevaHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaHC.Location = new Point(661, 271);
            btnNuevaHC.Name = "btnNuevaHC";
            btnNuevaHC.Size = new Size(173, 37);
            btnNuevaHC.TabIndex = 13;
            btnNuevaHC.Text = "NUEVO";
            btnNuevaHC.UseVisualStyleBackColor = false;
            btnNuevaHC.Click += btnNuevaHC_Click;
            // 
            // picSearchHC
            // 
            picSearchHC.BackColor = Color.FromArgb(33, 32, 43);
            picSearchHC.Image = (Image)resources.GetObject("picSearchHC.Image");
            picSearchHC.Location = new Point(1183, 271);
            picSearchHC.Name = "picSearchHC";
            picSearchHC.Size = new Size(62, 39);
            picSearchHC.SizeMode = PictureBoxSizeMode.CenterImage;
            picSearchHC.TabIndex = 12;
            picSearchHC.TabStop = false;
            // 
            // btnRegistrarHC
            // 
            btnRegistrarHC.BackColor = Color.FromArgb(33, 32, 43);
            btnRegistrarHC.FlatAppearance.BorderSize = 0;
            btnRegistrarHC.FlatStyle = FlatStyle.Flat;
            btnRegistrarHC.ForeColor = Color.White;
            btnRegistrarHC.Image = (Image)resources.GetObject("btnRegistrarHC.Image");
            btnRegistrarHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarHC.Location = new Point(288, 271);
            btnRegistrarHC.Name = "btnRegistrarHC";
            btnRegistrarHC.Size = new Size(173, 37);
            btnRegistrarHC.TabIndex = 11;
            btnRegistrarHC.Text = "REGISTRAR";
            btnRegistrarHC.UseVisualStyleBackColor = false;
            btnRegistrarHC.Click += btnRegistrarHC_Click;
            // 
            // grpNuevaHC
            // 
            grpNuevaHC.BackColor = SystemColors.Window;
            grpNuevaHC.Controls.Add(txtAntecPac);
            grpNuevaHC.Controls.Add(lblAntecPac);
            grpNuevaHC.Controls.Add(txtDNIPac);
            grpNuevaHC.Controls.Add(lblDNIPac);
            grpNuevaHC.Controls.Add(txtMedicPac);
            grpNuevaHC.Controls.Add(lblMedicamentosP);
            grpNuevaHC.Controls.Add(txtEnfPac);
            grpNuevaHC.Controls.Add(lblEnfPac);
            grpNuevaHC.Controls.Add(txtAlergiaPac);
            grpNuevaHC.Controls.Add(lblAlergiasP);
            grpNuevaHC.Location = new Point(286, 17);
            grpNuevaHC.Name = "grpNuevaHC";
            grpNuevaHC.Size = new Size(963, 228);
            grpNuevaHC.TabIndex = 10;
            grpNuevaHC.TabStop = false;
            grpNuevaHC.Text = "NUEVA HISTORIA CLÍNICA";
            // 
            // txtAntecPac
            // 
            txtAntecPac.Location = new Point(15, 123);
            txtAntecPac.MaximumSize = new Size(212, 80);
            txtAntecPac.MaxLength = 150;
            txtAntecPac.MinimumSize = new Size(212, 80);
            txtAntecPac.Multiline = true;
            txtAntecPac.Name = "txtAntecPac";
            txtAntecPac.Size = new Size(212, 80);
            txtAntecPac.TabIndex = 11;
            // 
            // lblAntecPac
            // 
            lblAntecPac.AutoSize = true;
            lblAntecPac.Location = new Point(15, 98);
            lblAntecPac.Name = "lblAntecPac";
            lblAntecPac.Size = new Size(169, 20);
            lblAntecPac.TabIndex = 10;
            lblAntecPac.Text = "Antecedentes Familiares";
            // 
            // txtDNIPac
            // 
            txtDNIPac.Location = new Point(15, 59);
            txtDNIPac.MaxLength = 10;
            txtDNIPac.Name = "txtDNIPac";
            txtDNIPac.Size = new Size(212, 27);
            txtDNIPac.TabIndex = 5;
            // 
            // lblDNIPac
            // 
            lblDNIPac.AutoSize = true;
            lblDNIPac.Location = new Point(15, 34);
            lblDNIPac.Name = "lblDNIPac";
            lblDNIPac.Size = new Size(119, 20);
            lblDNIPac.TabIndex = 4;
            lblDNIPac.Text = "DNI del Paciente";
            // 
            // txtMedicPac
            // 
            txtMedicPac.Location = new Point(498, 59);
            txtMedicPac.MaximumSize = new Size(212, 90);
            txtMedicPac.MaxLength = 150;
            txtMedicPac.MinimumSize = new Size(212, 90);
            txtMedicPac.Multiline = true;
            txtMedicPac.Name = "txtMedicPac";
            txtMedicPac.Size = new Size(212, 90);
            txtMedicPac.TabIndex = 9;
            // 
            // lblMedicamentosP
            // 
            lblMedicamentosP.AutoSize = true;
            lblMedicamentosP.Location = new Point(498, 33);
            lblMedicamentosP.Name = "lblMedicamentosP";
            lblMedicamentosP.Size = new Size(207, 20);
            lblMedicamentosP.TabIndex = 8;
            lblMedicamentosP.Text = "Medicamentos Administrados";
            // 
            // txtEnfPac
            // 
            txtEnfPac.Location = new Point(734, 59);
            txtEnfPac.MaximumSize = new Size(212, 90);
            txtEnfPac.MaxLength = 150;
            txtEnfPac.MinimumSize = new Size(212, 90);
            txtEnfPac.Multiline = true;
            txtEnfPac.Name = "txtEnfPac";
            txtEnfPac.Size = new Size(212, 90);
            txtEnfPac.TabIndex = 7;
            // 
            // lblEnfPac
            // 
            lblEnfPac.AutoSize = true;
            lblEnfPac.Location = new Point(734, 34);
            lblEnfPac.Name = "lblEnfPac";
            lblEnfPac.Size = new Size(194, 20);
            lblEnfPac.TabIndex = 6;
            lblEnfPac.Text = "Enfermedades Preexistentes";
            // 
            // txtAlergiaPac
            // 
            txtAlergiaPac.BackColor = SystemColors.Window;
            txtAlergiaPac.Location = new Point(256, 59);
            txtAlergiaPac.MaximumSize = new Size(212, 90);
            txtAlergiaPac.MaxLength = 150;
            txtAlergiaPac.MinimumSize = new Size(212, 90);
            txtAlergiaPac.Multiline = true;
            txtAlergiaPac.Name = "txtAlergiaPac";
            txtAlergiaPac.Size = new Size(212, 90);
            txtAlergiaPac.TabIndex = 3;
            // 
            // lblAlergiasP
            // 
            lblAlergiasP.AutoSize = true;
            lblAlergiasP.Location = new Point(256, 34);
            lblAlergiasP.Name = "lblAlergiasP";
            lblAlergiasP.Size = new Size(63, 20);
            lblAlergiasP.TabIndex = 2;
            lblAlergiasP.Text = "Alergias";
            // 
            // pnlBuscarHC
            // 
            pnlBuscarHC.BackColor = Color.White;
            pnlBuscarHC.Controls.Add(txtBuscarHC);
            pnlBuscarHC.Location = new Point(857, 271);
            pnlBuscarHC.Name = "pnlBuscarHC";
            pnlBuscarHC.Size = new Size(326, 39);
            pnlBuscarHC.TabIndex = 9;
            // 
            // txtBuscarHC
            // 
            txtBuscarHC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarHC.Location = new Point(3, 3);
            txtBuscarHC.Name = "txtBuscarHC";
            txtBuscarHC.Size = new Size(320, 32);
            txtBuscarHC.TabIndex = 0;
            txtBuscarHC.TextChanged += txtBuscarHC_TextChanged;
            // 
            // dgvHC
            // 
            dgvHC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHC.Location = new Point(288, 320);
            dgvHC.Name = "dgvHC";
            dgvHC.RowHeadersWidth = 51;
            dgvHC.Size = new Size(957, 263);
            dgvHC.TabIndex = 8;
            dgvHC.CellContentClick += dgvHC_CellContentClick;
            // 
            // frmHistoriaClinica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(btnNuevaHC);
            Controls.Add(picSearchHC);
            Controls.Add(btnRegistrarHC);
            Controls.Add(grpNuevaHC);
            Controls.Add(pnlBuscarHC);
            Controls.Add(dgvHC);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 650);
            Name = "frmHistoriaClinica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORIA CLÍNICA";
            Load += frmHistoriaClinica_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearchHC).EndInit();
            grpNuevaHC.ResumeLayout(false);
            grpNuevaHC.PerformLayout();
            pnlBuscarHC.ResumeLayout(false);
            pnlBuscarHC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Button btnMenuHC;
        private Button btnDeHC;
        private Label lblSePrice;
        private Label lblClinica;
        private PictureBox picLogo;
        private Button btnNuevaHC;
        private PictureBox picSearchHC;
        private Button btnRegistrarHC;
        private GroupBox grpNuevaHC;
        private TextBox txtDNIPac;
        private Label lblDNIPac;
        private TextBox txtMedicPac;
        private Label lblMedicamentosP;
        private TextBox txtEnfPac;
        private Label lblEnfPac;
        private TextBox txtAlergiaPac;
        private Label lblAlergiasP;
        private Panel pnlBuscarHC;
        private TextBox txtBuscarHC;
        private DataGridView dgvHC;
        private TextBox txtAntecPac;
        private Label lblAntecPac;
    }
}