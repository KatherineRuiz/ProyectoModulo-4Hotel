using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class EstadoReserva
    {
        private int idEstadoReserva;
        private string nombreEstadoReserva;

        public int IdEstadoReserva { get => idEstadoReserva; set => idEstadoReserva = value; }
        public string NombreEstadoReserva { get => nombreEstadoReserva; set => nombreEstadoReserva = value; }

        public static DataTable CargarEstadoReserva()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select idEstadoReserva, nombreEstadoReserva from EstadoReserva;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }
    }
}
