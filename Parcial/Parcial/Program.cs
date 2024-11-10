using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class StockInsufucienteException : Exception
    {
        public string Motivo;
        public StockInsufucienteException(string motivo) { this.Motivo = motivo; }
    }
    public class Program
    {
        static void Main()
        {
            Drogueria Nueva = new Drogueria("BETAFARM");
            Medicamento m1 = new Medicamento("ibuprofeno","ibu", "comprimidos", "bago", 10, 500);
            Medicamento m2 = new Medicamento("diclofenac", "diclo", "comprimidos", "bago", 20, 1400);
            Medicamento m3 = new Medicamento("paracetamol", "para", "comprimidos", "bago", 15, 1000);
            Medicamento m4 = new Medicamento("dipirona", "dipi", "comprimidos", "bago", 20, 1200);
            Medicamento m5 = new Medicamento("omeprazol", "ome", "capsula", "bago", 30, 300);
            Medicamento m6 = new Medicamento("betametasona", "beta", "crema", "bago", 15, 700);
            Medicamento m7 = new Medicamento("alplax", "al", "blister", "bago", 20, 550);
            Medicamento m8 = new Medicamento("Vaselina liquida", "vaselina", "frasco", "bago", 15, 900);
            Medicamento m9 = new Medicamento("dexametasona", "dexa", "comprimidos", "bago", 30, 1300);
            Medicamento m10 = new Medicamento("pseudoefedrina", "pseudo", "comprimidos", "bago", 20, 100);
            Drogueria.AddMedicamento(m1);
            Drogueria.AddMedicamento(m2);
            Drogueria.AddMedicamento(m3);
            Drogueria.AddMedicamento(m4);
            Drogueria.AddMedicamento(m5);
            Drogueria.AddMedicamento(m6);
            Drogueria.AddMedicamento(m7);
            Drogueria.AddMedicamento(m8);
            Drogueria.AddMedicamento(m9);
            Drogueria.AddMedicamento(m10);
            Console.ReadKey();
            Console.Clear();
            recursion(Drogueria.Medicamentos, 0);
            Console.ReadKey();
            string continuacion;
            do {
                Console.WriteLine("carga de pedidos:\nmedicamentos disponible");
                foreach(Medicamento m in Drogueria.Medicamentos)
                {
                    Console.WriteLine($"Medicamento: {m.nombre }\nDroga: {m.droga}\nPresentacion: {m.presentacion}\nLaboratorio: {m.laboratorio}\nStock: {m.stock}\nPrecio: {m.precio}");
                }
                Console.WriteLine("ingrese nombre de la farmacia");
                string nombrefarmacia = Console.ReadLine();
                Console.WriteLine("ingrese cantidad:");
                int cantidad = int.Parse(Console.ReadLine());

                foreach(Medicamento m in Drogueria.Medicamentos)
                {
                    try { 
                    Console.WriteLine("Elegir el medicamento:");
                    string nombre = Console.ReadLine();
                    if (nombre == m.nombre)
                    {
                        string n = m.nombre;
                        string p = m.presentacion;
                        if(cantidad>m.stock)
                        {
                            Pedido p1 = new Pedido(n, p, nombrefarmacia, cantidad);
                            break;
                        }
                    }
                    else
                    { Console.WriteLine("nombre no encontrado"); break; }
                    }
                    catch (StockInsufucienteException)
                    {
                        throw new StockInsufucienteException("Stock insuficiente");
                    }
                    catch (Exception) { }
                    
                }
                Console.WriteLine("desea realizar otro pedido");
                continuacion = Console.ReadLine();
            } while (continuacion=="si");

            OrdenarBago(ref Drogueria.Medicamentos);

            Console.ReadKey();
        }
        public static void OrdenarBago(ref List<Medicamento> x)
        {
            int indicador = x.Count();
            foreach(Medicamento m in x)
            { if(m.laboratorio=="bago")
                {
                    for (int i = 0; i < (indicador - 1); i++)
                    {
                        for (int j = i + 1; j < indicador; j++)
                        {
                            if (x[i].precio > x[j].precio)
                            {
                                double temp = x[i].precio;
                                x[i].precio = x[j].precio;
                                x[j].precio = temp;
                            }
                        }
                    }
                }
            }
            foreach(Medicamento m in x)
            {
                if(m.laboratorio=="bago")
                {
                    Console.WriteLine($"Medicamento: {m.nombre } precio: {m.precio}");
                    
                }
            }

        }
        public static void recursion(List<Medicamento>x, int i)
        {
            if (i == x.Count()) { return; }
            if (x[i].precio > 700) { Console.WriteLine(x[i].precio); }
            recursion(x, i + 1);
        }
    }
}
