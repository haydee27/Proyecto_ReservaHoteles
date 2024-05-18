using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ReservacionesHoteles
{
    internal class ConexionBD
    {
       // public static string baseDatos { get; } = "Server=Jonathan-PC; Database=ReservaHoteles; Integrated Security=True;";
       //Solo comentariar las instruccion a base de dato
        public static string baseDatos  = "Server=ABITHABONIRYES\\SQLEXPRESS; Database=ReservaHoteles; Integrated Security=True;";

        public static SqlConnection ObtenerConexion() {
            SqlConnection conn = new SqlConnection("Server=ABITHABONIRYES\\SQLEXPRESS; Database=ReservaHoteles; Integrated Security=True;");
            conn.Open();

            return conn;
        }
    }
}
