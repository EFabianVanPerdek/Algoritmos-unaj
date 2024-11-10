using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
{
        public class Encargado : Empleado
        {   //Atributos
            protected int PlusPorEvento;

            // Constructor con .base para heredar los atributos de la clase empleado
            public Encargado(string nombreApellido, int dni, int legajo, double sueldo, string tarea, int plusPorEvento)
                : base(nombreApellido, dni, legajo, sueldo, tarea)
            {
                PlusPorEvento = plusPorEvento;
            }
            //Propiedades
            public int plus { set { PlusPorEvento = value; } get { return PlusPorEvento; } }

             // Sobrecarga del metodo ToString() para mostrar la información del encargado, conviertiendo los datos del objeto en string
             public override string ToString()
            {
                return base.ToString() + $"\nPlus por evento: $ {PlusPorEvento}";
            }
        }
}
