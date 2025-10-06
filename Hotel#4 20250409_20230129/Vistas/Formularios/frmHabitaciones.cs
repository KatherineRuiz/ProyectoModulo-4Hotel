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
    public partial class frmHabitaciones : Form
    {
        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            mostrarEstadoHabitaciones();
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
        {
            dgvHabitacion.DataSource = null;
            dgvHabitacion.DataSource = Habitacion.CargarHabitaciones();
        }
        private void mostrarEstadoHabitaciones()
        {
            cbEstadoHabitacion.DataSource = null;
            cbEstadoHabitacion.DataSource = EstadoHabitacion.CargarEstadoHabitacion();
            cbEstadoHabitacion.DisplayMember = "nombreEstadoHabitacion";
            cbEstadoHabitacion.ValueMember = "idEstadoHabitacion";
            cbEstadoHabitacion.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion habitacion = new Habitacion();
                habitacion.NombreHabitacion = txtNombreHabitacion.Text;
                habitacion.NumCamas = Convert.ToInt32(txtCamas.Text);
                habitacion.Ubicacion = txtUbicacion.Text;
                habitacion.PrecioHabitacion = Convert.ToDouble(txtPrecio.Text);
                habitacion.Id_EstadoHabitacion = Convert.ToInt32(cbEstadoHabitacion.SelectedValue);
                habitacion.insertarHabitacion();
                mostrarHabitaciones();
                MessageBox.Show("Habitación agregada exitosamente.", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la habitación" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion habitacion = new Habitacion();
                int idHabitacion = Convert.ToInt32(dgvHabitacion.CurrentRow.Cells[0].Value);
                string registroEliminar = dgvHabitacion.CurrentRow.Cells[1].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la habitación: " + registroEliminar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    if (habitacion.eliminarHabitacion(idHabitacion) == true)
                    {
                        MessageBox.Show("Habitación eliminada exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarHabitaciones();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la habitación" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHabitacion_DoubleClick(object sender, EventArgs e)
        {
            txtNombreHabitacion.Text = dgvHabitacion.CurrentRow.Cells[1].Value.ToString();
            txtCamas.Text = dgvHabitacion.CurrentRow.Cells[2].Value.ToString();
            txtUbicacion.Text = dgvHabitacion.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvHabitacion.CurrentRow.Cells[4].Value.ToString();
            cbEstadoHabitacion.Text = dgvHabitacion.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Habitacion habitacion = new Habitacion();
                habitacion.NombreHabitacion = txtNombreHabitacion.Text;
                habitacion.NumCamas = Convert.ToInt32(txtCamas.Text);
                habitacion.Ubicacion = txtUbicacion.Text;
                habitacion.PrecioHabitacion = Convert.ToDouble(txtPrecio.Text);
                habitacion.Id_EstadoHabitacion = Convert.ToInt32(cbEstadoHabitacion.SelectedValue);
                if (habitacion.actualizarHabitacion())
                {
                    mostrarHabitaciones();
                    MessageBox.Show("Habitación actualizada exitosamente.", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la habitación" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHabitacion.DataSource = null;
                dgvHabitacion.DataSource = Habitacion.BuscarHabitacion(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la habitacion: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
