using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Program
    {
        public  void Main()
        {
            Console.WriteLine("-------------Biblioteca-----------");
            bool continuar = true;
            while (continuar==true)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Registrar autor");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Mostrar información de un libro");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarLibro();
                        break;
                    case 2:
                        RegistrarAutor();
                        break;
                    case 3:
                        PrestarLibro();
                        break;
                    case 4:
                        DevolverLibro();
                        break;
                    case 5:
                        MostrarInfoLibro();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            Console.ReadKey();
        }
        public void RegistrarLibro()
        {
            string titulo, isbn, nombreautor, apellidoautor;
            Console.WriteLine("como se llama la obra:");
            titulo = Console.ReadLine();
            Console.WriteLine("ingrese isbn");
            isbn = Console.ReadLine();
            Console.WriteLine("ingresar el nombre del autor");
            nombreautor = Console.ReadLine();
            Console.WriteLine("ingresar el apellido del autor");
            apellidoautor = Console.ReadLine();
            Autor autornuevo = new Autor(nombreautor, apellidoautor);
            Autor.autores.Add(autornuevo);
            Libro libronuevo = new Libro(titulo, autornuevo, isbn);
            Libro.libros.Add(libronuevo);
            Console.WriteLine("libro registrado");
            
        }
        static void RegistrarAutor() { }
        static void PrestarLibro()
        {
            Console.WriteLine("Libros disponible:");
            for(int i=0; i<Libro.libros.Count();i++)
            {
                if (Libro.libros[i].Disponible) 
                {
                    Console.WriteLine($"{i+1} . {Libro.libros[i].Titulo}");
                }         
            }
            Console.WriteLine("ingreseel numero q desea prestar:");
            int indicelibro = int.Parse(Console.ReadLine()) -1;
            Libro libro = Libro.libros[indicelibro];

            libro.Prestar();
            Prestamo.prestamos.Add(new Prestamo(libro, DateTime.Now));
        }
        static void DevolverLibro()
        {
            Console.WriteLine("\nLibros prestados:");
            for (int i = 0; i < Prestamo.prestamos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Prestamo.prestamos[i].libro.Titulo}");
            }

            Console.Write("Ingrese el número del libro a devolver: ");
            int prestamoIndice = int.Parse(Console.ReadLine()) - 1;
            Prestamo prestamo = Prestamo.prestamos[prestamoIndice];

            prestamo.DevolverLibro();
        }
        static void MostrarInfoLibro()
        {
            Console.WriteLine("Libros registrados:");
            for(int i=0; i <Libro.libros.Count();i++)
            {
                Console.WriteLine($"{i+1} . {Libro.libros[i].Titulo}");
            }
            Console.WriteLine("ingrese numero del libro");
            int indicelibro = int.Parse(Console.ReadLine());
            Libro libro = Libro.libros[indicelibro];
            libro.MostrarInfo();
        }
    }
}
