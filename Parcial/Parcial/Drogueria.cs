using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
 
    public class Drogueria
    {
        private string Nombre;
        public static List<Medicamento> Medicamentos;
        public static List<Pedido> Pedidos;

        public Drogueria(string nombre)
        {
            this.Nombre = nombre;
            Medicamentos = new List<Medicamento>();
            Pedidos = new List<Pedido>();
        }
        public string nombre { set{ Nombre = value; }get{ return Nombre; } }

        public static void AddMedicamento(Medicamento algo)
        {
            Console.WriteLine($"Carga del medicamento ");
            Medicamentos.Add(algo);
            Console.WriteLine("medicamento cargado satisfactoriamente");
        }
        public static void AddPedido(Pedido x)
        {
            Console.WriteLine($"Carga del medicamento {x.nombre}");
            Pedidos.Add(x);
            Console.WriteLine("medicamento cargado satisfactoriamente");
        }
        public static void DelMedicamento()
        {
            Console.WriteLine("elegir un medicamente de la lista a borrar:");
            Medicamento borrar;
            string seleccion;
            string condicion;
            do
            {foreach(Medicamento i in Medicamentos)
                {
                    Console.WriteLine($"Medicamento: {i.nombre}");    
                }
             seleccion = Console.ReadLine();
            foreach(Medicamento m in Medicamentos)
                {
                    if(m.nombre==seleccion.ToLower())
                    {
                        borrar = m;
                        Medicamentos.Remove(borrar);
                        Console.WriteLine("medicamento borrado exitosamente");
                        break;
                    }
                    else { Console.WriteLine("no se encontro el medicamento"); }
                }
                Console.WriteLine("desea borrar otro elemento: si/no");
                condicion = Console.ReadLine();
            } while (condicion == "si");
            foreach(Medicamento i in Medicamentos)
            {
                if (Medicamentos.Count == 0) { Console.WriteLine("lista vacia");break; }
            }
            Console.ReadKey();
        }
        public static void DelPedido()
        {
            Console.WriteLine("elegir un medicamente de la lista a borrar:");
            string borrar;
            string seleccion;
            string condicion;
            do
            {
                foreach (Pedido p in Pedidos)
                {
                    Console.WriteLine($"Nombre pedido: {p.nombre}");
                }
                seleccion = Console.ReadLine();
                foreach (Pedido m in Pedidos)
                {
                    if (m.nombre == seleccion.ToLower())
                    {
                        borrar = m.nombre;
                        Pedidos.Remove(m);
                        Console.WriteLine("pedido borrado exitosamente");
                        break;
                    }
                    else { Console.WriteLine("no se encontro el medicamento"); }
                }
                Console.WriteLine("desea borrar otro elemento: si/no");
                condicion = Console.ReadLine();
            } while (condicion == "si");
     
            Console.ReadKey();
        }
        public static void Ordenarxprecio(ref List<Medicamento> M)
        {
            int n = M.Count;
            for(int i=0; i<(M.Count-1);i++)
            {
                for(int j=i+1;j<n; j++)
                {
                    if(M[i].precio>M[j].precio)
                    {
                        double temp = M[i].precio;
                        M[i].precio = M[j].precio;
                        M[j].precio = temp;
                    }
                }
                Console.WriteLine("imprimo la lista ordenada");
                foreach (Medicamento m in Medicamentos) { Console.WriteLine($" Medicamento {m.nombre} Precio {m.precio}\n"); }
                
            }
        }
    }
}
