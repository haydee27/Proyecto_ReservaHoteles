using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionesHoteles
{
    public class Persona
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string Email { get; set; }
        public string Telefono { get; set; }


        public Persona(int ClienteID, string Nombre, string Apellidos, string Email, string Telefono)
        {
            this.ClienteID = ClienteID;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Email = Email;
            this.Telefono = Telefono;
        
        }

        public Persona()
        {
        }
    }
}
