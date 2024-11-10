using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sistema
{
    class Program
    {
        static void Main()
        {
            Producto nuevo = new Producto("hojas", "hojas para usar", 234, 10);
            Producto nuevo1 = new Producto("hojitas",345, 50);
            nuevo.AgregarProductos(nuevo);
            nuevo1.AplicarDescuento();
            Console.ReadKey(true);
        }
    }
}
