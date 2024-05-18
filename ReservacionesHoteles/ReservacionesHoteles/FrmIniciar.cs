using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservacionesHoteles
{
    public partial class FrmIniciar : Form
    {
        //public static class ConexionBD
        //{
        //public static string baseDatos { get; } = "Server=Jonathan-PC; Database=ReservaHoteles; Integrated Security=True;";
        //}
        //public static string baseDatos = ;

       


        public FrmIniciar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            // Utiliza el objeto SqlConnection para conectar con la base de datos.
            using (SqlConnection conexion = new SqlConnection(ConexionBD.baseDatos))
            {
                // Abre la conexión a la base de datos.
                conexion.Open();

                if (txtNombre.Text != "" && txtContrasena.Text != "")
                {
                    ValidarCredenciales val = new ValidarCredenciales();
                    var resultado = val.VerificarCredenciales(txtNombre.Text, txtContrasena.Text, conexion);

                        //Al ser un valor boolean basta con poner la variable en el if
                    if(resultado)
                    {
                        LimpiarCampos();
                        this.Hide();
                        MDIMenu fr1 = new MDIMenu();
                        fr1.MdiParent = this.MdiParent;
                        fr1.Show();
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
            txtNombre.Clear();
            txtContrasena.Clear();
            txtNombre.Focus();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
    }
}
