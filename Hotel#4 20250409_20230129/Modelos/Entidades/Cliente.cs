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
    public class Cliente
    {
        private int idCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string correoCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }

        public static DataTable CargarClientes()
        {
            try
            {
                //Creamos una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
                SqlConnection conexion = Conexion.Conectar();

                string consultaQuery = "Select idCliente As [N°], nombreCliente As Cliente, apellidoCliente As Apellido, correoCliente As Correo from Cliente";

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
                MessageBox.Show("Hubo un error al mostrar los clientes " + ex, "Error");
                return null;
            }
        }

        public bool insertarCliente()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = "Insert into Cliente (nombreCliente, apellidoCliente, correoCliente) " +
                    "values (@nombreCliente, @apellidoCliente, @correoCliente)";
                SqlCommand comando = new SqlCommand(consultaQuery, conexion);
                comando.Parameters.AddWithValue("@nombreCliente", NombreCliente);
                comando.Parameters.AddWithValue("@apellidoCliente", ApellidoCliente);
                comando.Parameters.AddWithValue("@correoCliente", CorreoCliente);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al insertar el cliente " + ex, "Error");
                return false;
            }
        }

        public bool eliminarCliente(int idCliente)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaDelete = "Delete from Cliente where idCliente = @idCliente";
                SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                delete.Parameters.AddWithValue("@idCliente", idCliente);
                delete.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar el cliente " + ex, "Error");
                return false;
            }
        }

        public bool actualizarCliente()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Cliente set nombreCliente = @nombreCliente, apellidoCliente = @apellidoCliente, correoCliente = @correoCliente where idCliente = @idCliente";
                SqlCommand update = new SqlCommand(consultaUpdate, conexion);
                update.Parameters.AddWithValue("@nombreCliente", NombreCliente);
                update.Parameters.AddWithValue("@apellidoCliente", ApellidoCliente);
                update.Parameters.AddWithValue("@correoCliente", CorreoCliente);
                update.Parameters.AddWithValue("@idCliente", idCliente);
                update.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado con exito", "Exito");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar el cliente " + ex, "Error");
                return false;
            }
        }

        public static DataTable BuscarCliente(string nombreCliente)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaQuery = $"Select idCliente As [N°], nombreCliente As Cliente, apellidoCliente As Apellido, correoCliente As Correo from Cliente where nombreCliente like '%{nombreCliente}%';";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable dt = new DataTable();
                add.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar el cliente " + ex, "Error");
                return null;
            }
        }
    }
}
