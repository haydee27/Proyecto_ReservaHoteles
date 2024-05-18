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

        private void gestionDeReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionReserva frmGestionReserva = new FrmGestionReserva();
            frmGestionReserva.MdiParent = this;
            frmGestionReserva.Show();
        }

        private void MDIMenu_Load(object sender, EventArgs e)
        {
            FrmGestionHabitaciones FrmGestionHabitaciones = new FrmGestionHabitaciones();
            FrmGestionHabitaciones.MdiParent= this;
            FrmGestionHabitaciones.Show();
        }
    }
}
