using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class HabitacionReserva
    {
        private int idHabitacionReserva;
        private int id_Reserva;
        private int id_Habitacion;

        public int IdHabitacionReserva { get => idHabitacionReserva; set => idHabitacionReserva = value; }
        public int Id_Reserva { get => id_Reserva; set => id_Reserva = value; }
        public int Id_Habitacion { get => id_Habitacion; set => id_Habitacion = value; }

        public bool InsertarHabitacionReserva()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "Insert into HabitacionReserva(id_Reserva, id_Habitacion) " +
                    "values ( @id_Reserva, @id_Habitacion);";

                SqlCommand cmd = new SqlCommand(consultaQuery, conexion);

                cmd.Parameters.AddWithValue("@id_Reserva", id_Reserva);
                cmd.Parameters.AddWithValue("@id_Habitacion", id_Habitacion);

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
                MessageBox.Show("Hubo un error al insertar la habitación en la base de datos " + ex, "Error");
                return false;
            }
        }

        public bool EliminarHabitacionReserva(int id)
        {
            try
            {
                SqlConnection con = Conexion.Conectar();
                string comando = "Delete from HabitacionReserva where idHabitacionReserva = @idHabitacionReserva;";
                
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@idHabitacionReserva", id);

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
                MessageBox.Show("Error al eliminar los datos de la reservación" + ex, "Error");
                return false;
            }

        }


    }
}
