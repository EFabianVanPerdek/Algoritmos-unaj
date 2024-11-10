using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmorecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            List<int> Notas = new List<int>();
            do {
                Console.WriteLine("carga de notas:");
                int valor = int.Parse(Console.ReadLine());
                Notas.Add(valor);
                Console.WriteLine("nota cargada\ndesea agregar si o no");
                respuesta = Console.ReadLine();
            } while (respuesta=="si");
            Recursivo(Notas,0);
            Console.ReadKey();
        }
        public static void Recursivo(List<int> N, int indice)
        {
            if(indice==N.Count)
            { return; }

                if(N[indice]>7.5)
                {
                    Console.WriteLine($" Nota mayor a 7.5: {N[indice] }");
                }

            Recursivo(N, indice + 1);
        }
    }
}
