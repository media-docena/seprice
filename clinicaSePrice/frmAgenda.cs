﻿using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmAgenda : Form
    {
        private readonly string? _rol = Sesion.Rol;

        private int IdMedicoForm = 0;
        private DateTime FechaForm;
        private int IdTurnoForm = 0;
        private int IdPacienteForm = 0;
        private float HonorarioForm = 0;
        private string FormaPagoForm = "";
        private string EstadoTurnoForm = "";

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CargarListaMedicos();
            OcultarAccesos();
        }

        private void OcultarAccesos()
        {
            if (_rol == "Administrador")
            {
                btnConfirmarTurno.Visible = true;
                btnCancelarTurno.Visible = true;
                btnRegistrarPago.Visible = true;
            }
            else
            {
                btnConfirmarTurno.Visible = false;
                btnCancelarTurno.Visible = false;
                btnRegistrarPago.Visible = false;
            }
        }

        private void CargarListaMedicos()
        {
            try
            {
                Medico medicoCon = new Medico();
                List<E_Medico> listaMedicos = new List<E_Medico>();
                listaMedicos = medicoCon.ListarMedicosConTurno();
                cboMedico.DataSource = listaMedicos;
                cboMedico.ValueMember = "Id";
                cboMedico.DisplayMember = $"NombreCompleto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarAgendaDiaria(int id, DateTime fecha)
        {
            Medico medicoCon = new Medico();

            var agenda = medicoCon.ObtenerAgendaDiaria(id, fecha);

            if (agenda.Count > 0)
            {
                dtgvAgendaDiaria.Rows.Clear();
                foreach (var item in agenda)
                {
                    dtgvAgendaDiaria.Rows.Add(item.idTurno, item.inicioTurno, item.idPaciente, item.nombre, item.apellido, item.dni);
                }
            }
            else { MessageBox.Show("No hay turnos para mostrar", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnBuscarAgenda_Click(object sender, EventArgs e)
        {
            if (cboMedico.SelectedValue != null)
            {
                IdMedicoForm = (int)cboMedico.SelectedValue;
                FechaForm = dtpFecAgenda.Value;
                CargarAgendaDiaria(IdMedicoForm, FechaForm);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un medico", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtgvAgendaDiaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell CheckBoxCell = (DataGridViewCheckBoxCell)dtgvAgendaDiaria.Rows[e.RowIndex].Cells[e.ColumnIndex];

                bool isChecked = (CheckBoxCell.Value == null) ? false : (bool)CheckBoxCell.Value;
                CheckBoxCell.Value = !isChecked;

                if (CheckBoxCell.Value != null && (bool)CheckBoxCell.Value)
                {
                    object idturnoForm = dtgvAgendaDiaria.Rows[e.RowIndex].Cells[0].Value;
                    object idPacienteForm = dtgvAgendaDiaria.Rows[e.RowIndex].Cells[2].Value;

                    IdTurnoForm = (idturnoForm != null) ? Convert.ToInt32(idturnoForm) : 0;
                    IdPacienteForm = (idPacienteForm != null) ? Convert.ToInt32(idPacienteForm) : 0;
                }
                else
                {
                    IdTurnoForm = 0;
                    IdPacienteForm = 0;
                }
            }
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            Medico medicoCon = new Medico();
            Boolean estado = true;
            try
            {
                medicoCon.ActualizarEstadoTurno(estado, IdTurnoForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            Medico medicoCon = new Medico();
            Boolean estado = false;
            try
            {
                medicoCon.ActualizarEstadoTurno(estado, IdTurnoForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            Medico medicoCon = new Medico();
            if (IdTurnoForm != 0)
            {
                bool varCobertura = medicoCon.VerificarCoberturaPaciente(IdPacienteForm);
                if (varCobertura == true)
                {
                    bool varPago = medicoCon.VerificarInexistenciaPago(IdTurnoForm);
                    if (varPago == true)
                    {
                        EstadoTurnoForm = medicoCon.VerificarEstadoTurno(IdTurnoForm);
                        if (EstadoTurnoForm == "confirmado")
                        {
                            tabControl1.SelectedTab = tabPagePago;
                            HonorarioForm = medicoCon.BuscarMontoHonorario(IdMedicoForm);
                            txtMonto.Text = HonorarioForm.ToString();
                        }
                        else { MessageBox.Show($"No se puede registrar un pago, ya que el turno esta: {EstadoTurnoForm}", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                }
            }
            else { MessageBox.Show("Por favor, presione un check de la lista para continuar", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAgenda;
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaPagoForm = cboFormaPago.SelectedItem.ToString();
        }

        private void btnConfirmarRegPag_Click(object sender, EventArgs e)
        {
            Medico medicoCon = new Medico();
            try
            {
                bool comprobacion = medicoCon.VerificarInexistenciaPago(IdTurnoForm);
                if (comprobacion == true)
                {
                    medicoCon.RegistrarPago(IdTurnoForm, IdPacienteForm, FormaPagoForm, HonorarioForm);
                    btnMenu.Enabled = false;
                    btnConfirmarRegPag.Visible = false;
                    btnVolver.Visible = false;
                    btnGenerarFactura.Visible = true;
                    MessageBox.Show("Por favor, genere la factura para continuar.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Close();
        }
        private void generarComprobante()
        {
            if (IdTurnoForm != 0)
            {
                try
                {
                    // Crear instancia de Medico para obtener datos del paciente

                    Medico medicoCon = new Medico();
                    var paciente = medicoCon.ObtenerPacientePorId(IdPacienteForm);

                    // Asignar valores a los controles de comprobante
                    labelDataFecha.Text = FechaForm.ToShortDateString();
                    labelDataNombre.Text = paciente.Nombre?.ToString() ?? "N/A";
                    labelDataApellido.Text = paciente.Apellido?.ToString() ?? "N/A";
                    labelMonto.Text = HonorarioForm.ToString("F2");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un turno para generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





     

        private void printDocumentComprobante_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Control controlSeleccion = tabPageComprobante;

            int ancho = controlSeleccion.Width;
            int alto = controlSeleccion.Height;
            Rectangle bounds = new Rectangle(0, 0, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            controlSeleccion.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            generarComprobante();
            tabControl1.SelectedTab = tabPageComprobante;
        }

        private void btnImprComprobante_Click_1(object sender, EventArgs e)
        {
            btnImprComprobante.Visible = false;
            // creamos los objetos para la impresion
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocumentComprobante_PrintPage);
            pd.Print();
            btnImprComprobante.Visible = true;

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu principal = new frmMenu();
            principal.Show();
            this.Close();
        }
    }

}

