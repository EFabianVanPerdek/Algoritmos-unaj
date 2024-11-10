namespace SalonDeEventos
{
    public class Servicio
    {
        //atributos
        private string nombre;
        private string tipo;
        private string descripcion;
        private int cantidadSolicitada;
        private int precio;
        private int costoFinal;

        //constructor
        public Servicio(string nombre, string tipo, string descripcion, int cantidadSolicitada, int precio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.cantidadSolicitada = cantidadSolicitada;
            this.precio = precio;
            this.costoFinal = precio * cantidadSolicitada;
        }

        //properties

        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get { return nombre; }

        }
        
        public string Tipo
        {
            set {tipo = value; } 
            
            get { return tipo; }
        }

        public string Descripcion
        {
        	set {descripcion = value;}
            get { return descripcion;}
        }
        
        public int CantidadSolicitada
        {
            set
            {
                cantidadSolicitada = value;
            }

            get
            {
                return cantidadSolicitada;
            }
        }

        public int Precio
        {
            set { precio = value; }

            get { return precio; }
        }

        public int CostoFinal 
        {
            set { costoFinal = value; }
            get { return costoFinal; }
        }
    }
}
