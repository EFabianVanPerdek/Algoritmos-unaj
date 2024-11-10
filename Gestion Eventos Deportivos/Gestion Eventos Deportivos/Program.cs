using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos_Deportivos
{
    class Program
    {
        static void Main()
        {
            Evento nuevo = new Evento("evento fortaleza", "14/01/2025");
            nuevo.MostrarInfoEvento(nuevo);
            Atleta nuevoatleta = new Atleta("Jorge",25, "running", 5);
            Entrenador nuevoentrenador = new Entrenador("Fabian", 32);
            Entrenador.AgregarAtletas(nuevoatleta);
            Console.ReadKey();
        }
    }
}
