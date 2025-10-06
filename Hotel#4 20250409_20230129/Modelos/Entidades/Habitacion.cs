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
    public class Habitacion
    {
        private int idHabitacion;
        private string nombreHabitacion;
        private int numCamas;
        private string ubicacion;
        private double precioHabitacion;
        private int id_EstadoHabitacion;

        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string NombreHabitacion { get => nombreHabitacion; set => nombreHabitacion = value; }
        public int NumCamas { get => numCamas; set => numCamas = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public double PrecioHabitacion { get => precioHabitacion; set => precioHabitacion = value; }
        public int Id_EstadoHabitacion { get => id_EstadoHabitacion; set => id_EstadoHabitacion = value; }

        public static DataTable CargarHabitaciones()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Select idHabitacion As [N°], nombreHabitacion As Habitacion, numCamas As [N° de Camas], ubicacion , precioHabitacion As Precio, nombreEstadoHabitacion As Estado " +
                    "\r\nfrom Habitacion H" +
                    "\r\nInner join EstadoHabitacion EH on H.id_EstadoHabitacion = EH.idEstadoHabitacion";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar las habitaciones " + ex, "Error");
                return null;
            }
        }
        
        public bool insertarHabitacion()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Insert into Habitacion (nombreHabitacion, numCamas, ubicacion, precioHabitacion, id_EstadoHabitacion) " +
                    "values (@nombreHabitacion, @numCamas, @ubicacion, @precioHabitacion, @id_EstadoHabitacion)";
                SqlCommand comando = new SqlCommand(consultaQuery, conexion);
                comando.Parameters.AddWithValue("@nombreHabitacion", NombreHabitacion);
                comando.Parameters.AddWithValue("@numCamas", NumCamas);
                comando.Parameters.AddWithValue("@ubicacion", Ubicacion);
                comando.Parameters.AddWithValue("@precioHabitacion", PrecioHabitacion);
                comando.Parameters.AddWithValue("@id_EstadoHabitacion", Id_EstadoHabitacion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar la habitacion " + ex, "Error");
                return false;
            }
        }

        public bool eliminarHabitacion(int idHabitacion)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaDelete = "Delete from Habitacion where idHabitacion = @idHabitacion";
                SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                delete.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                delete.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar la habitacion " + ex, "Error");
                return false;
            }
        }

        public bool actualizarHabitacion()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Habitacion set nombreHabitacion = @nombreHabitacion, numCamas = @numCamas, ubicacion = @ubicacion, " +
                    "precioHabitacion = @precioHabitacion, id_EstadoHabitacion = @id_EstadoHabitacion where idHabitacion = @idHabitacion";
                SqlCommand update = new SqlCommand(consultaUpdate, conexion);
                update.Parameters.AddWithValue("@nombreHabitacion", NombreHabitacion);
                update.Parameters.AddWithValue("@numCamas", NumCamas);
                update.Parameters.AddWithValue("@ubicacion", Ubicacion);
                update.Parameters.AddWithValue("@precioHabitacion", PrecioHabitacion);
                update.Parameters.AddWithValue("@id_EstadoHabitacion", Id_EstadoHabitacion);
                update.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                update.ExecuteNonQuery();
                MessageBox.Show("Habitacion actualizada con exito", "Exito");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar la habitacion " + ex, "Error");
                return false;
            }
        }

        public static DataTable BuscarHabitacion(string nombreHabitacion)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = $"Select idHabitacion As [N°], nombreHabitacion As Habitacion, numCamas As [N° de Camas], ubicacion , precioHabitacion As Precio, nombreEstadoHabitacion As Estado " +
                    "\r\nfrom Habitacion H" +
                    "\r\nInner join EstadoHabitacion EH on H.id_EstadoHabitacion = EH.idEstadoHabitacion" +
                   $"\r\nwhere nombreHabitacion like '%{nombreHabitacion}%'";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dt = new DataTable();
                add.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar la habitacion " + ex, "Error");
                return null;
            }
        }

        public static DataTable CargarHabitacionesDisponibles(DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "select h.idHabitacion as [N°], h.nombreHabitacion As [Habitación], h.numCamas As [N° Camas], h.ubicacion As [Ubicación], h.precioHabitacion As Precio, eh.nombreEstadoHabitacion As Estado " +
                    "\r\n from Habitacion h " +
                    "\r\ninner join EstadoHabitacion eh on h.id_EstadoHabitacion = eh.idEstadoHabitacion" +
                    "\r\nwhere eh.nombreEstadoHabitacion = 'Disponible' or ( eh.nombreEstadoHabitacion in ('Reservada', 'Ocupada') and h.idHabitacion not in ( select hr.id_Habitacion from HabitacionReserva hr " +
                    "inner join Reservacion r on hr.id_Reserva = r.idReserva where(r.fechaInicio <= @fechaFinal and r.fechaFinal >= @fechaInicio) ) ); ";

                //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                add.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                add.SelectCommand.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                //Creamos un objeto DataTable, una tabla donde se guardara la informacion
                DataTable dataVirtual = new DataTable();
                //Pasamos la informacion de adaptador a la tabla
                add.Fill(dataVirtual);

                return dataVirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar las habitaciones disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static DataTable CargarHabitacionesSeleccionadas(int idReserva)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "select hr.idHabitacionReserva as [N° Reserva de habitación], h.idHabitacion as [N° Habitación], h.nombreHabitacion As [Habitación], h.numCamas As [N° Camas], h.ubicacion As [Ubicación]," +
                    " h.precioHabitacion As Precio, eh.nombreEstadoHabitacion As Estado " +
                    "from Habitacion h " +
                    "inner join EstadoHabitacion eh on h.id_EstadoHabitacion = eh.idEstadoHabitacion " +
                    "inner join HabitacionReserva hr On h.idHabitacion = hr.id_Habitacion where hr.id_Reserva = @id_Reserva;";

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
                MessageBox.Show("Hubo un error al mostrar las habitaciones seleccionadas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public bool ActualizarEstadoHabitacion()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar(); ;
                string consultaUpdate = "Update Habitacion set id_EstadoHabitacion = @id_EstadoHabitacion where idHabitacion = @idHabitacion";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@id_EstadoHabitacion", id_EstadoHabitacion);
                actualizar.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                actualizar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de la abitación" + ex, "Error");
                return false;
            }
        }
    }
}
