using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Modelos.Entidades
{
    public class Reservacion
    {
        private int idReserva;
        private DateTime fechaReserva;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private DateTime checkIn;
        private DateTime checkOut;
        private int id_Cliente;
        private int id_EstadoReserva;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public int Id_EstadoReserva { get => id_EstadoReserva; set => id_EstadoReserva = value; }

        //Metodo Leer
        public static DataTable CargarReservas()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "Select idReserva As [N°], fechaReserva As [Fecha de Registro], nombreCliente As [Nombre], ApellidoCliente [Apellido]," +
                    " correoCliente As Correo, fechaInicio As [Inicio], fechaFinal As [Final], checkIn As CheckIn, checkOut As CheckOut, nombreEstadoReserva As Estado " +
                    "\r\nfrom Reservacion R" +
                    "\r\nInner join Cliente C On R.id_Cliente = C.idCliente" +
                    "\r\nInner join EstadoReserva ES on R.id_EstadoReserva = ES.idEstadoReserva";

                //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                //Creamos un objeto DataTable, una tabla donde se guardara la informacion
                DataTable dataVirtual = new DataTable();
                //Pasamos la informacion de adaptador a la tabla
                add.Fill(dataVirtual);

                return dataVirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar las reservaciones " + ex, "Error");
                return null;
            }
            
            
        }

        //Metodo Insertar
        public bool InsertarReservas()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                //Comando para insertar datos a Sql Server
                string consultaQuery = "Insert into Reservacion(fechaReserva, fechaInicio, fechaFinal, id_Cliente, id_EstadoReserva) " +
                    "values ( @fechaReserva, @fechaInicio, @fechaFinal, @id_Cliente, @id_EstadoReserva);";

                //Creamos un objeto de tipo SqlCommand
                SqlCommand cmd = new SqlCommand(consultaQuery, conexion);

                //Sustituimos los valores temporales por los astributos
                cmd.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                cmd.Parameters.AddWithValue("@id_Cliente", id_Cliente);
                cmd.Parameters.AddWithValue("@id_EstadoReserva", id_EstadoReserva);

                //Enviamos el comando a SqlServer
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {

                    MessageBox.Show("Hubo un error en la insersión de los datos","Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar la reervacion en la base de datos " + ex, "Error");
                return false;
            }
        }

        public bool ActualizarReserva()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar(); ;
                string consultaUpdate = "Update Reservacion set fechaInicio = @fechaInicio, fechaFinal = @fechaFinal, id_Cliente = @id_Cliente, id_EstadoReserva = @id_EstadoReserva";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                actualizar.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                actualizar.Parameters.AddWithValue("@id_Cliente", id_Cliente);
                actualizar.Parameters.AddWithValue("@id_EstadoReserva", id_EstadoReserva);

                actualizar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos de la reservación" + ex, "Error");
                return false;
            }
        }
    }
}
