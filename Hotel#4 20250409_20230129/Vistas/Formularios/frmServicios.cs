using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            mostrarServicios();
        }

        private void mostrarServicios()
        {
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = Servicios.CargarServicios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios servicio = new Servicios();
                servicio.NombreServicio = txtNombreServicio.Text;
                servicio.insertarServicio();
                mostrarServicios();
                MessageBox.Show("Servicio agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el servicio: " + ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios servicios = new Servicios();
                int idServicio = Convert.ToInt32(dgvServicios.CurrentRow.Cells[0].Value);
                string registroEliminar = dgvServicios.CurrentRow.Cells[1].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el servicio: " + registroEliminar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    if (servicios.eliminarServicio(idServicio) == true)
                    {
                        mostrarServicios();
                        MessageBox.Show("Servicio eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Error al eliminar el servicio","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicios_DoubleClick(object sender, EventArgs e)
        {
            txtNombreServicio.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios servicio = new Servicios();
                servicio.NombreServicio = txtNombreServicio.Text;

                if (servicio.actualizarServicio())
                {
                    mostrarServicios();
                    MessageBox.Show("Servicio actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No hay un servicio seleccionado para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el servicio: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvServicios.DataSource = null;
                dgvServicios.DataSource = Servicios.BuscarServicio(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el servicio: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
