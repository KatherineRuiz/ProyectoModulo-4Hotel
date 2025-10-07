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
    public partial class frmVerReserva : Form
    {
        public frmVerReserva()
        {
            InitializeComponent();
        }


        private void frmVerReserva_Load(object sender, EventArgs e)
        {
            MostrarReservasActivas();
            MostrarReservasCanceladas();
            MostrarReservasEnProceso();
            MostrarReservasFinalizadas();
        }

        private void MostrarReservasActivas()
        {
            dgvReservaActiva.DataSource = null;
            dgvReservaActiva.DataSource = Reservacion.cargarReservasActivas();
        }

        private void MostrarReservasCanceladas()
        { 
            dgvReservasCanceladas.DataSource = null;
            dgvReservasCanceladas.DataSource = Reservacion.cargarReservasCanceladas();
        }
        private void MostrarReservasEnProceso()
        {
            dgvReservasEnCurso.DataSource = null;
            dgvReservasEnCurso.DataSource = Reservacion.cargarReservasEnProceso();
        }
        private void MostrarReservasFinalizadas()
        {
            dgvReservasFinalizdas.DataSource = null;
            dgvReservasFinalizdas.DataSource = Reservacion.cargarReservasFinalizadas();
        }
    }
}
