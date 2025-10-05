using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Creamso una variable de tipo SqlConnection y llamamos al metodo de la clase Conexion
            SqlConnection conexion = Conexion.Conectar();

            string consultaQuery = "Select idCliente As [N°], nombreCliente As Nombre, apellidoCliente As Apellido, correoCliente As Correo from Cliente";

            //Creamos un objeto de tipo SqlDataAdapter para obtener el resultado completo
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable, una tabla donde se guardara la informacion
            DataTable dataVirtual = new DataTable();
            //Pasamos la informacion de adaptador a la tabla
            add.Fill(dataVirtual);

            return dataVirtual;
        }

    }
}
