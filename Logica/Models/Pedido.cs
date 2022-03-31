using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Pedido
    {
        //Atributos
        public int IDPedido { get; set; }
        public DateTime FecgaSolicitud { get; set; }
        public string Direccion { get; set; }
        public decimal CantidadSolicitada { get; set; }

        //Atributos compuestos 

        //REVISAR SI LA LISTA ESTÁ BIEN CONSTRUIDA
        public List<Pedido> Pedidos { get; set; }
        Cliente MiCliente { get; set; }
        Producto MiProducto { get; set; }

        public Pedido()
        {
            MiCliente = new Cliente();
            MiProducto = new Producto();
            Pedidos = new List<Pedido>();
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
        public bool ConsultarPorID()
        {
            bool R = false;
            return R;
        }
        public DataTable ListarPorCedulaCliente()
        {
            DataTable R = new DataTable();
            return R;
        }
        public DataTable ListarPorRangoFecha(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
