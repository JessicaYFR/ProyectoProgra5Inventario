using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //Atributos
        public int IDUsuario { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Contrasennia { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public string CorreoRespaldo { get; set; }

        //Atributos compuestos y su instancia
    
        TipoUsuario MiTipoUsuario { get; set; }

        public Usuario()
        {
            MiTipoUsuario = new TipoUsuario();
        }

        //Metodos

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
        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();
            return R;
        }
        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
