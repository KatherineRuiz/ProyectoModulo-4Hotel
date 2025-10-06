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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }
        private void mostrarClientes()
        {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = Cliente.CargarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.NombreCliente = txtNombre.Text;
                cliente.ApellidoCliente = txtApellido.Text;
                cliente.CorreoCliente = txtCorreo.Text;
                cliente.insertarCliente();
                mostrarClientes();
                MessageBox.Show("Cliente agregado exitosamente.", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                string registroEliminar = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el cliente: " + registroEliminar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    if (cliente.eliminarCliente(idCliente) == true)
                    {
                        MessageBox.Show("Registro Eliminado" + registroEliminar, "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarClientes();
                    }

                }
                else
                {
                    MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.NombreCliente = txtNombre.Text;
                cliente.ApellidoCliente = txtApellido.Text;
                cliente.CorreoCliente = txtCorreo.Text;
                if (cliente.actualizarCliente())
                {
                    mostrarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = Cliente.BuscarCliente(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el servicio: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
