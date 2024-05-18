using System;
using System.Windows.Forms;

namespace ReservacionesHoteles
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            refressPantalla();
            txtId.Enabled = false; //Campo que no se puede modificar
            LimpiarCampos();
        }


        public void refressPantalla() 
        {
            dataGridViewClientes.DataSource = PersonaDAL.PresentarRegistro();
        }
      
        //Este codigo hace que cuando selecciones un cliente en el data griw,
        //se llenen los campos para que sea mas comodo editar
        private void dataGriiViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            //se hace un coversion explicita con el datagrid 
            //CurrecrRow nos permite obtener una fila de la base de datos
            txtId.Text = Convert.ToString(dataGridViewClientes.CurrentRow.Cells["ClienteID"].Value);
            txtNombres.Text = Convert.ToString(dataGridViewClientes.CurrentRow.Cells["Nombre"].Value);
            txtApellidos.Text = Convert.ToString(dataGridViewClientes.CurrentRow.Cells["Apellidos"].Value);
            txtEmail.Text = Convert.ToString(dataGridViewClientes.CurrentRow.Cells["Email"].Value);
            txtTelefono.Text = Convert.ToString(dataGridViewClientes.CurrentRow.Cells["Telefono"].Value);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de la clase Persona
            Persona persona = new Persona();
            { 
                //lee los campos
            persona.Nombre = txtNombres.Text;
            persona.Apellidos = txtApellidos.Text;
            persona.Email = txtEmail.Text;
            persona.Telefono = txtTelefono.Text;
            };
            if(dataGridViewClientes.SelectedRows.Count == 1)
            {

             //Obtiene  el id del cliente desde la fila
            int Id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["ClienteID"].Value);
            //Condicional que ayuda que le boton de guardar si tiene un id
            //se va a editar y si no encuentra id va a guardar un nuevo registro
            
            
            if (Id > 0 ) //Modifica el registro
            {
                persona.ClienteID = Id;
                    //llama al metodo en la clase PersonaDAL
                int result = PersonaDAL.ModificarPersona(persona); 

                    //Condicional segun sea el comportamiento de uso
                if (result > 0)
                {
                    MessageBox.Show("Exito al Modificar");

                }
                else
                {
                    MessageBox.Show("Error al Modificar");
                }
            }

        }
            else 
            {
                //si no tiene un id seleccionado va a agregar un nuevo cliente
                int result = PersonaDAL.AgregarPersona(persona); //LLama y asigna el metodo de Agregar

                if (result > 0)
                {
                    MessageBox.Show("Exito al guardar");

                }
                else
                {
                    MessageBox.Show("Registro denegado");
                }

            }
            refressPantalla();
            LimpiarCampos();
           

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //este metodo solo limpia los campos para agregar un nuevo cliente
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dataGridViewClientes.CurrentCell = null;
            txtNombres.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClientes.SelectedRows.Count == 1)
                {
                    //Obtiene el ID del cliente desde la fila seleccionada
                    int ClienteID = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["ClienteID"].Value);

                    //declaramos una variable para almacenar el resultado de la eliminacion
                    int resultado = PersonaDAL.EliminarPersona(ClienteID);
                    //verifica si se encontro y elimino el cliente correctamente
                    if (resultado > 0)
                    {
                        MessageBox.Show("Eliminado con exito");
                    }
                    else
                    {
                        //Muestra un mensaje de error si no se encuentra ningun cliente
                        MessageBox.Show("No se encontro ningun cliente con ese id:" + ClienteID);
                    }
                    //Metodo para refrescar despues de la eliminacion
                    refressPantalla();
                    //Metodo que limpia los campos
                    LimpiarCampos();
                }
                else
                {
                    //Si no se encuentra la fila muestra el siguiente mensaje
                    MessageBox.Show("Por favor, seleccione una fila para eliminar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }

        private void LimpiarCampos()
        {
            //limpia los campos al inicio del formulario
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtId.Text = string.Empty;
        }


      
    }
}
