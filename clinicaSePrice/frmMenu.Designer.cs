namespace clinicaSePrice
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            pnlSide = new Panel();
            btnSalir = new Button();
            btnHC = new Button();
            btnHonorarios = new Button();
            btnAgenda = new Button();
            btnTurnos = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            pnlTop = new Panel();
            lblRol = new Label();
            lblNomUsu = new Label();
            picRol = new PictureBox();
            pnlCenter = new Panel();
            picDoctora = new PictureBox();
            lblPregunta = new Label();
            lblBienvenido = new Label();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRol).BeginInit();
            pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoctora).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnSalir);
            pnlSide.Controls.Add(btnHC);
            pnlSide.Controls.Add(btnHonorarios);
            pnlSide.Controls.Add(btnAgenda);
            pnlSide.Controls.Add(btnTurnos);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(250, 603);
            pnlSide.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 540);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 42);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHC
            // 
            btnHC.FlatAppearance.BorderSize = 0;
            btnHC.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnHC.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnHC.FlatStyle = FlatStyle.Flat;
            btnHC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHC.ForeColor = Color.White;
            btnHC.Image = (Image)resources.GetObject("btnHC.Image");
            btnHC.ImageAlign = ContentAlignment.MiddleLeft;
            btnHC.Location = new Point(0, 350);
            btnHC.Name = "btnHC";
            btnHC.Size = new Size(250, 42);
            btnHC.TabIndex = 6;
            btnHC.Text = "Historia Clínica";
            btnHC.UseVisualStyleBackColor = true;
            // 
            // btnHonorarios
            // 
            btnHonorarios.FlatAppearance.BorderSize = 0;
            btnHonorarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnHonorarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnHonorarios.FlatStyle = FlatStyle.Flat;
            btnHonorarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHonorarios.ForeColor = Color.White;
            btnHonorarios.Image = (Image)resources.GetObject("btnHonorarios.Image");
            btnHonorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHonorarios.Location = new Point(0, 296);
            btnHonorarios.Name = "btnHonorarios";
            btnHonorarios.Size = new Size(250, 42);
            btnHonorarios.TabIndex = 5;
            btnHonorarios.Text = "Honorarios";
            btnHonorarios.UseVisualStyleBackColor = true;
            // 
            // btnAgenda
            // 
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgenda.Location = new Point(-1, 246);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(250, 42);
            btnAgenda.TabIndex = 4;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderSize = 0;
            btnTurnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 32, 43);
            btnTurnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 32, 43);
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurnos.ForeColor = Color.White;
            btnTurnos.Image = (Image)resources.GetObject("btnTurnos.Image");
            btnTurnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnos.Location = new Point(0, 193);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(250, 42);
            btnTurnos.TabIndex = 3;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
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
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(lblRol);
            pnlTop.Controls.Add(lblNomUsu);
            pnlTop.Controls.Add(picRol);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(250, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1032, 50);
            pnlTop.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(33, 32, 43);
            lblRol.Location = new Point(837, 26);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(107, 20);
            lblRol.TabIndex = 2;
            lblRol.Text = "Administrador";
            // 
            // lblNomUsu
            // 
            lblNomUsu.AutoSize = true;
            lblNomUsu.Location = new Point(833, 6);
            lblNomUsu.Name = "lblNomUsu";
            lblNomUsu.Size = new Size(112, 20);
            lblNomUsu.TabIndex = 1;
            lblNomUsu.Text = "Lucrecia Duarte";
            // 
            // picRol
            // 
            picRol.Image = (Image)resources.GetObject("picRol.Image");
            picRol.Location = new Point(946, 0);
            picRol.Name = "picRol";
            picRol.Size = new Size(50, 50);
            picRol.SizeMode = PictureBoxSizeMode.Zoom;
            picRol.TabIndex = 0;
            picRol.TabStop = false;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(picDoctora);
            pnlCenter.Controls.Add(lblPregunta);
            pnlCenter.Controls.Add(lblBienvenido);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(250, 50);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(1032, 553);
            pnlCenter.TabIndex = 2;
            // 
            // picDoctora
            // 
            picDoctora.Image = (Image)resources.GetObject("picDoctora.Image");
            picDoctora.Location = new Point(251, 149);
            picDoctora.Name = "picDoctora";
            picDoctora.Size = new Size(530, 314);
            picDoctora.SizeMode = PictureBoxSizeMode.Zoom;
            picDoctora.TabIndex = 2;
            picDoctora.TabStop = false;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(372, 96);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(275, 38);
            lblPregunta.TabIndex = 1;
            lblPregunta.Text = "¿Qué desea realizar?";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(421, 58);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(176, 38);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡Bienvenido!";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 650);
            Name = "frmMenu";
            Text = "MENU ";
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRol).EndInit();
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDoctora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Panel pnlTop;
        private Panel pnlCenter;
        private PictureBox picLogo;
        private Label lblClinica;
        private Label lblSePrice;
        private PictureBox picRol;
        private Label lblNomUsu;
        private Label lblRol;
        private Button btnTurnos;
        private Button btnAgenda;
        private Button btnHonorarios;
        private Button btnHC;
        private Button btnSalir;
        private Label lblBienvenido;
        private Label lblPregunta;
        private PictureBox picDoctora;
    }
}