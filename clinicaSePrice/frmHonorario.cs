using clinicaSePrice.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaSePrice
{
    public partial class frmHonorario : Form
    {
        public frmHonorario()
        {
            InitializeComponent();
        }

        private void frmHonorario_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarGrillaHonorarios()
        {
            Medico medicoCon = new Medico();
            var listaHonorarios = medicoCon.ObtenerDatosHonorarios();

            if (listaHonorarios.Count > 0)
            {
                dtgvHonorarios.Rows.Clear();
                foreach (var item in listaHonorarios)
                {
                    dtgvHonorarios.Rows.Add(item.Mes, item.Anio, item.IdMedico, item.Nombre, item.Apellido, item.Especialidad, item.CantConsultas, item.HonorarioTotal);
                }
            }
            else { MessageBox.Show("No hay datos para mostrar."); }
        }

        private void PrintPage(Object sender, PrintPageEventArgs e)
        {
            Medico medicoCon = new Medico();
            var listaHonorarios = medicoCon.ObtenerDatosHonorarios();

            Graphics graphics = e.Graphics;
            Font font = new Font("Segoe UI", 9);
            Brush brush = Brushes.Black;

            int ejeX = 50;
            int ejeY = 50;
            int rowHeight = 30;

            graphics.DrawString("Mes", font, brush, ejeX, ejeY);
            graphics.DrawString("Año", font, brush, ejeX + 75, ejeY);
            graphics.DrawString("ID Médico", font, brush, ejeX + 125, ejeY);
            graphics.DrawString("Nombre", font, brush, ejeX + 200, ejeY);
            graphics.DrawString("Apellido", font, brush, ejeX + 275, ejeY);
            graphics.DrawString("Especialidad", font, brush, ejeX + 350, ejeY);
            graphics.DrawString("Cant. Consultas", font, brush, ejeX + 475, ejeY);
            graphics.DrawString("Honorario Total", font, brush, ejeX + 575, ejeY);

            graphics.DrawLine(Pens.Black, ejeX, ejeY + rowHeight, ejeX + 675, ejeY + rowHeight);

            int yPosition = ejeY + rowHeight + 10;
            foreach (var registro in listaHonorarios)
            {
                graphics.DrawString(registro.Mes, font, brush, ejeX, yPosition);
                graphics.DrawString(registro.Anio.ToString(), font, brush, ejeX + 75, yPosition);
                graphics.DrawString(registro.IdMedico.ToString(), font, brush, ejeX + 125, yPosition);
                graphics.DrawString(registro.Nombre, font, brush, ejeX + 200, yPosition);
                graphics.DrawString(registro.Apellido, font, brush, ejeX + 275, yPosition);
                graphics.DrawString(registro.Especialidad, font, brush, ejeX + 350, yPosition);
                graphics.DrawString(registro.CantConsultas.ToString(), font, brush, ejeX + 475, yPosition);
                graphics.DrawString(registro.HonorarioTotal.ToString("C"), font, brush, ejeX + 575, yPosition);

                yPosition += rowHeight;
            }
            e.HasMorePages = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pdf = new PrintDocument();
            pdf.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog dialogo = new PrintDialog();

            dialogo.Document = pdf;

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pdf.Print();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarGrillaHonorarios();
        }
    }
}
