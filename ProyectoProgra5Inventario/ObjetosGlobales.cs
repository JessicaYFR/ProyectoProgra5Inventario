using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra5Inventario
{
    public static class ObjetosGlobales
    {
        //Esta clase se "autoinstancia" al momento de inicializar la aplicación 
        //los atributos y funciones que sean públicas serán visibles en la globalidad de la aplicación

        //Hago una instancia global del formulario de usuarios 
        //que es a la que se le da click en el menú del usuario principal. Es decir, crea un objeto para el formulario que 
        //puede ser llamado
         public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion(); 
    }
}
