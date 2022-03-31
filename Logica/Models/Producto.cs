using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        //Atributos simples
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Existencia { get; set; }

        //Atributos compuestos y su instancia

        //REVISAR SI LA LISTA ESTÁ BIEN CONSTRUIDA
        public List<Producto> Productos { get; set; }
        TipoProducto MiTipoProducto { get; set; }       
        UnidadMedida MiUnidadMedida { get; set; }
        Proveedor MiProveedor { get; set; }
        public Producto()
        {
            MiTipoProducto = new TipoProducto();
            MiProveedor = new Proveedor();
            MiUnidadMedida = new UnidadMedida();    
            Productos = new List<Producto>();
        }

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
        public bool ConsultarPorCodigo()
        {
            bool R = false;
            return R;
        }
        public DataTable ListarExistentes()
        {
            DataTable R = new DataTable();
            return R;
        }
        public DataTable ListarInexistentes()
        {
            DataTable R = new DataTable();
            return R;
        }
        public DataTable ListarProductos()
        {
            DataTable R = new DataTable();
            return R;
        }

    }
}
