namespace SalonDeEventos
{
    public class Empleado
    {
        //atributos
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected int legajo;
        protected double sueldo;
        protected string tarea;

        //constructor
        public Empleado(string nombre, string apellido, int dni, int legajo, double sueldo, string tarea)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.legajo = legajo;
            this.sueldo = sueldo;
            this.tarea = tarea;
        }

        public Empleado() { 
        }
        //properties
        
        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }
        
        public string Apellido
        {
            set
            {
                apellido = value;
            }

            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            set
            {
                dni = value;
            }

            get
            {
                return dni;
            }
        }

        public int Legajo
        {
            set
            {
                legajo = value;
            }

            get
            {
                return legajo;
            }
        }

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public string Tarea
        {
            set
            {
                tarea = value;
            }
            get
            {
                return tarea;
            }
        }
    }
}
