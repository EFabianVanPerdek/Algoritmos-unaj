using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoDeCines
{
    public class ComplejoCine
    {
        protected string Nombre;
        public static List<Sala> Salas;
        public static List<Pelicula> Peliculas;

        public ComplejoCine(string nombre)
        {
            this.Nombre = nombre;
            Salas = new List<Sala>();
            Peliculas = new List<Pelicula>();
        }
        public string nombre { set { Nombre = value; } get { return Nombre; } }
        public static void AgregarSala(Sala x)
        {
            Salas.Add(x);
            Console.WriteLine($"Sala {x.numero} agregada correctamente");
        }
        public static void EliminarSala()
        {
            Console.WriteLine("a continuacion daremos de baja una sala");
            Console.WriteLine("estas son las salas:");
            int cont = 1;
            foreach(Sala x in Salas)
            {
                Console.WriteLine($"{cont}-Sala: {x.numero} Capacidad: {x.capacidad}");
                cont += 1;
            }
            Console.WriteLine("elija el numero de la sala que desea borrar:");
            int respuesta = int.Parse(Console.ReadLine());
            int indiceAEliminar = -1;

            // Recorrer la lista y buscar el índice de la sala con el número dado
            for (int i = 0; i < Salas.Count; i++)
            {
                if (Salas[i].numero == respuesta)
                {
                    indiceAEliminar = i;
                    break; // Salir del bucle una vez que encontramos la sala
                }
            }

            // Si se encontró la sala, eliminarla
            if (indiceAEliminar != -1)
            {
                Salas.RemoveAt(indiceAEliminar);
                Console.WriteLine("Sala eliminada.");
            }
            else
            {
                Console.WriteLine("No se encontró ninguna sala con ese número.");
            }
        }
        
    }
}
