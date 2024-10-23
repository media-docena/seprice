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
            pnlSide.Margin = new Padding(3, 2, 3, 2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(219, 458);
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
            btnSalir.Location = new Point(0, 405);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(219, 32);
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
            btnHC.Location = new Point(0, 262);
            btnHC.Margin = new Padding(3, 2, 3, 2);
            btnHC.Name = "btnHC";
            btnHC.Size = new Size(219, 32);
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
            btnHonorarios.Location = new Point(0, 222);
            btnHonorarios.Margin = new Padding(3, 2, 3, 2);
            btnHonorarios.Name = "btnHonorarios";
            btnHonorarios.Size = new Size(219, 32);
            btnHonorarios.TabIndex = 5;
            btnHonorarios.Text = "Honorarios";
            btnHonorarios.UseVisualStyleBackColor = true;
            btnHonorarios.Click += btnHonorarios_Click;
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
            btnAgenda.Location = new Point(-1, 184);
            btnAgenda.Margin = new Padding(3, 2, 3, 2);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(219, 32);
            btnAgenda.TabIndex = 4;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
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
            btnTurnos.Location = new Point(0, 145);
            btnTurnos.Margin = new Padding(3, 2, 3, 2);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(219, 32);
            btnTurnos.TabIndex = 3;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
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
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(lblRol);
            pnlTop.Controls.Add(lblNomUsu);
            pnlTop.Controls.Add(picRol);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(219, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(905, 38);
            pnlTop.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(33, 32, 43);
            lblRol.Location = new Point(717, 20);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(83, 15);
            lblRol.TabIndex = 2;
            lblRol.Text = "Administrador";
            // 
            // lblNomUsu
            // 
            lblNomUsu.AutoSize = true;
            lblNomUsu.Location = new Point(716, 4);
            lblNomUsu.Name = "lblNomUsu";
            lblNomUsu.Size = new Size(89, 15);
            lblNomUsu.TabIndex = 1;
            lblNomUsu.Text = "Lucrecia Duarte";
            // 
            // picRol
            // 
            picRol.Image = (Image)resources.GetObject("picRol.Image");
            picRol.Location = new Point(828, 0);
            picRol.Margin = new Padding(3, 2, 3, 2);
            picRol.Name = "picRol";
            picRol.Size = new Size(44, 38);
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
            pnlCenter.Location = new Point(219, 38);
            pnlCenter.Margin = new Padding(3, 2, 3, 2);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(905, 420);
            pnlCenter.TabIndex = 2;
            // 
            // picDoctora
            // 
            picDoctora.Image = (Image)resources.GetObject("picDoctora.Image");
            picDoctora.Location = new Point(220, 112);
            picDoctora.Margin = new Padding(3, 2, 3, 2);
            picDoctora.Name = "picDoctora";
            picDoctora.Size = new Size(464, 236);
            picDoctora.SizeMode = PictureBoxSizeMode.Zoom;
            picDoctora.TabIndex = 2;
            picDoctora.TabStop = false;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(326, 72);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(216, 30);
            lblPregunta.TabIndex = 1;
            lblPregunta.Text = "¿Qué desea realizar?";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(368, 44);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(139, 30);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡Bienvenido!";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 458);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1140, 497);
            MinimizeBox = false;
            MinimumSize = new Size(1140, 497);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU ";
            Load += frmMenu_Load;
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