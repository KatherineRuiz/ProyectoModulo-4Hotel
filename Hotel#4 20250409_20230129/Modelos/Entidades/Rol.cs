using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Rol
    {
        //Declaramos los atributos de la clase
        private int idRol;
        private string nombreRol;

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }

        //Metodo para traer los roles de la base de datos
        public static DataTable CargarRol()
        {
            //Creamos un objeto conexion
            SqlConnection conexion = Conexion.Conectar();
            //Creamos la consultaQuery y la enviamos a la base de datos
            string consultaQuery = "select*from Rol;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            //Creamos un objeto DataTable o lo llenamos con la información obtenida
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }
    }
}
