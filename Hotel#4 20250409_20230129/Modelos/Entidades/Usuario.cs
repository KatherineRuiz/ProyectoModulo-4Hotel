using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Modelos.Entidades
{
    public class Usuario
    {
        //Declaramos los atributos de la clase
        private int idUsuario;
        private string correoUsuario;
        private string clave;
        private int id_Rol;

   
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }

        public bool RegistrarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string queryhas = "Insert Into Usuario(correoUsuario, clave,id_Rol) values ( @correo, @clave, @idRol)";
                SqlCommand insertar = new SqlCommand(queryhas, conexion);
                insertar.Parameters.AddWithValue("@correo", correoUsuario);
                insertar.Parameters.AddWithValue("@clave", Clave);
                insertar.Parameters.AddWithValue("@idRol", Id_Rol);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este usuario ya existe, utiliza otro correo" + ex);
                return false;
            }
        }



        public static int IdentificarRol(string correoUsuario)
        {
            try
            {
                int id_Rol;
                SqlConnection con = Conexion.Conectar();
                string query = "Select id_Rol from Usuario Where correoUsuario = @correo";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@correo", correoUsuario);
                id_Rol = Convert.ToInt32(cmd.ExecuteScalar());
                return id_Rol;
            }
            catch (Exception)
            {
                return -1;
            }

        }


        //Metodo para verificar el login de los usuarios
        public bool VerificarLogin(string correo, string clave)
        {
            string hashEnBaseDeDatos = "";
            SqlConnection con = Conexion.Conectar();
            string query = "Select clave from Usuario Where correoUsuario = @correo";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Correo", correo);
            MessageBox.Show("executeescalar" + cmd.ExecuteScalar());

            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();

                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
            }
        }

       //Metodo para traer los usuarios de la base de datos
        public static DataTable CargarUsuario()
        {
            try
            {
                //Creamos un objeto conexion
                SqlConnection conexion = Conexion.Conectar();
                //Creamos la consulta y la enviamos a la base de datos 
                string consultaQuery = "select Usuario.idUsuario As [N°], Usuario.correoUsuario As [Usuario], Rol.nombreRol As [Rol]," +
                    "from Usuario" +
                    "\r\ninner join\r\nRol On Usuario.id_Rol = Rol.idRol";
                SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
                //Creamos la tabla virtual, la rellenamos con la información obtenida y la retornamos
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Este correo electrónico ya existe, ingrese uno distinto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            
        }

        //Método para insertar usuarios 
        public bool InsertarUsuario()
        {
            try
            {
                //Creamos un objeto conexion
                SqlConnection con = Conexion.Conectar();
                //Creamos el comando para insertar
                string comando = "insert into Usuario(CorreoUsuario, clave, id_Rol)" + "values (@Correo, @clave, @id_Rol);";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@Correo", correoUsuario);
                cmd.Parameters.AddWithValue("@clave", Clave);
                cmd.Parameters.AddWithValue("@id_Rol", Id_Rol);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Este correo electrónico ya existe, ingrese uno distinto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La insersión del usuario falló: " + ex);
                return false;
            }
            
        }

        public bool EliminarUsuario(int id)
        {
            SqlConnection conexion = Conexion.Conectar();
            string colsultaDelete = "Delete from Usuario where idUsuario = @id";
            SqlCommand delete = new SqlCommand(colsultaDelete, conexion);
            delete.Parameters.AddWithValue("@id", id);
            if (delete.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Usuario set nombreUsuario = @nombre, clave = @clave, estadoUsuario = @estadoUsuario, id_Rol = @id_Rol where idUsuario = @idUsuario";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@Correo", correoUsuario);
                actualizar.Parameters.AddWithValue("@clave", Clave);
                actualizar.Parameters.AddWithValue("@id_Rol", Id_Rol);
                actualizar.Parameters.AddWithValue("@idUsuario", IdUsuario);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos" + ex);
                return false;
            }
        }


    }
}
