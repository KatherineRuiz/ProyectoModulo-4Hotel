using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmUsuarios : Form
    {

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarRoles();
            MostrarUsuarios();
        }



        private void cargarRoles()
        {
            cbRol.DataSource = null;
            cbRol.DataSource = Rol.CargarRol();
            cbRol.DisplayMember = "nombreRol";
            cbRol.ValueMember = "idRol";
            cbRol.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbRol.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtCorreo.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            { 
                try
                {
                      Usuario nuevoUsuario = new Usuario();
                      nuevoUsuario.CorreoUsuario = txtCorreo.Text;
                      nuevoUsuario.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                      nuevoUsuario.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
                      nuevoUsuario.InsertarUsuario();
                      MostrarUsuarios();
                      MessageBox.Show("Usuario registrado exitosamente", "Datos Correctos",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                  MessageBox.Show("Error al registrar usuario", "Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("Por favor, asegurese de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.CargarUsuario();
        }

      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            int idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            string eliminarUsuario = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el usuario " + eliminarUsuario + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (usuario.EliminarUsuario(idUsuario) == true)
                {
                    MessageBox.Show("Registro Eliminado\n" + eliminarUsuario, "Eliminado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MostrarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("No se eliminó el registro", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtClave.Text = "";
            cbRol.SelectedIndex = -1;
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            cbRol.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbRol.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtCorreo.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            {
                Usuario usuario = new Usuario();
                usuario.CorreoUsuario = txtCorreo.Text;
                usuario.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    usuario.IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                    usuario.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                }

                string registroEditar = dgvUsuarios.CurrentRow.Cells[1].Value?.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres editar este registro?\n" + registroEditar,
                                                  "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (usuario.ActualizarUsuario() == true)
                    {
                        MostrarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, asegurese de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }   }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '-' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números, @, guion bajo, punto y guion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }   
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && c != '@' && c != '_' && c != '.' && c != '!' && c != '#' && c != '$' && c != '%' && c != '&' && c != '*' && c != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras, números y caracteres especiales (@ _ . ! # $ % & *)",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
