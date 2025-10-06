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
    public class Servicios
    {
        private int idServicio;
        private string nombreServicio;
      
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }

        public static DataTable CargarServicios()
        {
            try
            {
                //Creamos una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Select idServicio As [N°], nombreServicio As Servicio from Servicio";
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
                MessageBox.Show("Hubo un error al mostrar los servicios " + ex, "Error");
                return null;
            }
        }

        public bool insertarServicio()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Insert into Servicio (nombreServicio) " +
                    "values (@nombreServicio)";
                SqlCommand comando = new SqlCommand(consultaQuery, conexion);
                comando.Parameters.AddWithValue("@nombreServicio", NombreServicio);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar el servicio " + ex, "Error");
                return false;
            }
        }
        public bool eliminarServicio(int idServicio)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaDelete = "Delete from Servicio where idServicio = @idServicio";
                SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                delete.Parameters.AddWithValue("@idServicio", idServicio);
                delete.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar el servicio " + ex, "Error");
                return false;
            }
        }

        public bool actualizarServicio()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Servicio set nombreServicio = @nombreServicio where idServicio = @idServicio";
                SqlCommand update = new SqlCommand(consultaUpdate, conexion);
                update.Parameters.AddWithValue("@nombreServicio", NombreServicio);
                update.Parameters.AddWithValue("@idServicio", idServicio);
                update.ExecuteNonQuery();
                MessageBox.Show("Servicio actualizado con exito", "Exito");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar el servicio " + ex, "Error");
                return false;
            }
        }

        public static DataTable BuscarServicio(string nombreServicio)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = $"Select idServicio As [N°], nombreServicio As Servicio from Servicio where nombreServicio like '%{nombreServicio}%'";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dt = new DataTable();
                add.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar el servicio " + ex, "Error");
                return null;
            }
        }
    }
}
