using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmAgregarServicio : Form
    {
        private frmReservas formularioPadre;
        private int id_Reserva;
        public frmAgregarServicio(int idReserva, frmReservas padre)
        {
            InitializeComponent();
            id_Reserva = idReserva;
            formularioPadre = padre;

            MostrarHabitacionesSeleccionadas();
            MostrarServiciosDisponibles();
            MostrarServiciosSeleccionados();

            dtpFecha.MinDate = DateTime.Now;
            dtpFecha.MaxDate = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
        }

        private void frmAgregarServicio_Load(object sender, EventArgs e)
        {

        }

        private void MostrarHabitacionesSeleccionadas()
        {
            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = Habitacion.CargarHabitacionesSeleccionadas(id_Reserva);
        }

        private void MostrarServiciosDisponibles()
        {
            dgvServiciosDisponibles.DataSource = null;
            dgvServiciosDisponibles.DataSource = Servicios.CargarServicios();
        }

        private void MostrarServiciosSeleccionados()
        {
            dgvSeleccionadas.DataSource = null;
            dgvSeleccionadas.DataSource = ServicioReserva.CargarServiciosSeleccionados(id_Reserva);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formularioPadre.MostrarPanelesPrincipales();
            this.Close();
        }

        private void dgvHabitaciones_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null)
            {
                txtNombreHabitacion.Text = dgvHabitaciones.CurrentRow.Cells[2].Value.ToString();
                txtIdHabitacionReserva.Text = dgvHabitaciones.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void dgvServiciosDisponibles_DoubleClick(object sender, EventArgs e)
        {
            if (dgvServiciosDisponibles.CurrentRow != null)
            {
                txtServicio.Text = dgvServiciosDisponibles.CurrentRow.Cells[1].Value.ToString();
                txtIdServicio.Text = dgvServiciosDisponibles.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreHabitacion.Text) && !string.IsNullOrWhiteSpace(txtServicio.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {

                ServicioReserva sr = new ServicioReserva();
                sr.Id_HabitacionReserva = int.Parse(txtIdHabitacionReserva.Text);
                sr.Id_Servicio = int.Parse(txtIdServicio.Text);
                sr.PrecioServicio = double.Parse(txtPrecio.Text);
                sr.FechaServicio = dtpFecha.Value;

                try
                {
                    sr.InsertarServicioReserva();

                    MostrarServiciosDisponibles();
                    MostrarServiciosSeleccionados();
                    MessageBox.Show("Exelente. Los datos fueron registrados", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error al ingresar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para poder realizar una reservación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreHabitacion.Text) && !string.IsNullOrWhiteSpace(txtServicio.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                if (!txtPrecio.MaskFull)
                {
                    MessageBox.Show("El campo de precio debe estar completamente lleno según el formato (999999.99). Puedes poner '0' antes del valor que desees agregar si este es más pequeño.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ServicioReserva sr = new ServicioReserva();
                sr.Id_HabitacionReserva = int.Parse(txtIdHabitacionReserva.Text);
                sr.Id_Servicio = int.Parse(txtIdServicio.Text);
                sr.PrecioServicio = double.Parse(txtPrecio.Text);

                if (dgvSeleccionadas.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un servicio seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    sr.IdServicioReserva = int.Parse(dgvSeleccionadas.CurrentRow.Cells[0].Value.ToString());
                }

                string registroEditar = dgvSeleccionadas.CurrentRow.Cells[5].Value.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres editar la este servicio de la habitación?\n" + registroEditar,
                                                          "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (sr.ActualizarServicoReserva() == true)
                    {
                        MostrarServiciosDisponibles();
                        MostrarServiciosSeleccionados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar, hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se pudo editar: \n Asegurese de seleccionar una habitacion, un servicio y que el campo de precio no esté vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdHabitacionReserva.Clear();
            txtIdServicio.Clear();
            txtNombreHabitacion.Clear();
            txtServicio.Clear();
            txtPrecio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeleccionadas.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un servicio seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ServicioReserva sr = new ServicioReserva();
                int id = Convert.ToInt32(dgvSeleccionadas.CurrentRow.Cells[0].Value.ToString());

                string registroEliminar = dgvSeleccionadas.CurrentRow.Cells[2].Value?.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este servicio de la habitación:\n" + registroEliminar + " ?",
                                                         "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (sr.EliminarServicioReserva(id) == true)
                    {
                        MessageBox.Show("Servicio de " + registroEliminar + ", eliminada\n", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarServiciosDisponibles();
                        MostrarServiciosSeleccionados();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar el servicio: " + ex.Message, "Error");
                return;
            }
        }

        private void dgvSeleccionadas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSeleccionadas.CurrentRow != null)
            {
                txtServicio.Text = dgvSeleccionadas.CurrentRow.Cells[2].Value.ToString();
                txtIdServicio.Text = dgvSeleccionadas.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgvSeleccionadas.CurrentRow.Cells[3].Value.ToString();
                txtIdHabitacionReserva.Text = dgvSeleccionadas.CurrentRow.Cells[4].Value.ToString();
                txtNombreHabitacion.Text = dgvSeleccionadas.CurrentRow.Cells[5].Value.ToString(); 
            }
            else
            {
                return;
            }
        }
    }
}
