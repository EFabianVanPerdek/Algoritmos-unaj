using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos_Deportivos
{
    public class Entrenador:Persona
    {
        public static List<Atleta> atletas;

        public Entrenador(string Nombre, int Edad):base(Nombre,Edad)
        {
        }
        public static void AgregarAtletas(Atleta atleta)
        {
            Console.WriteLine($"Vamos a agregar al atleta");
            Atleta.MostrarInfoAtleta(atleta);
            atletas.Add(atleta);
            Console.WriteLine("atleta agregado");
        }
        public void MostrarInfoEntrenador(Entrenador entrenador)
        {
            Console.WriteLine($"Entrenador: {entrenador.Nombre} \nEdad: {entrenador.Edad} \n Atletas que entrena:");
        }
    }
}
