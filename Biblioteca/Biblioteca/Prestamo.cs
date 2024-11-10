using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestamo
    {
        protected Libro Libro;
        protected DateTime Fechaprestamo;
        protected DateTime? Fechadevolucion;//se le agrega el signo? por que no esta definida la fecha de devolucion y por lo tanto devuelve null
        //constructor
        public static List<Prestamo> prestamos;
        public Prestamo(Libro libro, DateTime FEprestamo) 
        {
            this.Libro = libro;
            this.Fechaprestamo = FEprestamo;
            prestamos = new List<Prestamo>();
        }
        //getters and setters
        public Libro libro 
        {
            set { Libro = value; }
            get { return Libro; }
        }
        public DateTime fechaprestamo
        {
            set { Fechaprestamo = value; }
            get { return Fechaprestamo; }
        }
        public DateTime fechadevolucion
        {
            set { Fechadevolucion = value; }
            get { return (DateTime)Fechadevolucion; }//se agrega conversion
        }
        //metodos
        public void DevolverLibro()
        {
            Fechadevolucion = DateTime.Now;
            Libro.Devolver();
            Console.WriteLine($"Libro {Libro.Titulo} esta devuelto ");
        
        }
    }
}
