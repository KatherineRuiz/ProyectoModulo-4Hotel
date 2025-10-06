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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            abrirForm(new frmUsuarios());
            ocultarSubMenu(false);
        }

        #region "Metodo para ocultar mis subMenus"
        private void ocultarSubMenu(bool estado)
        {
            pnlMenuReservas.Visible = estado;
        }

        #endregion


        #region "Metodo para pintar formularios"
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            //Esto nos ayuda a saber si existe un formulario activo para cerrarlo y que no quede sobrepuesto de otro
            {
                activarForm.Close();
            }
            //Aqui vamos a darle todos los permuisos que tiene un formulario o la clase form
            activarForm = formularioPintar;
            //Luego convertimos a un hijo de tipo de form
            formularioPintar.TopLevel = false;
            //Luego vamos a quitar bordes
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        #endregion


        private void btnReservas_Click(object sender, EventArgs e)
        {
            if (pnlMenuReservas.Visible == false)
            {
                pnlMenuReservas.Visible = true;
            }
            else
            {
                ocultarSubMenu(false);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new frmUsuarios());
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCheck());
        }

        private void btnGestionReserva_Click(object sender, EventArgs e)
        {
            abrirForm(new frmReservas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirForm(new frmClientes());
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHabitaciones());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            abrirForm(new frmServicios());
        }
    }
}
