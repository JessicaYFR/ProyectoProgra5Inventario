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
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //llamo al método que encapsuñé abajo
            ListarUsuariosActivos();

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


    }
}
