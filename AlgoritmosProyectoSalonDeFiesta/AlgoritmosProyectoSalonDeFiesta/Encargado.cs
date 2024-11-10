using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
    public class Encargado : Empleado
    {   //Atributos
        protected int PlusPorEvento;

        // Constructor
        public Encargado(string nombreApellido, string dni, int legajo, double sueldo, string tarea, int plusPorEvento)
            : base(nombreApellido, dni, legajo, sueldo, tarea)
        {
            PlusPorEvento = plusPorEvento;
        }
        //Propiedades
        public int plus { set{ PlusPorEvento = value; }get{ return PlusPorEvento; } }

        // Sobrecarga del método ToString() para mostrar la información del encargado
        public override string ToString()
        {
            return base.ToString() + $"\nPlus por evento: {PlusPorEvento:C2}";
        }
    }
}
