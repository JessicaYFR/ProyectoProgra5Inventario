using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoUsuario
    {
        //Atributos
        public int IDTipoUsuario { get; set; }
        public string TipoDeUsuario { get; set; }

        //Métodos
        public DataTable Listar()
        {
            DataTable R = new DataTable();



            return R;
        }
    }
}
