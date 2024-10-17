namespace clinicaSePrice
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlLogin = new Panel();
            cboRol = new ComboBox();
            lblRol = new Label();
            txtClave = new TextBox();
            txtCorreoLog = new TextBox();
            lblClave = new Label();
            lblCorreoLog = new Label();
            btnIngresar = new Button();
            picLogoLogin = new PictureBox();
            lblClinicaLog = new Label();
            lblSePriceLog = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(cboRol);
            pnlLogin.Controls.Add(lblRol);
            pnlLogin.Controls.Add(txtClave);
            pnlLogin.Controls.Add(txtCorreoLog);
            pnlLogin.Controls.Add(lblClave);
            pnlLogin.Controls.Add(lblCorreoLog);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Location = new Point(390, 156);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(491, 412);
            pnlLogin.TabIndex = 0;
            // 
            // cboRol
            // 
            cboRol.Font = new Font("Segoe UI", 14F);
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Administrador", "Médico" });
            cboRol.Location = new Point(45, 254);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(408, 39);
            cboRol.TabIndex = 6;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(33, 32, 43);
            lblRol.Location = new Point(45, 220);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 20);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(45, 161);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(408, 38);
            txtClave.TabIndex = 4;
            // 
            // txtCorreoLog
            // 
            txtCorreoLog.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoLog.Location = new Point(45, 63);
            txtCorreoLog.Name = "txtCorreoLog";
            txtCorreoLog.Size = new Size(408, 38);
            txtCorreoLog.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.ForeColor = Color.FromArgb(33, 32, 43);
            lblClave.Location = new Point(45, 124);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(86, 20);
            lblClave.TabIndex = 2;
            lblClave.Text = "Contraseña";
            // 
            // lblCorreoLog
            // 
            lblCorreoLog.AutoSize = true;
            lblCorreoLog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreoLog.ForeColor = Color.FromArgb(33, 32, 43);
            lblCorreoLog.Location = new Point(45, 27);
            lblCorreoLog.Name = "lblCorreoLog";
            lblCorreoLog.Size = new Size(56, 20);
            lblCorreoLog.TabIndex = 1;
            lblCorreoLog.Text = "Correo";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(100, 97, 129);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(45, 332);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(408, 58);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // picLogoLogin
            // 
            picLogoLogin.Image = (Image)resources.GetObject("picLogoLogin.Image");
            picLogoLogin.Location = new Point(483, 26);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(157, 124);
            picLogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoLogin.TabIndex = 1;
            picLogoLogin.TabStop = false;
            // 
            // lblClinicaLog
            // 
            lblClinicaLog.AutoSize = true;
            lblClinicaLog.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicaLog.ForeColor = Color.FromArgb(33, 32, 43);
            lblClinicaLog.Location = new Point(646, 26);
            lblClinicaLog.Name = "lblClinicaLog";
            lblClinicaLog.Size = new Size(148, 46);
            lblClinicaLog.TabIndex = 2;
            lblClinicaLog.Text = "CLINICA";
            // 
            // lblSePriceLog
            // 
            lblSePriceLog.AutoSize = true;
            lblSePriceLog.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSePriceLog.ForeColor = Color.FromArgb(33, 32, 43);
            lblSePriceLog.Location = new Point(646, 66);
            lblSePriceLog.Name = "lblSePriceLog";
            lblSePriceLog.Size = new Size(133, 46);
            lblSePriceLog.TabIndex = 3;
            lblSePriceLog.Text = "SePrice";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 246, 255);
            ClientSize = new Size(1282, 603);
            Controls.Add(lblSePriceLog);
            Controls.Add(lblClinicaLog);
            Controls.Add(picLogoLogin);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 650);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox picLogoLogin;
        private Label lblClinicaLog;
        private Label lblSePriceLog;
        private Button btnIngresar;
        private Label lblCorreoLog;
        private Label lblClave;
        private TextBox txtCorreoLog;
        private TextBox txtClave;
        private Label lblRol;
        private ComboBox cboRol;
    }
}
