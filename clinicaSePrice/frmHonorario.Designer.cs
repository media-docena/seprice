namespace clinicaSePrice
{
    partial class frmHonorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHonorario));
            pnlSide = new Panel();
            btnHonorarios = new Button();
            btnMenu = new Button();
            lblSePrice = new Label();
            lblClinica = new Label();
            picLogo = new PictureBox();
            btnImprimir = new Button();
            panel1 = new Panel();
            dtgvHonorarios = new DataGridView();
            mes = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            idMedico = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            cantConsultas = new DataGridViewTextBoxColumn();
            honorarioTotal = new DataGridViewTextBoxColumn();
            btnCargar = new Button();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHonorarios).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(100, 97, 129);
            pnlSide.Controls.Add(btnHonorarios);
            pnlSide.Controls.Add(btnMenu);
            pnlSide.Controls.Add(lblSePrice);
            pnlSide.Controls.Add(lblClinica);
            pnlSide.Controls.Add(picLogo);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Margin = new Padding(3, 2, 3, 2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(219, 458);
            pnlSide.TabIndex = 2;
            // 
            // btnHonorarios
            // 
            btnHonorarios.BackColor = Color.FromArgb(33, 32, 43);
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
            btnHonorarios.TabIndex = 9;
            btnHonorarios.Text = "Honorarios";
            btnHonorarios.UseVisualStyleBackColor = false;
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
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(33, 32, 43);
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.ForeColor = Color.White;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(760, 405);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(151, 28);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvHonorarios);
            panel1.Location = new Point(288, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 344);
            panel1.TabIndex = 8;
            // 
            // dtgvHonorarios
            // 
            dtgvHonorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHonorarios.Columns.AddRange(new DataGridViewColumn[] { mes, anio, idMedico, nombre, apellido, especialidad, cantConsultas, honorarioTotal });
            dtgvHonorarios.Dock = DockStyle.Fill;
            dtgvHonorarios.Location = new Point(0, 0);
            dtgvHonorarios.Name = "dtgvHonorarios";
            dtgvHonorarios.Size = new Size(776, 344);
            dtgvHonorarios.TabIndex = 0;
            // 
            // mes
            // 
            mes.HeaderText = "Mes";
            mes.Name = "mes";
            mes.Width = 75;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.Name = "anio";
            anio.Width = 75;
            // 
            // idMedico
            // 
            idMedico.HeaderText = "ID Medico";
            idMedico.Name = "idMedico";
            idMedico.Width = 70;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre Medico";
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido Medico";
            apellido.Name = "apellido";
            apellido.Width = 125;
            // 
            // especialidad
            // 
            especialidad.HeaderText = "Especialidad";
            especialidad.Name = "especialidad";
            especialidad.Width = 123;
            // 
            // cantConsultas
            // 
            cantConsultas.HeaderText = "Cantidad Consultas";
            cantConsultas.Name = "cantConsultas";
            cantConsultas.Width = 70;
            // 
            // honorarioTotal
            // 
            honorarioTotal.HeaderText = "Honorario Total";
            honorarioTotal.Name = "honorarioTotal";
            honorarioTotal.Width = 70;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(33, 32, 43);
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.ForeColor = Color.White;
            btnCargar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargar.Location = new Point(434, 405);
            btnCargar.Margin = new Padding(3, 2, 3, 2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(151, 28);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // frmHonorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 458);
            Controls.Add(btnCargar);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Controls.Add(pnlSide);
            MaximumSize = new Size(1140, 497);
            MinimumSize = new Size(1140, 497);
            Name = "frmHonorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHonorario";
            Load += frmHonorario_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHonorarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Button btnMenu;
        private Label lblSePrice;
        private Label lblClinica;
        private PictureBox picLogo;
        private Button btnHonorarios;
        private Button btnImprimir;
        private Panel panel1;
        private DataGridView dtgvHonorarios;
        private DataGridViewTextBoxColumn mes;
        private DataGridViewTextBoxColumn anio;
        private DataGridViewTextBoxColumn idMedico;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn especialidad;
        private DataGridViewTextBoxColumn cantConsultas;
        private DataGridViewTextBoxColumn honorarioTotal;
        private Button btnCargar;
    }
}