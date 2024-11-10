using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_bucle_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 40; i <= 352; i++)
            { if (i%2!=0 && i % 3 == 0)
                { Console.WriteLine(i); } 
            }
            Console.ReadKey();
        }
    }
}
