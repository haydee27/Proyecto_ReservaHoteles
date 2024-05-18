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
    public partial class FrmGestionReserva : Form
    {
       
    public FrmGestionReserva()
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
            dtgvReserva.DataSource = dt;
            
        }
        
        private void dtgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReservaID.Text = dtgvReserva.SelectedCells[0].Value.ToString();
            txtClienteID.Text = dtgvReserva.SelectedCells[1].Value.ToString();
            txtHabitacionID.Text = dtgvReserva.SelectedCells[2].Value.ToString();
            txtEntrada.Text = dtgvReserva.SelectedCells[3].Value.ToString();
            txtSalida.Text = dtgvReserva.SelectedCells[4].Value.ToString();

        }

        private void lblReserva_Click(object sender, EventArgs e)
        {

        }

    }
}
