using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Medicamento
    {
        private string Nombre;
        private string Droga;
        private string Presentacion;
        private string Laboratorio;
        private int Stock;
        private double Precio;

        public Medicamento(string nombre, string droga, string presentacion, string laboratorio, int stock, double precio)
        {
            this.Nombre = nombre;
            this.Droga = droga;
            this.Presentacion = presentacion;
            this.Laboratorio = laboratorio;
            this.Stock = stock;
            this.Precio = precio;
        }
        public string nombre { set{ Nombre = value; }get{ return Nombre; } }
        public string droga { set { Droga = value; } get { return Droga; } }
        public string presentacion { set { Presentacion = value; } get { return Presentacion; } }
        public string laboratorio { set { Laboratorio = value; } get { return Laboratorio; } }
        public int stock { set { Stock = value; } get { return Stock; } }
        public double precio { set { Precio = value; } get { return Precio; } }

        public static void ImprimirMedicamento(Medicamento m)
        {
            Console.WriteLine($"Medicamento: {m.nombre }\nDroga: {m.droga}\nPresentacion: {m.presentacion}\nLaboratorio: {m.laboratorio}\nStock: {m.stock}\nPrecio: {m.precio}");
            
        }
       
    }
}
