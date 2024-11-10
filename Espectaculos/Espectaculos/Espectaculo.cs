using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class Espectaculo
    {
        protected string Nombre;
        public static List<Butaca> Butacas;

        public Espectaculo(string nombre)
            {this.Nombre=nombre;
            Butacas = new List<Butaca>();
            }
        public string nombre { set { Nombre = value; } get { return Nombre; } }
        public static void Addbutaca(Butaca x) { Console.WriteLine("vamos a cargar la butaca..."); Butacas.Add(x); Console.WriteLine("butacas agregadas"); }
        public static void Delbutaca(int butaca)
        {
            Console.WriteLine($"vamos a borrar la butaca numero {butaca}");

            foreach (Butaca x in Butacas)
            {
                Console.WriteLine("a continuacion borraremos la butaca");
                if (Butacas.Count() == 0) { Console.WriteLine("lista vacia"); }
                else if (butaca == x.numero)
                { 
                    Butacas.RemoveAt(butaca);
                    Console.WriteLine("BUTACA ELIMINADA");
                }
                else {Console.WriteLine("no se encontro o no esta disponible esa butaca"); }
            }
            
        }
        public static void OcuparButaca(int NroButaca)
        {   
            foreach(Butaca x in Butacas)
            {
                if (x.numero == NroButaca)
                {
                    Console.WriteLine("butaca encontrada, espere un momento...");
                    if (x.estado=="disponible")
                    {
                        x.estado=x.estado.Replace("disponible", "ocupada");
                        Console.WriteLine("butaca ocupada");
                    }
                    else 
                    {
                        Console.WriteLine("butaca no disponible");
                    }
                }
            }
        }
        public static void OrdenXprecio(ref List<Butaca>butacas)
        {
            int n = butacas.Count;
                for(int i=0; i<(n-1);i++)
                {
                    for(int j=i+1;j<n;j++)
                    {
                        if(butacas[i].precio>butacas[j].precio)
                        {
                            float temp = butacas[i].precio;
                            butacas[i].precio = butacas[j].precio;
                            butacas[j].precio = temp;
                        }
                    }
                }
            Console.WriteLine("butacas ordenada");
        }
        public static void AumentaPrecio(float precio)
        {
            string tipobutaca;
            string continuar;
            do {
                Console.WriteLine("a continuacion se modificara el precio del tipo de butaca, elija el tipo de butaca que desea modificar:");
                Console.WriteLine("a=bandeja\nb=platea\nc=pullman\nd=palco");
                tipobutaca = Console.ReadLine().ToLower();
                try { 
                switch(tipobutaca)
                {
                    case "a":
                        {   foreach(Butaca x in Butacas)
                            {
                                if(x.tipo=="bandeja")
                                {
                                    x.precio = precio;
                                    Console.WriteLine("precio modificado");
                                }
                            }
                            break;
                        }
                    case "b":
                        {
                            foreach (Butaca x in Butacas)
                            {
                                if (x.tipo == "platea")
                                {
                                    x.precio = precio;
                                    Console.WriteLine("precio modificado");
                                }
                            }
                            break;
                        }
                    case "c":
                        {
                            foreach (Butaca x in Butacas)
                            {
                                if (x.tipo == "pullman")
                                {
                                    x.precio = precio;
                                    Console.WriteLine("precio modificado");
                                }
                            }
                            break;
                        }
                    case "d":
                        {
                            foreach (Butaca x in Butacas)
                            {
                                if (x.tipo == "palco")
                                {
                                    x.precio = precio;
                                    Console.WriteLine("precio modificado");
                                }
                            }
                            break;
                        }
                     default:
                            {
                                Console.WriteLine("Respuesta invalida,intente nuevamente");
                                break;
                            }
                    }
                }
                catch(FormatException)
                { Console.WriteLine("Error: Debe ingresar un número entero válido."); }
                continuar =Console.ReadLine();
            } while (continuar.ToLower()=="si");
        }
        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Espectaculo: {Nombre}");         
        }
    }

}


