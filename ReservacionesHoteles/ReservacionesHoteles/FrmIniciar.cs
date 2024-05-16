using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservacionesHoteles
{
    public partial class FrmIniciar : Form
    {
        public static string baseDatos = "Server=DESKTOP-NFDMETJ; Database=ReservaHoteles; Integrated Security=True;";

        public FrmIniciar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            // Utiliza el objeto SqlConnection para conectar con la base de datos.
            using (SqlConnection conexion = new SqlConnection(baseDatos))
            {
                // Abre la conexión a la base de datos.
                conexion.Open();

                if (txtNombre.Text != "" && txtContraseña.Text != "")
                {
                    ValidarCredenciales val = new ValidarCredenciales();
                    var resultado = val.VerificarCredenciales(txtNombre.Text, txtContraseña.Text, conexion);

                        //Al ser un valor boolean basta con poner la variable en el if
                        if(resultado)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            MDIMenu fr1 = new MDIMenu();
                            fr1.ShowDialog();
                            Show();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrecta.","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimpiarCampos();
                        }
                }
                else
                {
                    
                    MessageBox.Show("Por favor, ingrese nombre de usuario y contraseña.","Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }

                conexion.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtNombre.Focus();
        }
    }
}
