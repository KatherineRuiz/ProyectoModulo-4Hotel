using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace Modelos
{
    public class Conexion
    {
        private static string servidor = "abra\\SQLEXPRESS";
        private static string basedeDatos = "HotelEvaluacion";


        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data Source= {servidor}; Initial Catalog={basedeDatos}; Integrated Security=true;";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
