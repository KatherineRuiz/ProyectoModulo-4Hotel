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
            Usuario nuevoUsuario = new Usuario();   
            nuevoUsuario.CorreoUsuario = txtCorreo.Text;    
            nuevoUsuario.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
            nuevoUsuario.Id_Rol = Convert.ToInt32(cbRol.SelectedValue); 
            if (nuevoUsuario.InsertarUsuario())
            {
                MessageBox.Show("Usuario registrado con exito");
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario");
            }
        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.CargarUsuario();
        }   
       
    }
}
