using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
    public class Empleado
    {   //Atributos
        private string NombreApellido;
        private string DNI;
        private int Legajo;
        private double Sueldo;
        private string Tarea;

        // Constructor
        public Empleado(string nombreApellido, string dni, int legajo, double sueldo, string tarea)
        {
            NombreApellido = nombreApellido;
            DNI = dni;
            Legajo = legajo;
            Sueldo = sueldo;
            Tarea = tarea;
        }
        //Propiedades
        public string nombreyapellido {set{ NombreApellido = value; }get{ return NombreApellido; } }
        public string dni { set { DNI = value; } get { return DNI; } }
        public int legajo { set { Legajo = value; } get { return Legajo; } }
        public double sueldo { set { Sueldo = value; } get { return Sueldo; } }
        public string tarea { set { Tarea = value; } get { return Tarea; } }

        // Sobrecarga del método ToString() para mostrar la información del empleado
        public override string ToString()
        {
            return $"Nombre y apellido: {NombreApellido}\n" +
                   $"DNI: {DNI}\n" +
                   $"Legajo: {Legajo}\n" +
                   $"Sueldo: {Sueldo:C2}\n" +
                   $"Tarea: {Tarea}";
        }
    }
}
