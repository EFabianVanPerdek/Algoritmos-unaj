using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sistema
{
    public class Producto
    {
        private string nombre;
        private string descripcion;
        private double precio; 
        private int stock;

        ArrayList productos = new ArrayList();

       public Producto(string nom, string desc, double prec, int stoc)
        {
            this.nombre = nom;
            this.descripcion = desc;
            this.precio = prec;
            this.stock = stoc;
        }
        public Producto(string nom, double prec, int stoc) 
        {
            this.nombre = nom;
            this.precio = prec;
            this.stock = stoc;
        }

    public void AgregarProductos(Producto nuevo) 
    { Console.WriteLine("agregamos un producto");
            productos.Add(nuevo);
            for (int i = 0; i < productos.Count; i++) { Console.WriteLine(productos[i]); ; }
    }
    public void AplicarDescuento()
    {
    Console.WriteLine("aplicamos descuento");
    }
    }
}


