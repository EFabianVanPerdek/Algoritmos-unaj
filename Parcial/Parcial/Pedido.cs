using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Pedido
    {
        private string Nombre;
        private string Presentacion;
        private string NombreFarma;
        private int Cantidad;

        public Pedido(string nombre, string presentacion, string nombrefarma, int cantidad)
        {
            this.Nombre = nombre;
            this.Presentacion = presentacion;
            this.NombreFarma = nombrefarma;
            this.Cantidad = cantidad;
        }
        public string nombre { set{ Nombre = value; }get{ return Nombre; } }
        public string presentacion { set { Presentacion = value; } get { return Presentacion; } }
        public string nombrefarma { set { NombreFarma = value; } get { return NombreFarma; } }
        public int cantidad { set{ Cantidad = value; }get{ return Cantidad; } }

        public static void ImprimirPedido(Pedido p)
        {
            Console.WriteLine($"Nombre Farmacia solicitante: {p.nombrefarma}\nNombre medicamento: {p.nombre}\nPresentacion: {p.presentacion}\nCantidad: {p.cantidad}");
        }
  
    }
}
