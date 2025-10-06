using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmAgregarHabitacion : Form
    {
        private frmReservas formularioPadre;
        private int id_Reserva;
        private DateTime fecha_Inicio;
        private DateTime fecha_Final;

        public frmAgregarHabitacion(int idReserva, frmReservas padre, DateTime fechaInicio, DateTime fechaFinal)
        {
            InitializeComponent();
            id_Reserva = idReserva;
            fecha_Inicio = fechaInicio;
            fecha_Final = fechaFinal;
            formularioPadre = padre;

            MostrarHabitacionesDisponibles();
            MostrarHabitacionesSeleccionadas();
        }

        private void frmAgregarHabitacion_Load(object sender, EventArgs e)
        {

        }
        private void MostrarHabitacionesDisponibles()
        {
            dgvHabitacionesDisponibles.DataSource = null;
            dgvHabitacionesDisponibles.DataSource = Habitacion.CargarHabitacionesDisponibles(fecha_Inicio, fecha_Final);
        }

        private void MostrarHabitacionesSeleccionadas()
        {
            dgvSeleccionadas.DataSource = null;
            dgvSeleccionadas.DataSource = Habitacion.CargarHabitacionesSeleccionadas(id_Reserva);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formularioPadre.MostrarPanelesPrincipales();
            this.Close();
        }

        private void dgvHabitacionesDisponibles_DoubleClick(object sender, EventArgs e)
        {

            if (dgvHabitacionesDisponibles.CurrentRow != null)
            {
                txtHabitacion.Text = dgvHabitacionesDisponibles.CurrentRow.Cells[1].Value.ToString();
                txtIdHabitacion.Text = dgvHabitacionesDisponibles.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHabitacion.Text))
            {
                HabitacionReserva hr = new HabitacionReserva();
                hr.Id_Reserva = id_Reserva;
                hr.Id_Habitacion = int.Parse(txtIdHabitacion.Text);

                try
                {
                    if (hr.InsertarHabitacionReserva())
                    {

                        Habitacion ha = new Habitacion();
                        ha.Id_EstadoHabitacion = 3;
                        ha.IdHabitacion = int.Parse(txtIdHabitacion.Text);
                        ha.ActualizarEstadoHabitacion();

                        txtHabitacion.Clear();
                        txtIdHabitacion.Clear();

                        MostrarHabitacionesSeleccionadas();
                        MostrarHabitacionesDisponibles();
                        MessageBox.Show("Exelente. Los datos fueron registrados", "Reservación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error al ingresar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeleccionadas.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un registro de la tabla de habitaciones seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                HabitacionReserva hr = new HabitacionReserva();
                int idHabitacionReserva = int.Parse(dgvSeleccionadas.CurrentRow.Cells[0].Value.ToString());

                string registroEliminar = dgvSeleccionadas.CurrentRow.Cells[2].Value?.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar esta habitacion de la reserva:\n" + registroEliminar + " ?",
                                                         "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        if (hr.EliminarHabitacionReserva(idHabitacionReserva))
                        {
                            MessageBox.Show("Reserva de " + registroEliminar + ", eliminada\n", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarHabitacionesSeleccionadas();
                            MostrarHabitacionesDisponibles();
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar la habitación: " + ex, "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar la habitación: " + ex.Message, "Error");
                return;
            }
        }
    }
}
