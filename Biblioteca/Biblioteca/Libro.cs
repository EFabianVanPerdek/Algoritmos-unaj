using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        private Autor autor { get; set; }
        private string Isbn { get; set; }
        public bool Disponible { get; set; }
        public static List<Libro> libros;

        public Libro(string titulo, Autor autors, string isbn)
            {
            this.Titulo = titulo;
            this.autor = autors;
            this.Isbn = isbn;
            Disponible = true;
            libros = new List<Libro>();
            }
        //falta metodo prestar y devolver
        public void Prestar() 
        {
            if(Disponible==true)
            {
                Console.WriteLine($"el libro {Titulo} esta prestado");
                Disponible = false;
            }
            else
            {
                Console.WriteLine($"el libro {Titulo} no esta disponible");
            }
        }
        public void Devolver()
        {
            if (Disponible == false)
            {
                Console.WriteLine($"el libro {Titulo} esta devuelto");
                Disponible = true;
            }
            else
            {
                Console.WriteLine($"el libro {Titulo} ya esta disponible");
            }
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {autor.GetInformacion()}");
            Console.WriteLine($"Isbn: {Isbn}");
            Console.WriteLine($"Disponibilidad: {Disponible}");
        }

    }
}
