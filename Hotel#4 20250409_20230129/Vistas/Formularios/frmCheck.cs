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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
            MostrarReservas();


            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckIn.MaxDate = DateTime.Now;
            dtpCheckIn.Value = DateTime.Now;

            dtpCheckOut.MinDate = DateTime.Now;
            dtpCheckOut.MaxDate = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            
        }

        private void MostrarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = Reservacion.CargarReservasActivas();
        }

        private void dgvReservas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                txtCorreo.Text = dgvReservas.CurrentRow.Cells[5].Value.ToString();
                txtIdReserva.Text = dgvReservas.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdReserva.Clear();
            txtCorreo.Clear();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                Reservacion re = new Reservacion();
                re.IdReserva = Convert.ToInt32(txtIdReserva.Text);
                re.CheckIn = dtpCheckIn.Value;


                string registroEditar = txtCorreo.Text;
                DialogResult respuesta = MessageBox.Show("¿Quieres registrar el checkIn de este cliente?\n" + registroEditar,
                                                          "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (re.ActualizarCheckIn() == true)
                    {
                        MostrarReservas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el CheckIn, hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar: \n Asegurese de seleccionar una reserva y que el correo electrónico del cliente aparezca en el campo de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                Reservacion re = new Reservacion();
                re.IdReserva = Convert.ToInt32(txtIdReserva.Text);
                re.CheckOut = dtpCheckOut.Value;


                string registroEditar = txtCorreo.Text;
                DialogResult respuesta = MessageBox.Show("¿Quieres el checkOut de este cliente?\n" + registroEditar,
                                                          "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (re.ActualizarCheckOut() == true)
                    {

                        MostrarReservas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el CheckOut, hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar: \n Asegurese de seleccionar una reserva y que el correo electrónico del cliente aparezca en el campo de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
                    dgvReservas.DataSource = Reservacion.BuscarReservasActivas(txtBuscarReserva.Text);
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
    }
}
