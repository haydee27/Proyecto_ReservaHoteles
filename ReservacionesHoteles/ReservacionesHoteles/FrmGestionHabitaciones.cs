using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionesHoteles
{
    public partial class FrmGestionHabitaciones : Form
    {
        public FrmGestionHabitaciones()
        {
            InitializeComponent();
        }
        FrmIniciar frmIniciar=new FrmIniciar();
        private void FrmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConexionBD.baseDatos);
            SqlCommand ObtenerHabita = new SqlCommand("ObtenerHabitaciones", conexion);
            ObtenerHabita.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(ObtenerHabita);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgvHabitaciones.DataSource = dt;
        }
    }
}
