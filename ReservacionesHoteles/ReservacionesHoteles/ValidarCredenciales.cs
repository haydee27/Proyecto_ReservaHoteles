using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReservacionesHoteles
{

    internal class ValidarCredenciales
    {
        
        //Validamos las credenciales
        public bool VerificarCredenciales(string nombreUsuario, string clave, SqlConnection conexion)
        {
            string consultaUsuarios = "SELECT TOP 1 * FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

            // SqlCommand se utiliza para enviar comandos SQL a la base de datos
            using (SqlCommand verificacion = new SqlCommand(consultaUsuarios, conexion))
            {
                verificacion.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                verificacion.Parameters.AddWithValue("@Clave", clave);

                var resultado = verificacion.ExecuteScalar();

                // Si el resultado no es null, devolvemos true.
                if (resultado != null)
                {
                    return true;
                }
            }

            // no se encontro registro devolvemos false.
            return false;
        }

    }
}
