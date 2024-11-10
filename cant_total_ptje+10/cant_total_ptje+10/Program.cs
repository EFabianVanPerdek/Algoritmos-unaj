using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cant_total_ptje_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double porcentaje=0;
            double resultado = 0;
            int cant = 0;
            int cant2 = 0;
            double suma = 0;
            Console.WriteLine("programa de ingreso de numeros");
            Console.WriteLine("ingrese una serie de numeros y cuando quiera finalizar, ingrese 0");
            double numero = int.Parse(Console.ReadLine());
            while (numero != 0 )
            {
                cant += 1;
                Console.WriteLine($"la cantidad de numero es {cant}");
                if (numero >= 10)
                {
                    suma = numero;
                    porcentaje = suma + numero;
                    cant2 += 1;
                }
                numero = int.Parse(Console.ReadLine());
               
                if (numero ==0)
                    {
                    resultado = (porcentaje + suma) * cant / 100;
                    Console.WriteLine($" la cantidad total de numeros fue {cant}, mientras que la cantidad de mayores a 10 fue {cant2}");
                    Console.WriteLine($" el porcentaje de los valores ingresados mayor a 10 es : {resultado}");
                    }
            }
            Console.ReadKey();*/
            double contporc = 0;
            double numero;
            double cont = 0;
            Console.WriteLine("Inicializacion de contador de numeros");
            do
            {
                Console.WriteLine("Ingrese un numero a continuacion");
                numero = double.Parse(Console.ReadLine());
                if(numero != 0) 
                {
                    cont += 1;
                    if(numero >10) { contporc += 1; }
                }
            }
            while (numero != 0);
            Console.WriteLine($"la cantidad de numeros ingresados es {cont}");
            Console.WriteLine("el contador mayor a 10 es "+ contporc);
            Console.WriteLine($"el porcentaje de los numeros ingresados mayor a 10 es {(contporc/cont)*100}");
            Console.ReadKey();
        }
    }
}
