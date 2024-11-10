using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmorecursivo
{
    public class Profesor
    {
        protected string Nombre;
        protected int Dni;
        protected int Legajo;
        protected string Materia;

        public Profesor(string nombre, int dni, int legajo, string materia)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Legajo = legajo;
            this.Materia = materia;
        }
        public string nombre { set{ Nombre = value; }get{ return Nombre; } }
        public int dni { set { Dni = value; } get { return Dni; } }
        public int legajo { set { Legajo = value; } get { return Legajo; } }
        public string materia { set { Materia = value; } get { return Materia; } }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Profesor: {Nombre} Dni: {dni } Legajo: {legajo} Materia: {materia}");
        }
    }
  
}
