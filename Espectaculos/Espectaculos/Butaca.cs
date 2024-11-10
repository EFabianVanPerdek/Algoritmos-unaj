using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class Butaca
    {
        private int Numero;
        private float Precio;
        private string Tipo;
        private string Estado;

        public Butaca(int numero, float precio, string tipo, string estado)
        {
            this.Numero = numero;
            this.Precio = precio;
            this.Tipo = tipo;
            this.Estado = estado;
        }
        public int numero { set { Numero = value; } get { return Numero; } }
        public float precio { set { Precio = value; } get { return Precio;  } }
        public string tipo { set { Tipo = value; } get { return Tipo; } }
        public string estado { set { Estado = value; } get { return Estado; } }

        public static void ImprimirButacas(List<Butaca>butacas)
        {
            Console.WriteLine("vamos a imprimir la lista de butacas: ");
            foreach (Butaca x in butacas)
            {
                if (butacas.Count() == 0) { Console.WriteLine("la lista esta vacía"); break; }
                else 
                {
                    Console.WriteLine($"Butaca numero {x.numero}\nButaca precio {x.precio}\nButaca tipo{x.tipo}\nButaca estado{x.estado}");                    
                }
            }
        }

    }
}
