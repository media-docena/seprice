using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
using clinicaSePrice.Utilidades;
using clinicaSePrice.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinicaSePrice
{
    public partial class frmTurno : Form
    {
        public required PacienteVM Paciente;
        public frmTurno()
        {
            InitializeComponent();
            cboEspeT.SelectedValueChanged += cboEspeT_SelectedValueChanged;
            
        }

        private void cargarListaEspecialidades()
        {
            var especialidadesData = new Especialidad();
            var listaEspecilidades = especialidadesData.listarEspecialidades();

            cboEspeT.ValueMember = "IdEspecialidad";
            cboEspeT.DisplayMember = "Nombre";
            cboEspeT.DataSource = listaEspecilidades;
        }

        private void cargarListaMedicos(int especialidad)
        {
            var medicoData = new Medico();
            var listaMedicos = medicoData.listarMedicos(especialidad);

            cboMedicoT.ValueMember = "Id";
            cboMedicoT.DisplayMember = "NombreCompleto";
            cboMedicoT.DataSource = listaMedicos;
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            cargarListaEspecialidades();
            cargarGrilla();
            // Seteamos el tipo de grilla que vamos a utilizar
            dgvAgendaTurnos.ImplementarConfiguracion("Agendar Turno");
            // Fijamos la fecha mínima de selección de turnos disponibles
            dtpFechaT.MinDate = DateTime.Today;
            lblMensajeT.Visible = false;
        }

        private void cboEspeT_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (cboEspeT.SelectedValue != null) {
                int especSeleccionada = (Int32)cboEspeT.SelectedValue;
                cargarListaMedicos(especSeleccionada);
            }
        }

        private void cargarGrilla()
        {
            int medicoSeleccionado = (int)(cboMedicoT.SelectedValue ?? 0);
            var fecha = DateOnly.FromDateTime(dtpFechaT.Value);
            var medicoData = new Medico();
            var listaTurnos = medicoData.listarTurnos(medicoSeleccionado, fecha);


            var turnosAgendaVM = listaTurnos.Select(item => new AgendaVM
            {
                Id = item.Id,
                MedicoAgenda = item.Medico,
                Fecha = item.Fecha,
                Inicio = item.Inicio,
                Fin = item.Fin,
                Disponible = item.Disponible,
                Medico = item.Medico?.NombreCompleto,
                Especialidad = item.Medico?.Especialidad?.Nombre,
                Hora = item.Inicio,

            }).ToList();

            dgvAgendaTurnos.DataSource = turnosAgendaVM;
            dgvAgendaTurnos.Columns["Id"].Visible = false;
            dgvAgendaTurnos.Columns["MedicoAgenda"].Visible = false;
            dgvAgendaTurnos.Columns["Disponible"].Visible = false;
            dgvAgendaTurnos.Columns["Inicio"].Visible = false;
            dgvAgendaTurnos.Columns["Fin"].Visible = false;

            /*----------------------------------------------------------
             * La siguiente línea muestra mensaje de turnos no disponibles 
             * según la base de datos devuelva registros o no.
             *----------------------------------------------------------*/
            if (listaTurnos.Count == 0) {
                lblMensajeT.Visible = true;
            }
            else {
                lblMensajeT.Visible = false;
            }

        }

        private void btnBuscarT_Click(object? sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnVolverAPacientes_Click(object sender, EventArgs e)
        {
            frmPaciente frmPaciente = new frmPaciente();
            frmPaciente.Show();
            this.Close();
        }

        private void btnMenuT_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void actualizarEstadoAgenda(int idAgenda) 
        {
            var turnosData = new Turno();
            var resultado = turnosData.actualizarAgenda(idAgenda);
            if (resultado != null && resultado.Equals("OK")) {
                MessageBox.Show("El turno se agendó de manera exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
           MessageBoxIcon.Information);
            }
        }

        private void dgvAgendaTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            /*--------------------------------------------------
              * Al hacer click en el botón agendar turno
              * obtenemos la columna seleccionada por su nombre
              * y luego la fila para luego agendar un nuevo turno
              *-----------------------------------------------------*/
            if (dgvAgendaTurnos.Columns[e.ColumnIndex].Name == "ColumnaAccion") {
                var filaTSeleccionada = (AgendaVM)dgvAgendaTurnos.CurrentRow.DataBoundItem;
                var turnoData = new Turno();
                // Antes de agendar el turno nos aseguramos que las props de médico y especilidad no
                // sean nulos. Si no lo son se pasa a agendar el turno
                if (filaTSeleccionada.MedicoAgenda != null &&
                    filaTSeleccionada.MedicoAgenda.Especialidad != null &&
                    filaTSeleccionada.MedicoAgenda.Especialidad.IdEspecialidad != 0) 
                {
                    int idMedico = filaTSeleccionada.MedicoAgenda.Id;
                    int idEspe = filaTSeleccionada.MedicoAgenda.Especialidad.IdEspecialidad;
                    string rta = turnoData.asignarTurno(Paciente.IdPaciente,idMedico, idEspe,
                    filaTSeleccionada.Fecha, filaTSeleccionada.Inicio, filaTSeleccionada.Fin);

                    // Chequeamos la respuesta del procedimiento almacenado
                    bool esnumero = int.TryParse(rta, out int codigo);
                    if (esnumero) {
                        if (codigo == 1) {
                            actualizarEstadoAgenda(filaTSeleccionada.Id);
                            cargarGrilla();
                        }
                        else {
                            MessageBox.Show("Hubo un problema con la reserva del turno", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else {
                    MessageBox.Show("Faltan datos del médico o especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
