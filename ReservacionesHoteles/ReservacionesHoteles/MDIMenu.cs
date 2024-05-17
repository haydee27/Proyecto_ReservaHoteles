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
    public partial class MDIMenu : Form
    {
        private int childFormNumber = 0;

        public MDIMenu()
        {
            InitializeComponent();
        }

        private void informacionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIniciar frmIniciar = new FrmIniciar();
            frmIniciar.Show();
            this.Close();
        }

        private void InformacionDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionHabitaciones gestionHabitaciones = new FrmGestionHabitaciones();
            gestionHabitaciones.MdiParent = this;
            gestionHabitaciones.Show();
        }

        private void MDIMenu_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConexionBD.baseDatos);
            SqlCommand ObtenerHabita = new SqlCommand("ObtenerHabitaciones", conexion);
            ObtenerHabita.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(ObtenerHabita);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgvHabitaciones.DataSource = dt;
        }

        private void dtgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdHotel.Text = dtgvHabitaciones.SelectedCells[1].Value.ToString();
            txtNumHabita.Text = dtgvHabitaciones.SelectedCells[2].Value.ToString();
            txtTipoHabita.Text = dtgvHabitaciones.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dtgvHabitaciones.SelectedCells[4].Value.ToString();
            checkDisponi.Checked = Convert.ToBoolean(dtgvHabitaciones.SelectedCells[5].Value);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConexionBD.baseDatos))
            {
                SqlCommand command = new SqlCommand("BuscarHabitacionesPorDisponibilidad", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetro de disponibilidad 1
                bool? disponibilidad = checkDisponi.Checked ? true : (bool?)null;
                command.Parameters.AddWithValue("@Disponibilidad", (object)disponibilidad ?? DBNull.Value);

                // Parámetro de ID de la habitación 2
                if (int.TryParse(txtHabitaID.Text, out int habitacionID))
                {
                    command.Parameters.AddWithValue("@HabitacionID", habitacionID);
                }
                else
                {
                    command.Parameters.AddWithValue("@HabitacionID", DBNull.Value);
                }

                // Parámetro de ID del hotel 3
                if (int.TryParse(txtIdHotel.Text, out int hotelID))
                {
                    command.Parameters.AddWithValue("@HotelID", hotelID);
                }
                else
                {
                    command.Parameters.AddWithValue("@HotelID", DBNull.Value);
                }

                // Parámetro de número de la habitación 4
                if (int.TryParse(txtNumHabita.Text, out int numero))
                {
                    command.Parameters.AddWithValue("@Numero", numero);
                }
                else
                {
                    command.Parameters.AddWithValue("@Numero", DBNull.Value);
                }

                // Parámetro de tipo de habitación 5 
                if (string.IsNullOrWhiteSpace(txtTipoHabita.Text))
                {
                    command.Parameters.AddWithValue("@Tipo", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Tipo", txtTipoHabita.Text);
                }

                // Parámetro de precio mínimo 6
                if (decimal.TryParse(txtPrecio.Text, out decimal precioMin))
                {
                    command.Parameters.AddWithValue("@PrecioMin", precioMin);
                }
                else
                {
                    command.Parameters.AddWithValue("@PrecioMin", DBNull.Value);
                }

               
                // Parámetro de descripción   7
                if (string.IsNullOrWhiteSpace(descript.Text))
                {
                    command.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Descripcion", descript.Text);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgvHabitaciones.DataSource = dataTable;
            }

        }

        private void dtgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
