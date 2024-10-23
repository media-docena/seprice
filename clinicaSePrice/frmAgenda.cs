using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaSePrice
{
    public partial class frmAgenda : Form
    {
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
    }
}
