using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de mes");
            Console.WriteLine("por favor ingrese a continuacion el mes del 1 al 12 para informar a cual corresponde");
            short mes = short.Parse(Console.ReadLine());
            Console.WriteLine(DimeElmes(mes)); 
            Console.WriteLine("el flujo siguio su curso");
            Console.ReadKey();

        }
        static string DimeElmes(short mes)
        {
            switch (mes)
            {
                case 1:
                    return "El mes corresponde a Enero";
                case 2:
                    return "El mes corresponde a Febrero";
                case 3:
                    return "El mes corresponde a Marzo";
                case 4:
                    return "El mes corresponde a Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "mes invalido";

            }
            
        }
    }
}
