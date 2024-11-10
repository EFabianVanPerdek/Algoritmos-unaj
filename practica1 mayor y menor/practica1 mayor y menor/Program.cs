using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_mayor_y_menor
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cant=0;
            double suma=0, promedio, resultado;
            double max=0;
            double min;
            Console.WriteLine("esta leyendo bien");
            Console.WriteLine("calculo mayor, menor y promedio del siguiente conjunto");
            Console.WriteLine("ingrese un numero o cero para finalizar");
            double numero = double.Parse(Console.ReadLine());
            min = numero;
            while (numero != 0)
            {
                Console.WriteLine($"el primer numero ingresado fue {numero}");
                cant += 1;//contador
                Console.WriteLine($"el contador va {cant}");
                suma += numero;//almaceno el numero ingresado en otra variable
                if (numero > max) { max = numero; }
                if (numero < min) { min = numero; }
                numero = double.Parse(Console.ReadLine());//ingreso nuevamente el valor por teclado                
                //cant++;
                //Console.WriteLine($"el contador va {cant}");
                resultado = suma + numero;
                Console.WriteLine($"el total va {resultado}");
                if (numero == 0)
                {
                    
                  promedio = resultado / cant;
                    Console.WriteLine($"De este conjunto el numero mayor ingresado es {max} y el numero menor es {min}");
                  Console.WriteLine($"el promedio de los numeros ingresados es {promedio}");
                }
            }

            Console.ReadKey();
        }
        
    }
}
