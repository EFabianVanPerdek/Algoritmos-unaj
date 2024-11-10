using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos_Deportivos
{
    public class Persona
    {
        protected string Nombre { get; set; }
        protected int Edad { get; set; }

        public static List<Persona> personas;
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            personas = new List<Persona>();
            
        }
        public void MostrarInfo()
        {
            Console.WriteLine("info persona");
            Console.WriteLine($"El nombre: {Nombre} Edad: {Edad}");
        }

    }
}
