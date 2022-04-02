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
    public partial class FrmMDIPrincipal : Form
    {
        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //el if es para permitir que el formulario solo se muestre una vez, es decir, sim importar cuantas veces se de click, solamente se abrirá una vez
            //si es formulario no está visible, entonces:
            if (!ObjetosGlobales.MiFormGestionUsuarios.Visible)
            {
                //hago una instancia del fromulario para llamarlo
                ObjetosGlobales.MiFormGestionUsuarios = new FrmUsuariosGestion();
              
                //y lo hago visible
                ObjetosGlobales.MiFormGestionUsuarios.Show();

                
            }

        }

        private void gESTIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
