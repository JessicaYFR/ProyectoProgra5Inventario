using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        //Atributos

        public int IDProveedor { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //Métodos

        public bool Agregar()
        {
            bool R = false;
            return R;
        }
        public bool Editar()
        {
            bool R = false;
            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;
            return R;
        }
        public bool ConsultarPorCedula()
        {
            bool R = false;
            return R;
        }
        public bool ConsultarEmail()
        {
            bool R = false;
            return R;
        }
        public DataTable ListarProveedores()
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
