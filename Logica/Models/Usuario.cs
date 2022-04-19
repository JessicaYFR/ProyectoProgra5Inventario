using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public TipoUsuario MiTipoUsuario { get; set; }

        public Usuario()
        {
            MiTipoUsuario = new TipoUsuario();
        }

        //Metodos

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            //TO DO :Aplicar encriptacion a la contraseña

            //lista de parametros que se envian al sp
            MiCnn3.ListaParametros.Add(new SqlParameter("@Cedula",this.Cedula));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Nombre", this.NombreCompleto));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn3.ListaParametros.Add(new SqlParameter("@CorreoRespaldo", this.CorreoRespaldo));
            MiCnn3.ListaParametros.Add(new SqlParameter("@UsuarioTipo", this.MiTipoUsuario.IDTipoUsuario));

            int Resultado = MiCnn3.EjecutarUpdateDeleteInsert("SpUsuariosAgregar");

            //en el sp cuando se ejecuta correctamente selecciona un 1 que es el 
            //numero que captura la variable Resultado
            if (Resultado>0)
            {
                R = true;
            }

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

            Conexion MiCnn = new Conexion();

            //se agregan los parámetros del SP de consultar por cedula de usuario
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SpUsuariosConsultarPorCedula");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }
        public DataTable ListarActivos(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            //Hago una instancia a la conexión para poder llamar los datos
            Conexion MiCnn = new Conexion();

            //Le asigno a R que es el dato de salida el objeto de conexión con 
            //el llamado al método de select que es el que me sirve en este caso
            //porque es SP lo que hace es un select de los usuarios, y por supuesto le paso por parámetro
            // el nombre del SP
            R = MiCnn.EjecutarSelect("SpUsuariosListarActivos");

            return R;
        }
        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
