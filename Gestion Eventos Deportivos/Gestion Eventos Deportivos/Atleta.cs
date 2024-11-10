using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos_Deportivos
{
    public class Atleta:Persona
    {
        protected string DisciplinaDeportiva { get; set; }
        protected int Ranking;
        public Atleta(string nombre, int edad,string disciplina, int ranking):base(nombre, edad)
            {
                this.DisciplinaDeportiva=disciplina;
                this.Ranking=ranking;
            }
        public string disciplina
        {
            set { DisciplinaDeportiva = value; }
            get { return DisciplinaDeportiva; }
        }
        public int ranking
        {
        set{Ranking=value;}
        get{ return Ranking; }        
        }
        public static void MostrarInfoAtleta(Atleta atleta)
        {
            Console.WriteLine($"Atleta: {atleta.Nombre} \nEdad: {atleta.Edad} \nDisciplina deportiva: {atleta.DisciplinaDeportiva} \nRanking: {atleta.Ranking}");
        }
    }
}
