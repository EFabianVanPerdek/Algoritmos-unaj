using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos_Deportivos
{
    public class Evento
    {
        protected string Nombre;
        protected string FechaEvento;
        public static List<Persona> personas;

        public Evento(string nombre, string fechaevento)
        { this.Nombre = nombre;this.FechaEvento = fechaevento;
            personas = new List<Persona>();
        }
        public string nombre 
        { 
            set { Nombre = value; } get { return Nombre; } 
        }
        public string fechaEvento 
        {
            set { FechaEvento = value; }
            get { return FechaEvento; }
        }
        public void AgregarParticipantes(Persona persona) 
        {
            Console.WriteLine($"Vamos a agregar el participante creado");
            personas.Add(persona);
            Console.WriteLine("persona agregada");
            
        }
        public void MostrarInfoEvento(Evento evento)
        {
            Console.WriteLine("Informacion evento");
            Console.WriteLine($"Evento {evento.Nombre}  Fecha: {evento.FechaEvento}");
            Console.WriteLine("Participantes");
            for(int i=0;i<personas.Count();i++ )
            {
                Console.WriteLine($"Participante {personas[i]}");
                i++;
            }

        }
    }
}
