using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRecursiva
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("-------RECURSION-------");
            Console.WriteLine("Elegir la opcion correcta:");
            Console.WriteLine("1-prueba naturales\n2-Inversion de cadena\n3-Contar digitos de un numero\n4-Potencia de un numero\n5-Encontrar el minimo em uma lista de enteros");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Numero:");
                        int sumar = int.Parse(Console.ReadLine());
                        Console.WriteLine(SumarNaturales(sumar));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("cadenas de texto:");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(InvertirCadena(cadena)); 
                        break; 
                    }
                case 3:
                    {
                        Console.WriteLine("contar digitos de un numero");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine(ContarDigitos(numero));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("potencia de un numero");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("exponente");
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine(PotenciaRecursiva(numero, e));
                        break;
                    }
                case 5: 
                    {
                        Console.WriteLine("Encontrar el Mínimo en una Lista de Enteros");
                        List<int> n = new List<int>(17);
                        n.Add(5);
                        n.Add(6);
                        n.Add(7);
                        n.Add(9);
                        n.Add(12);
                        n.Add(54);
                        n.Add(6);
                        n.Add(865);
                        n.Add(86);
                        n.Add(21);
                        n.Add(9);
                        Console.WriteLine(EncontrarMinimo(n));
                        break; 
                    }
            }
            Console.WriteLine("algo malio sal");
            Console.ReadKey();
        }
        public static int SumarNaturales(int n)
        {
            if (n == 1) { return 1; }//cuando llega a uno termina la recursion y vuelve para retornar
            else
            {
                return n + SumarNaturales(n - 1);//almacena el numero + elnumero -1
                //entonces seria n+4 n+3 n+2 n+1 y ahi vuelve
                //5+4 4+3 3+2 2+1 y ahi llega al caso base
                //despues vuelve de la siguiente forma:
                /*--------------------(10+5)=15
                 5+4----------(6+4)=10
                    4+3 -----=(3+3)=6
                      3+2 (1+2)=3             
                        2+1------ahi vuelve
                 */
            }
        }
        public static string InvertirCadena(string texto)
        {
            if (texto.Length <= 1) { return texto; }//si la longitud del texto es menor o igual a 1 retorno texto
            return InvertirCadena(texto.Substring(1)) + texto[0];//retorna guardando la primer letra de la cadena, y la va sumando con lo que queda la cadena en 0, 
            //por ejemplo Hola guarda H y despues guarda o,despues guarda la o y despues la l, y asi, cuando queda 1 sola retorna el texto pero al reves,por la reversion aloh
        }
        public static int ContarDigitos(int n)
        {
            if (n == 0) {return 0; }//Condición base: Si numero es igual a 0, se retorna 0, ya que no hay más dígitos que contar.

            return 1 + ContarDigitos(n / 10);
            /*Llamada recursiva: Dividimos numero entre 10 para eliminar su último dígito y sumamos 1 al resultado de ContarDigitos(numero / 10).
Al dividir numero por 10 en cada llamada, estamos eliminando el último dígito y contando uno más.
Flujo de ejecución: Si llamamos a ContarDigitos(12345), el proceso recursivo suma 1 en cada paso hasta que numero sea 0, acumulando el conteo total de 5 dígitos.*/
        }
        public static int PotenciaRecursiva(int n, int e)
        {
            if (e == 0) { return 1; }//Si exponente es igual a 0, se retorna 1, ya que cualquier número elevado a la potencia 0 es 1.
            return n * e + PotenciaRecursiva(n, e - 1);
        }
        public static int EncontrarMinimo(List<int> numeros)
        {
            if (numeros.Count == 1) return numeros[0];

            int primerElemento = numeros[0];
            int minimoDelResto = EncontrarMinimo(numeros.Skip(1).ToList());

            return Math.Min(primerElemento, minimoDelResto);
        }
        public static void recursion(List<int> numeros, int indice)
        {
            indice = numeros.Count();
            if (indice == 0) { return; }
            if (numeros[indice] > 12000 && numeros[indice] < 25000) { Console.WriteLine(numeros[indice]); }
            recursion(numeros, indice + 1);

        }

    }
}
