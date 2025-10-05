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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string correo = txtCorreo.Text;

            Usuario Correo = new Usuario();

            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtClave.Text)))
            {
                if (Correo.VerificarLogin(correo, clave))
                {
                    int id_Rol = Usuario.IdentificarRol(correo);
                    if (id_Rol == 1)
                    {
                        if (true)
                        {
                            MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDashboard fd = new frmDashboard();
                            fd.Show();
                            Form parentForm = this.FindForm();
                            if (parentForm != null)
                            {
                                parentForm.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    //else if (id_Rol == 2)
                    //{
                    //    if (true)
                    //    {
                    //MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //frmDashboard fd = new frmDashboard();
                    //fd.Show();
                    //Form parentForm = this.FindForm();
                    //if (parentForm != null)
                    //{
                    //    parentForm.Hide();
                    //}
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("El usuario o la contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                    //}
                    //else if (id_Rol == 3)
                    //{
                    //    if (true)
                    //    {
                    //          MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //          frmDashboard fd = new frmDashboard();
                    //          fd.Show();
                    //          Form parentForm = this.FindForm();
                    //if (parentForm != null)
                    //{
                    //    parentForm.Hide();
                    //}
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("El usuario o la contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                    // }
                    else
                    {
                        MessageBox.Show("Lo sentimos, hubo un error al encontrar su rol", "Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                MessageBox.Show("No se permite pegar contenido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // Bloquear
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
