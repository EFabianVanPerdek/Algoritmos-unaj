using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    class Program
    {
        static void Main()
        {

            Espectaculo nuevo = new Espectaculo("El fantasma de la opera");

            Butaca a1 = new Butaca(1,700,"bandeja","disponible");
            Butaca a2= new Butaca(2, 700, "bandeja", "disponible");
            Butaca a3 = new Butaca(3, 2000, "pullman", "disponible");
            Butaca a4 = new Butaca(4, 2000, "pullman", "disponible");
            Butaca a5 = new Butaca(5, 2000, "pullman", "disponible");
            Butaca a6 = new Butaca(6, 5000, "platea", "disponible");
            Butaca a7 = new Butaca(7, 5000, "platea", "disponible");
            Butaca a8 = new Butaca(8, 6500, "palco", "disponible");
            Butaca a9 = new Butaca(9, 6500, "palco", "disponible");
            Butaca a10 = new Butaca(10, 6500, "palco", "disponible");
            Espectaculo.Addbutaca(a1);
            Espectaculo.Addbutaca(a9);
            Espectaculo.Addbutaca(a7);
            Espectaculo.Addbutaca(a3);
            Espectaculo.Addbutaca(a5);
            Espectaculo.Addbutaca(a6);
            Espectaculo.Addbutaca(a8);
            Espectaculo.Addbutaca(a4);
            Espectaculo.Addbutaca(a2);
            Espectaculo.Addbutaca(a10);
            Console.WriteLine("llegamos a agregar todaas las butacas");
            Espectaculo.OcuparButaca(2);
            Espectaculo.OrdenXprecio(ref Espectaculo.Butacas);
            Espectaculo.AumentaPrecio(5750);
            Butaca.ImprimirButacas(Espectaculo.Butacas);
            Console.WriteLine("desea hacer el metodo recursivo");
            string continuar = Console.ReadLine();
            if(continuar.ToLower()=="si")
            { Console.Clear(); recursion(Espectaculo.Butacas, 0); }
            else { Console.Clear(); Console.WriteLine("adios"); ; }
            //Espectaculo.Delbutaca(2);
            Console.ReadKey();
        }
        public static void recursion(List<Butaca>butacas, int indice)
        {
            if (indice == butacas.Count) { return; }
            if(butacas[indice].precio >2500)
            {
                Console.WriteLine($"butaca numero:{butacas[indice].numero} butaca precio:{butacas[indice].precio}");      
            }
            recursion(butacas, indice + 1);
        }
    }
}
