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
    public class EstadoHabitacion
    { 
        private int idEstadoHabitacion;
        private string nombreEstadoHabitacion;

        public int IdEstadoHabitacion { get => idEstadoHabitacion; set => idEstadoHabitacion = value; }
        public string NombreEstadoHabitacion { get => nombreEstadoHabitacion; set => nombreEstadoHabitacion = value; }

        public static DataTable CargarEstadoHabitacion()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Select*from EstadoHabitacion;";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al mostrar los estados de las habitaciones " + ex, "Error");
                return null;
            }
        }
    }
}
