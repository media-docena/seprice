namespace clinicaSePrice
{
    partial class frmHistClinicaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistClinicaDetalle));
            pnlSide = new Panel();
            btnMenuHCD = new Button();
            btnDeHC = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            grpDatosP = new GroupBox();
            lblDatoEdad = new Label();
            lblDEdad = new Label();
            lblDatoSexo = new Label();
            lblDSexo = new Label();
            lblDatoFeNac = new Label();
            lblFNac = new Label();
            lblDatoDNI = new Label();
            lblDDNI = new Label();
            lblDatoNom = new Label();
            lblDatoNombre = new Label();
            pictureBox1 = new PictureBox();
            grpNuevaConsulta = new GroupBox();
            btnRegistrarCM = new Button();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            txtIndicaciones = new TextBox();
            lblIndi = new Label();
            dgvConsultaHC = new DataGridView();
            btnVolverBuscarHC = new Button();
            grpHistorialP = new GroupBox();
            txtAntecedentesF = new TextBox();
            lblDAntecPac = new Label();
            txtEnfDatos = new TextBox();
            lblDEnfPac = new Label();
            txtMedicDPac = new TextBox();
            lblDMedicamentosP = new Label();
            txtAlergiaDPac = new TextBox();
            lblDAlergiasP = new Label();
            lblMensajeCM = new Label();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpDatosP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpNuevaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaHC).BeginInit();
            grpHistorialP.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnMenuHCD);
            pnlSide.Controls.Add(btnDeHC);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(250, 603);
            pnlSide.TabIndex = 2;
            // 
            // btnMenuHCD
            // 
            btnMenuHCD.FlatAppearance.BorderSize = 0;
            btnMenuHCD.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnMenuHCD.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnMenuHCD.FlatStyle = FlatStyle.Flat;
            btnMenuHCD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuHCD.ForeColor = Color.White;
            btnMenuHCD.Image = (Image)resources.GetObject("btnMenuHCD.Image");
            btnMenuHCD.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuHCD.Location = new Point(0, 540);
            btnMenuHCD.Name = "btnMenuHCD";
            btnMenuHCD.Size = new Size(250, 42);
            btnMenuHCD.TabIndex = 7;
            btnMenuHCD.Text = "Menú";
            btnMenuHCD.UseVisualStyleBackColor = true;
            btnMenuHCD.Click += btnMenuHCD_Click;
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
            // grpDatosP
            // 
            grpDatosP.BackColor = Color.White;
            grpDatosP.Controls.Add(lblDatoEdad);
            grpDatosP.Controls.Add(lblDEdad);
            grpDatosP.Controls.Add(lblDatoSexo);
            grpDatosP.Controls.Add(lblDSexo);
            grpDatosP.Controls.Add(lblDatoFeNac);
            grpDatosP.Controls.Add(lblFNac);
            grpDatosP.Controls.Add(lblDatoDNI);
            grpDatosP.Controls.Add(lblDDNI);
            grpDatosP.Controls.Add(lblDatoNom);
            grpDatosP.Controls.Add(lblDatoNombre);
            grpDatosP.Controls.Add(pictureBox1);
            grpDatosP.Location = new Point(261, 7);
            grpDatosP.Name = "grpDatosP";
            grpDatosP.Size = new Size(526, 140);
            grpDatosP.TabIndex = 3;
            grpDatosP.TabStop = false;
            grpDatosP.Text = "DATOS DEL PACIENTE";
            // 
            // lblDatoEdad
            // 
            lblDatoEdad.AutoSize = true;
            lblDatoEdad.Location = new Point(435, 104);
            lblDatoEdad.Name = "lblDatoEdad";
            lblDatoEdad.Size = new Size(25, 20);
            lblDatoEdad.TabIndex = 10;
            lblDatoEdad.Text = "29";
            // 
            // lblDEdad
            // 
            lblDEdad.AutoSize = true;
            lblDEdad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDEdad.ForeColor = Color.Indigo;
            lblDEdad.Location = new Point(390, 104);
            lblDEdad.Name = "lblDEdad";
            lblDEdad.Size = new Size(47, 20);
            lblDEdad.TabIndex = 9;
            lblDEdad.Text = "Edad:";
            // 
            // lblDatoSexo
            // 
            lblDatoSexo.AutoSize = true;
            lblDatoSexo.Location = new Point(310, 67);
            lblDatoSexo.Name = "lblDatoSexo";
            lblDatoSexo.Size = new Size(76, 20);
            lblDatoSexo.TabIndex = 8;
            lblDatoSexo.Text = "Masculino";
            // 
            // lblDSexo
            // 
            lblDSexo.AutoSize = true;
            lblDSexo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDSexo.ForeColor = Color.Indigo;
            lblDSexo.Location = new Point(265, 67);
            lblDSexo.Name = "lblDSexo";
            lblDSexo.Size = new Size(46, 20);
            lblDSexo.TabIndex = 7;
            lblDSexo.Text = "Sexo:";
            // 
            // lblDatoFeNac
            // 
            lblDatoFeNac.AutoSize = true;
            lblDatoFeNac.Location = new Point(292, 104);
            lblDatoFeNac.Name = "lblDatoFeNac";
            lblDatoFeNac.Size = new Size(85, 20);
            lblDatoFeNac.TabIndex = 6;
            lblDatoFeNac.Text = "12/05/1995";
            // 
            // lblFNac
            // 
            lblFNac.AutoSize = true;
            lblFNac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFNac.ForeColor = Color.Indigo;
            lblFNac.Location = new Point(140, 104);
            lblFNac.Name = "lblFNac";
            lblFNac.Size = new Size(157, 20);
            lblFNac.TabIndex = 5;
            lblFNac.Text = "Fecha de Nacimiento:";
            // 
            // lblDatoDNI
            // 
            lblDatoDNI.AutoSize = true;
            lblDatoDNI.Location = new Point(175, 67);
            lblDatoDNI.Name = "lblDatoDNI";
            lblDatoDNI.Size = new Size(73, 20);
            lblDatoDNI.TabIndex = 4;
            lblDatoDNI.Text = "36987254";
            // 
            // lblDDNI
            // 
            lblDDNI.AutoSize = true;
            lblDDNI.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDDNI.ForeColor = Color.Indigo;
            lblDDNI.Location = new Point(140, 67);
            lblDDNI.Name = "lblDDNI";
            lblDDNI.Size = new Size(40, 20);
            lblDDNI.TabIndex = 3;
            lblDDNI.Text = "DNI:";
            // 
            // lblDatoNom
            // 
            lblDatoNom.AutoSize = true;
            lblDatoNom.Location = new Point(275, 31);
            lblDatoNom.Name = "lblDatoNom";
            lblDatoNom.Size = new Size(97, 20);
            lblDatoNom.TabIndex = 2;
            lblDatoNom.Text = "Pablo Gomez";
            // 
            // lblDatoNombre
            // 
            lblDatoNombre.AutoSize = true;
            lblDatoNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatoNombre.ForeColor = Color.Indigo;
            lblDatoNombre.Location = new Point(140, 31);
            lblDatoNombre.Name = "lblDatoNombre";
            lblDatoNombre.Size = new Size(140, 20);
            lblDatoNombre.TabIndex = 1;
            lblDatoNombre.Text = "Nombre Completo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpNuevaConsulta
            // 
            grpNuevaConsulta.BackColor = Color.White;
            grpNuevaConsulta.Controls.Add(btnRegistrarCM);
            grpNuevaConsulta.Controls.Add(txtDiagnostico);
            grpNuevaConsulta.Controls.Add(lblDiagnostico);
            grpNuevaConsulta.Controls.Add(txtIndicaciones);
            grpNuevaConsulta.Controls.Add(lblIndi);
            grpNuevaConsulta.Location = new Point(262, 154);
            grpNuevaConsulta.Name = "grpNuevaConsulta";
            grpNuevaConsulta.Size = new Size(526, 260);
            grpNuevaConsulta.TabIndex = 4;
            grpNuevaConsulta.TabStop = false;
            grpNuevaConsulta.Text = "NUEVA CONSULTA";
            // 
            // btnRegistrarCM
            // 
            btnRegistrarCM.BackColor = Color.FromArgb(33, 32, 43);
            btnRegistrarCM.FlatAppearance.BorderSize = 0;
            btnRegistrarCM.FlatStyle = FlatStyle.Flat;
            btnRegistrarCM.ForeColor = Color.White;
            btnRegistrarCM.Image = (Image)resources.GetObject("btnRegistrarCM.Image");
            btnRegistrarCM.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarCM.Location = new Point(137, 211);
            btnRegistrarCM.Name = "btnRegistrarCM";
            btnRegistrarCM.Size = new Size(234, 37);
            btnRegistrarCM.TabIndex = 18;
            btnRegistrarCM.Text = "REGISTRAR CONSULTA";
            btnRegistrarCM.UseVisualStyleBackColor = false;
            btnRegistrarCM.Click += btnRegistrarCM_Click;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(273, 55);
            txtDiagnostico.MaximumSize = new Size(212, 140);
            txtDiagnostico.MaxLength = 200;
            txtDiagnostico.MinimumSize = new Size(240, 140);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(240, 140);
            txtDiagnostico.TabIndex = 17;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.Indigo;
            lblDiagnostico.Location = new Point(273, 29);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(90, 20);
            lblDiagnostico.TabIndex = 16;
            lblDiagnostico.Text = "Diagnóstico";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.BackColor = SystemColors.Window;
            txtIndicaciones.Location = new Point(10, 55);
            txtIndicaciones.MaximumSize = new Size(212, 140);
            txtIndicaciones.MaxLength = 150;
            txtIndicaciones.MinimumSize = new Size(240, 140);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(240, 140);
            txtIndicaciones.TabIndex = 15;
            // 
            // lblIndi
            // 
            lblIndi.AutoSize = true;
            lblIndi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndi.ForeColor = Color.Indigo;
            lblIndi.Location = new Point(10, 30);
            lblIndi.Name = "lblIndi";
            lblIndi.Size = new Size(93, 20);
            lblIndi.TabIndex = 14;
            lblIndi.Text = "Indicaciones";
            // 
            // dgvConsultaHC
            // 
            dgvConsultaHC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaHC.Location = new Point(499, 420);
            dgvConsultaHC.Name = "dgvConsultaHC";
            dgvConsultaHC.RowHeadersWidth = 51;
            dgvConsultaHC.Size = new Size(762, 171);
            dgvConsultaHC.TabIndex = 5;
            // 
            // btnVolverBuscarHC
            // 
            btnVolverBuscarHC.FlatAppearance.BorderSize = 0;
            btnVolverBuscarHC.FlatStyle = FlatStyle.Flat;
            btnVolverBuscarHC.Image = (Image)resources.GetObject("btnVolverBuscarHC.Image");
            btnVolverBuscarHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolverBuscarHC.Location = new Point(256, 481);
            btnVolverBuscarHC.Name = "btnVolverBuscarHC";
            btnVolverBuscarHC.Size = new Size(237, 41);
            btnVolverBuscarHC.TabIndex = 13;
            btnVolverBuscarHC.Text = "BUSCAR HIST. CLÍNICA";
            btnVolverBuscarHC.UseVisualStyleBackColor = true;
            btnVolverBuscarHC.Click += btnVolverBuscarHC_Click;
            // 
            // grpHistorialP
            // 
            grpHistorialP.BackColor = Color.White;
            grpHistorialP.Controls.Add(txtAntecedentesF);
            grpHistorialP.Controls.Add(lblDAntecPac);
            grpHistorialP.Controls.Add(txtEnfDatos);
            grpHistorialP.Controls.Add(lblDEnfPac);
            grpHistorialP.Controls.Add(txtMedicDPac);
            grpHistorialP.Controls.Add(lblDMedicamentosP);
            grpHistorialP.Controls.Add(txtAlergiaDPac);
            grpHistorialP.Controls.Add(lblDAlergiasP);
            grpHistorialP.Location = new Point(797, 13);
            grpHistorialP.Name = "grpHistorialP";
            grpHistorialP.Size = new Size(473, 389);
            grpHistorialP.TabIndex = 14;
            grpHistorialP.TabStop = false;
            grpHistorialP.Text = "HISTORIAL PACIENTE";
            // 
            // txtAntecedentesF
            // 
            txtAntecedentesF.BackColor = Color.White;
            txtAntecedentesF.Location = new Point(248, 233);
            txtAntecedentesF.MaximumSize = new Size(212, 140);
            txtAntecedentesF.MaxLength = 150;
            txtAntecedentesF.MinimumSize = new Size(212, 140);
            txtAntecedentesF.Multiline = true;
            txtAntecedentesF.Name = "txtAntecedentesF";
            txtAntecedentesF.ReadOnly = true;
            txtAntecedentesF.Size = new Size(212, 140);
            txtAntecedentesF.TabIndex = 17;
            // 
            // lblDAntecPac
            // 
            lblDAntecPac.AutoSize = true;
            lblDAntecPac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDAntecPac.ForeColor = Color.Indigo;
            lblDAntecPac.Location = new Point(248, 208);
            lblDAntecPac.Name = "lblDAntecPac";
            lblDAntecPac.Size = new Size(173, 20);
            lblDAntecPac.TabIndex = 16;
            lblDAntecPac.Text = "Antecedentes Familiares";
            // 
            // txtEnfDatos
            // 
            txtEnfDatos.BackColor = Color.White;
            txtEnfDatos.Location = new Point(17, 233);
            txtEnfDatos.MaximumSize = new Size(212, 140);
            txtEnfDatos.MaxLength = 150;
            txtEnfDatos.MinimumSize = new Size(212, 140);
            txtEnfDatos.Multiline = true;
            txtEnfDatos.Name = "txtEnfDatos";
            txtEnfDatos.ReadOnly = true;
            txtEnfDatos.Size = new Size(212, 140);
            txtEnfDatos.TabIndex = 15;
            // 
            // lblDEnfPac
            // 
            lblDEnfPac.AutoSize = true;
            lblDEnfPac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDEnfPac.ForeColor = Color.Indigo;
            lblDEnfPac.Location = new Point(17, 208);
            lblDEnfPac.Name = "lblDEnfPac";
            lblDEnfPac.Size = new Size(200, 20);
            lblDEnfPac.TabIndex = 14;
            lblDEnfPac.Text = "Enfermedades Preexistentes";
            // 
            // txtMedicDPac
            // 
            txtMedicDPac.BackColor = Color.White;
            txtMedicDPac.Location = new Point(248, 57);
            txtMedicDPac.MaximumSize = new Size(212, 140);
            txtMedicDPac.MaxLength = 150;
            txtMedicDPac.MinimumSize = new Size(212, 140);
            txtMedicDPac.Multiline = true;
            txtMedicDPac.Name = "txtMedicDPac";
            txtMedicDPac.ReadOnly = true;
            txtMedicDPac.Size = new Size(212, 140);
            txtMedicDPac.TabIndex = 13;
            // 
            // lblDMedicamentosP
            // 
            lblDMedicamentosP.AutoSize = true;
            lblDMedicamentosP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDMedicamentosP.ForeColor = Color.Indigo;
            lblDMedicamentosP.Location = new Point(248, 31);
            lblDMedicamentosP.Name = "lblDMedicamentosP";
            lblDMedicamentosP.Size = new Size(211, 20);
            lblDMedicamentosP.TabIndex = 12;
            lblDMedicamentosP.Text = "Medicamentos Administrados";
            // 
            // txtAlergiaDPac
            // 
            txtAlergiaDPac.BackColor = SystemColors.Window;
            txtAlergiaDPac.Location = new Point(17, 57);
            txtAlergiaDPac.MaximumSize = new Size(212, 140);
            txtAlergiaDPac.MaxLength = 150;
            txtAlergiaDPac.MinimumSize = new Size(212, 140);
            txtAlergiaDPac.Multiline = true;
            txtAlergiaDPac.Name = "txtAlergiaDPac";
            txtAlergiaDPac.ReadOnly = true;
            txtAlergiaDPac.Size = new Size(212, 140);
            txtAlergiaDPac.TabIndex = 11;
            // 
            // lblDAlergiasP
            // 
            lblDAlergiasP.AutoSize = true;
            lblDAlergiasP.BackColor = Color.White;
            lblDAlergiasP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDAlergiasP.ForeColor = Color.Indigo;
            lblDAlergiasP.Location = new Point(17, 32);
            lblDAlergiasP.Name = "lblDAlergiasP";
            lblDAlergiasP.Size = new Size(64, 20);
            lblDAlergiasP.TabIndex = 10;
            lblDAlergiasP.Text = "Alergias";
            // 
            // lblMensajeCM
            // 
            lblMensajeCM.AutoSize = true;
            lblMensajeCM.BackColor = Color.White;
            lblMensajeCM.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeCM.Location = new Point(683, 512);
            lblMensajeCM.Name = "lblMensajeCM";
            lblMensajeCM.Size = new Size(402, 23);
            lblMensajeCM.TabIndex = 15;
            lblMensajeCM.Text = "No se encontraron registros de consultas médicas...";
            // 
            // frmHistClinicaDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(lblMensajeCM);
            Controls.Add(grpHistorialP);
            Controls.Add(btnVolverBuscarHC);
            Controls.Add(dgvConsultaHC);
            Controls.Add(grpNuevaConsulta);
            Controls.Add(grpDatosP);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 650);
            Name = "frmHistClinicaDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORIA CLINICA DETALLE";
            Load += frmHistClinicaDetalle_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpDatosP.ResumeLayout(false);
            grpDatosP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpNuevaConsulta.ResumeLayout(false);
            grpNuevaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaHC).EndInit();
            grpHistorialP.ResumeLayout(false);
            grpHistorialP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSide;
        private Button btnMenuHCD;
        private Button btnDeHC;
        private Label lblSePrice;
        private Label lblClinica;
        private PictureBox picLogo;
        private GroupBox grpDatosP;
        private PictureBox pictureBox1;
        private Label lblDatoNombre;
        private Label lblDatoNom;
        private Label lblDatoDNI;
        private Label lblDDNI;
        private Label lblDatoFeNac;
        private Label lblFNac;
        private Label lblDatoSexo;
        private Label lblDSexo;
        private Label lblDatoEdad;
        private Label lblDEdad;
        private GroupBox grpNuevaConsulta;
        private DataGridView dgvConsultaHC;
        private Button btnVolverBuscarHC;
        private GroupBox grpHistorialP;
        private TextBox txtMedicDPac;
        private Label lblDMedicamentosP;
        private TextBox txtAlergiaDPac;
        private Label lblDAlergiasP;
        private TextBox txtEnfDatos;
        private Label lblDEnfPac;
        private TextBox txtAntecedentesF;
        private Label lblDAntecPac;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private TextBox txtIndicaciones;
        private Label lblIndi;
        private Button btnRegistrarCM;
        private Label lblMensajeCM;
    }
}