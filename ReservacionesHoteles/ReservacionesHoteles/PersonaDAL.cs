using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionesHoteles
{
    public class PersonaDAL
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;
            //Ayuda a verificar si los campos estan completos
            if (CamposLlenos(persona))
            {
                try
                { //Para casos de manejo de excepciones
                    using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                    {
                        //funcion que se cumple en la base de datos para guardar un nuevo cliente
                        string query = "insert into Cliente (Nombre, Apellido, Email, Telefono) values ('" + persona.Nombre + "', '" + persona.Apellidos + "','" + persona.Email + "','" + persona.Telefono + "')";
                        //crea un parametro SQL para la consulta y la conexion
                        SqlCommand command = new SqlCommand(query, conexion);

                        //Parametros para prevencion de inyeccion SQL
                        command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@Apellido", persona.Apellidos);
                        command.Parameters.AddWithValue("@Email", persona.Email);
                        command.Parameters.AddWithValue("@Telefono", persona.Telefono);

                        //Ejecuta el comando Sql y obtienen el numero de filas
                        retorna = command.ExecuteNonQuery();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                }
            }
            else {
                //Si algun campo esta vacio muestra el siguiente mensaje
                MessageBox.Show("Por favor complete los campos antes de agregar un nuevo cliente");
            }
                return retorna;
            }

        private static bool CamposLlenos(Persona persona)
        {
            // Verifica que todos los campos tengan datos
            return !string.IsNullOrWhiteSpace(persona.Nombre) &&
                   !string.IsNullOrWhiteSpace(persona.Apellidos) &&
                   !string.IsNullOrWhiteSpace(persona.Email) &&
                   !string.IsNullOrWhiteSpace(persona.Telefono);
        }

        public static List<Persona> PresentarRegistro()
        {
            //Se crea una lista para almacenar los registros de los clientes
            List<Persona> list = new List<Persona>();
            try { //para manejo de excepciones
                //Para obtener la conexion a la base de datos
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    //funcion que se cumple en la base de datos
                    string query = "select* from Cliente";
                    SqlCommand command = new SqlCommand(query, conexion);
                    //Ejecuta la consulta y obtiene un lector de base de datos para leer los resultados 
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //Se crea una instancia para almacenar los datos de la fila actual
                        Persona persona = new Persona();

                        //Asigna los valores de las columnas de la fila objeto persona
                        persona.ClienteID = reader.GetInt32(0);
                        persona.Nombre = reader.GetString(1);
                        persona.Apellidos = reader.GetString(2);
                        persona.Email = reader.GetString(3);
                        persona.Telefono = reader.GetString(4);

                        //Agregamos a la lista
                        list.Add(persona);
                    }
                    //se cierra la conexion a base de datos
                    conexion.Close();
                    
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error al obtener los registros de clientes: " + ex.Message);
            }
            //retorna la lista
            return list;
        }

        //Metodo que modifica se le pasa un objeto de Persona
        public static int ModificarPersona(Persona persona)
        {
            int result = 0;
            //Se hace la conecion de base de datos
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                //codigo que se ejecuta dentro la base de datos 
                string query = "UPDATE Cliente SET Nombre='" + persona.Nombre + "',Apellido='" + persona.Apellidos + "' ,Email='" + persona.Email + "',Telefono='" + persona.Telefono + "' WHERE ClienteID= " + persona.ClienteID + " ";

                SqlCommand command = new SqlCommand(query, conexion);
                result = command.ExecuteNonQuery(); //ejecuta los comandos anteriores
                conexion.Close(); //Cierra la conexion a base de datos
            }
            return result;
        }

        public static int ModificarPersona2(Persona persona)
        {
            int result = 0;
            // Se hace la conexión a la base de datos
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                // Código que se ejecuta en la base de datos
                string query = "UPDATE Cliente SET Nombre=@Nombre, Apellido=@Apellido, Email=@Email, Telefono=@Telefono WHERE ClienteID=@ClienteID";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Añadiendo los parámetros al comando
                    command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    command.Parameters.AddWithValue("@Apellido", persona.Apellidos);
                    command.Parameters.AddWithValue("@Email", persona.Email);
                    command.Parameters.AddWithValue("@Telefono", persona.Telefono);
                    command.Parameters.AddWithValue("@ClienteID", persona.ClienteID);

                    // Ejecuta los comandos anteriores
                    result = command.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return result;
        }


        public static int EliminarPersona(int ClienteID)
        {
            int retorna = 0;
            //Conexion a la base de datos
            try { //Manejo de excepcion al momento de eliminar
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    //el query se ejecutara en la base de datos
                    string query = "delete from Cliente where ClienteID=" + ClienteID + " ";
                    SqlCommand command = new SqlCommand(query, conexion); //Hace que se cumpla lo anterior
                                                                          //Parametro para prevenir SQL Injeccion
                    command.Parameters.AddWithValue("@ClienteID", ClienteID);
                    retorna = command.ExecuteNonQuery();
                    // Verifica si se eliminó algún registro
                    if (retorna == 0)
                    {
                        Console.WriteLine("No se encontró ningún cliente registrado con el ClienteID: " + ClienteID);
                        // Opcional: Mostrar un mensaje al usuario o lanzar una excepción
                    }

                }
                
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            return retorna;
        }
    }
}
