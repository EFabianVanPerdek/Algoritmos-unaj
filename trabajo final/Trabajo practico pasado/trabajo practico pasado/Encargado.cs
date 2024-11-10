using System;

namespace SalonDeEventos
{
    public class Encargado: Empleado
    {
        //atributos --> plussueldo es un porcentaje de aumento sobre el sueldo inicial del empleado
        private double plusSueldo;
        private string eventoEncargado;

        //constructores -- Uno con el atributo asignado y otro sin asignar para asignar en un futuro

        public Encargado(string nombre, string apellido, int dni, int legajo, double sueldo, string tarea, int plusSueldo) : base(nombre, apellido, dni, legajo, sueldo, tarea)
        {
            this.plusSueldo = plusSueldo;
            this.Plus(plusSueldo);
        }

        public Encargado(string nombre, string apellido, int dni, int legajo, double sueldo, string tarea) : base(nombre, apellido, dni, legajo, sueldo, tarea)
        {

        }
        
        public Encargado()
        {

        }
        
        //metodos -- Plus --> asigna un porcentaje del salario como elpleado al plus de sueldo que sumado al salario original será el nuevo valor del sueldo. Si el procentaje es mayor a 0 se realiza y sino se cancela la operacion.
        public bool Plus(double porcentaje) { 
        	if (porcentaje > 0)
            {
        		double r = (sueldo / 100) * porcentaje; 
        		sueldo = r; 
        		return true;
        	} 
        	Console.WriteLine("Porcentaje menor a 0, no se ha asignado el aumento."); 
        	return false; 
        }
        
        //properties

        public string EventoEncargado
        {   
            set {eventoEncargado = value; }
        	get {return eventoEncargado; }
        }
    }
}
