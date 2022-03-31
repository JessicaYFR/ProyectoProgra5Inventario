using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoProducto
    {
        //Atributos
        public int IDTipoProducto { get; set; }
        public string TipoDeProducto { get; set; }

        //métodos

        public DataTable Listar()
        {
            DataTable R = new DataTable();



            return R;
        }
    }
}
