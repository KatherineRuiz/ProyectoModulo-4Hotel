using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class ServicioReserva
    {
        private int idServicioReserva;
        private int id_HabitacionReserva;
        private int id_Servicio;
        private double precioServicio;
        private DateTime fechaServicio;

        public int IdServicioReserva { get => idServicioReserva; set => idServicioReserva = value; }
        public int Id_HabitacionReserva { get => id_HabitacionReserva; set => id_HabitacionReserva = value; }
        public int Id_Servicio { get => id_Servicio; set => id_Servicio = value; }
        public double PrecioServicio { get => precioServicio; set => precioServicio = value; }
        public DateTime FechaServicio { get => fechaServicio; set => fechaServicio = value; }



        public bool InsertarServicioReserva()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "Insert into ServicioReserva(id_HabitacionReserva, id_Servicio, precioServicio, fechaServicio) " +
                    "values ( @id_HabitacionReserva, @id_Servicio, @precioServicio, @fechaServicio);";

                SqlCommand cmd = new SqlCommand(consultaQuery, conexion);

                cmd.Parameters.AddWithValue("@id_HabitacionReserva", id_HabitacionReserva);
                cmd.Parameters.AddWithValue("@id_Servicio", id_Servicio);
                cmd.Parameters.AddWithValue("@precioServicio", precioServicio);
                cmd.Parameters.AddWithValue("@fechaServicio", fechaServicio);

                //Enviamos el comando a SqlServer
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {

                    MessageBox.Show("Hubo un error en la insersión de los datos", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar el servicio en la base de datos " + ex, "Error");
                return false;
            }
        }

        public static DataTable CargarServiciosSeleccionados(int idReserva)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "select sr.idServicioReserva as [N° Reserva de servicio], sr.id_Servicio AS [N° Servicio], " +
                    "s.nombreServicio as [Servicio], sr.precioServicio as [Precio], hr.idHabitacionReserva As [N° Reserva de Habitación], " +
                    "h.nombreHabitacion as [Habitación], sr.fechaServicio as [Fecha del servicio] " +
                "from ServicioReserva sr " +
                 "inner join Servicio s on sr.id_Servicio = s.idServicio " +
                "inner join HabitacionReserva hr on sr.id_HabitacionReserva = hr.idHabitacionReserva " +
                "inner join Habitacion h on hr.id_Habitacion = h.idHabitacion where hr.id_Reserva = @id_Reserva;";

                //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@id_Reserva", idReserva);
                //Creamos un objeto DataTable, una tabla donde se guardara la informacion
                DataTable dataVirtual = new DataTable();
                //Pasamos la informacion de adaptador a la tabla
                add.Fill(dataVirtual);

                return dataVirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar los servicios seleccionados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public bool ActualizarServicoReserva()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar(); ;
                string consultaUpdate = "Update ServicioReserva set id_HabitacionReserva = @id_HabitacionReserva, id_Servicio = @id_Servicio, precioServicio = @precioServicio where idServicioReserva = @idServicioReserva";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@id_HabitacionReserva", id_HabitacionReserva);
                actualizar.Parameters.AddWithValue("@id_Servicio", id_Servicio);
                actualizar.Parameters.AddWithValue("@precioServicio", precioServicio);
                actualizar.Parameters.AddWithValue("@idServicioReserva", idServicioReserva);

                actualizar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos del servicio" + ex, "Error");
                return false;
            }
        }

        public bool EliminarServicioReserva(int id)
        {
            try
            {
                SqlConnection con = Conexion.Conectar();
                string comando = "Delete from ServicioReserva where idServicioReserva = @id;";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos del servicio" + ex, "Error");
                return false;
            }

        }
    }
}
