using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra5Inventario.Formularios
{
   
    public partial class FrmUsuariosGestion : Form
    {
        //este objeto permite manipular los cambios que el usuario haga en todo mmentro
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }
        
        //constructor
        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarTiposDeUsuarioEnComboBox()
        {
            //Creo un objeto de Tipo de Usuario
            Logica.Models.TipoUsuario ObjTipoUsuario = new Logica.Models.TipoUsuario();

            //El objeto datatable alimenta los datos del SP
            DataTable ListaTipos = new DataTable();

            ListaTipos = ObjTipoUsuario.Listar();

            //el Cbox es el nombre del combobox y ese id es el que está en SP, que necesita la parte programada
            CboxTipoUsuario.ValueMember = "id";
            CboxTipoUsuario.DisplayMember = "d";

            CboxTipoUsuario.DataSource = ListaTipos;

            //para que la selección inicial esté vacía
            CboxTipoUsuario.SelectedIndex = -1;
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //llamo al método que encapsuñé abajo
            ListarUsuariosActivos();
            CargarTiposDeUsuarioEnComboBox();

        }
        private void ListarUsuariosActivos()
        {
            //Instancio un objeto de la clase Usuario
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //Esto llama al método de usurio de listar activos y lo pone 
            //en un data table para que lo devuelva en ese formato
            DataTable dt = MiUsuario.ListarActivos();

            //Llama al data grid que en este caso el nombre que se le puso fue este DgvListaUsuarios
            //llama a un método propio del sistema del data grid y le asigna lo que está en dt
            //que es la llamada al método de listar los usuarios activos
            DgvListaUsuarios.DataSource = dt;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //TEMPORAL : Se agregan los valores de los atributos del obj local
            MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            MiUsuarioLocal.NombreCompleto = TxtNombre.Text.Trim();
            MiUsuarioLocal.Contrasennia = TxtContrasennia.Text.Trim();
            MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            MiUsuarioLocal.CorreoRespaldo = TxtEmail.Text.Trim();
            MiUsuarioLocal.MiTipoUsuario.IDTipoUsuario = Convert.ToInt32(CboxTipoUsuario.SelectedValue);
    

            //llamado de la función consultar por cedula y 
            //la alimentación por medio de una variale A booleana

            bool A = MiUsuarioLocal.ConsultarPorCedula();

            //De haber otra consulta,Esta agregacion es intercalada en caso de que haya un consultar por email, con la misma estructura
            //del anterior cambiando el nombre de la conexion y el procedimiento almacenado con los parametros.
           
            if (!A) 
            {
                if (MiUsuarioLocal.Agregar())
                {
                    MessageBox.Show("Datos agregados correctamente","Acción exitosa",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al agregar los datos", "Error", MessageBoxButtons.OK);
                }
            }

        }
    }
}
