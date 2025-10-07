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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
            MostrarClientes();
            MostrarReservas();
            MostrarEstadoReserva();

            lblEstado.Visible = false;
            cbEstado.Visible = false;

            dtpFechaRegistro.MinDate = DateTime.Today;
            dtpFechaRegistro.MaxDate = DateTime.Today;
            dtpFechaRegistro.Value = DateTime.Today;

            dtpFechaInicio.MinDate = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today;

            dtpFechaFinal.MinDate = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {

        }

        #region "Metodo para pintar formularios"
        //Creamos un atributo
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            //Si existe un formulario abierto, se cerrará
            {
                activarForm.Close();
            }
            //Le damos todos los permisos que tiene la clase form
            activarForm = formularioPintar;
            //Convertimos a un hijo de tipo de form
            formularioPintar.TopLevel = false;
            //Quitamos los bordes
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }
        #endregion

        #region Metodo para mostrar las opciones disponibles del combo box
        private void MostrarEstadoReserva()
        {
            cbEstado.DataSource = null;
            cbEstado.DataSource = EstadoReserva.CargarEstadoReserva();
            cbEstado.DisplayMember = "nombreEstadoReserva";
            cbEstado.ValueMember = "idEstadoReserva";
            cbEstado.SelectedIndex = -1;
        }
        #endregion

        private void MostrarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.CargarClientes();
        }

        private void MostrarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = Reservacion.CargarReservas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                if (dtpFechaFinal.Value < dtpFechaInicio.Value)
                {
                    MessageBox.Show("Lo sentimos, la fecha final no puede ser antes de la fecha de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reservacion re = new Reservacion();
                re.FechaReserva = dtpFechaRegistro.Value;
                re.FechaInicio = dtpFechaInicio.Value;
                re.FechaFinal = dtpFechaFinal.Value;
                re.Id_Cliente = Convert.ToInt32(txtIdCliente.Text);
                re.Id_EstadoReserva = 1;

                try
                {
                    re.InsertarReservas();

                    MostrarReservas();
                    MessageBox.Show("Exelente. Los datos fueron registrados", "Reservación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Hubo un error al insgresar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para poder realizar una reservación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        #region "Metodos para cargar datos"
        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                txtCorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void dgvReservas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                if (dgvReservas.CurrentRow.Cells[10].Value.ToString() != "FINALIZADA")
                {
                    txtCorreo.Text = dgvReservas.CurrentRow.Cells[5].Value.ToString();
                    txtIdCliente.Text = dgvReservas.CurrentRow.Cells[2].Value.ToString();
                    dtpFechaInicio.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[6].Value);
                    dtpFechaFinal.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[7].Value);

                    lblEstado.Visible = true;
                    cbEstado.Visible = true;
                    cbEstado.Text = dgvReservas.CurrentRow.Cells[10].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Lo sentimos, no se pueden editar reservaciones finalizadas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                Reservacion re = new Reservacion();
                re.Id_Cliente = Convert.ToInt32(txtIdCliente.Text);
                re.FechaInicio = dtpFechaInicio.Value;
                re.FechaFinal = dtpFechaFinal.Value;
                re.Id_EstadoReserva = Convert.ToInt32(cbEstado.SelectedValue);

                if (dgvReservas.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un registro de reservación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    re.IdReserva = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
                }

                string registroEditar = dgvReservas.CurrentRow.Cells[5].Value.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres editar la reservación de este cliente?\n" + registroEditar,
                                                          "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (re.ActualizarReserva() == true)
                    {
                        MostrarReservas();
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
                MessageBox.Show("No se pudo editar: \n Asegurese de seleccionar una reserva y que el campo de Cliente no esté vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtCorreo.Clear();
            dtpFechaFinal.Value = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today;

            lblEstado.Visible = false;
            cbEstado.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un registro de reserva", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Reservacion re = new Reservacion();
                int id = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());

                string registroEliminar = dgvReservas.CurrentRow.Cells[5].Value?.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar la reserva de este cliente\n" + registroEliminar + " ?",
                                                         "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (re.EliminarReserva(id) == true)
                    {
                        MessageBox.Show("Reserva de " + registroEliminar + ", eliminada\n", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarReservas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar la reserva: " + ex.Message, "Error");
                return;
            }
        }

        private void txtBuscarCliente_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            txtBuscarCliente.ForeColor = Color.Black;
        }

        private void txtBuscarReserva_Click(object sender, EventArgs e)
        {
            txtBuscarReserva.Clear();
            txtBuscarReserva.ForeColor = Color.Black;
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarReserva.Text))
            {
               
                try
                {
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = Reservacion.BuscarReserva(txtBuscarReserva.Text);
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar un correo en el campo de búsqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void MostrarPanelesPrincipales()
        {
            pnlTitulo.Visible = true;
            pnlCliente.Visible = true;
            pnlFormulario.Visible = true;
            pnlReserva.Visible = true;
            AutoScroll = true;
        }

        private void btnAgregarHabitaciones_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                if (dgvReservas.CurrentRow.Cells[10].Value.ToString() != "FINALIZADA" && dgvReservas.CurrentRow.Cells[10].Value.ToString() != "CANCELADA")
                {
                    int idReserva = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
                    DateTime fechaIncio = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[6].Value);
                    DateTime fechaFinal = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[7].Value);

                    pnlTitulo.Visible = false;
                    pnlCliente.Visible = false;
                    pnlFormulario.Visible = false;
                    pnlReserva.Visible = false;
                    this.AutoScroll = false;
                    
                    abrirForm(new frmAgregarHabitacion(idReserva, this, fechaIncio, fechaFinal));

                    MessageBox.Show("Querido usuario:\nSeleccione los registros de las habitaciones disponibles que desee agregar, " +
                        "el sistema valida que las fechas de la reserva a la que se asignaran estas habitaciones " +
                        "no coincide con otras reservas a las que ya puedan estar asignadas", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lo sentimos, no se pueden administrar las habitaciones de reservaciones finalizadas o canceladas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar un registro de reserva", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAregarServicios_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                if (dgvReservas.CurrentRow.Cells[10].Value.ToString() != "FINALIZADA" && dgvReservas.CurrentRow.Cells[10].Value.ToString() != "CANCELADA")
                {
                    int idReserva = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
                    pnlTitulo.Visible = false;
                    pnlCliente.Visible = false;
                    pnlFormulario.Visible = false;
                    pnlReserva.Visible = false;
                    this.AutoScroll = false;
                   
                    abrirForm(new frmAgregarServicio(idReserva, this));

                    MessageBox.Show("Querido usuario:\nSeleccione el registro de la habitación a la que se agreará el servicio, luego, de la tabla de servicios disponibles," +
                        " seleccione el que desee. Después debe llenar el campo del precio del servicio y la fecha se registrará como la del día actual.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lo sentimos, no se pueden administrar los servicios de reservaciones finalizadas o canceladas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Asegúrese de seleccionar un registro de reserva", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                try
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = Cliente.BuscarCliente(txtBuscarCliente.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el correo del cliente para buscar.", "Campo de búsqueda vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
