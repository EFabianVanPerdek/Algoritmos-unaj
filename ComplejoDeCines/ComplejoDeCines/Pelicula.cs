using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoDeCines
{
    public class Pelicula
    {
        private string Titulo;
        private string Genero;
        private string Horario;
        private double Precio;
        protected Sala Num;//no se hace set ni get

    public Pelicula(string titulo, string genero, string horario, double precio, Sala num)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Horario = horario;
            this.Precio = precio;
            this.Num = num;
        }
        public string titulo { set{ Titulo = titulo; } get{ return Titulo; } }
        public string genero { set { Genero = value; } get { return Genero; } }
        public string horario { set { Horario = value; } get { return Horario; } }
        public double precio { set{ Precio = value; }get{ return Precio; } }
        public Sala num { set { Num = value; }get{ return Num; } }
        public static void AddPeliculas(Pelicula x)
        {
            Console.WriteLine($"agregaremos la pelicula {x.Titulo}");
            ComplejoCine.Peliculas.Add(x);
            Console.WriteLine("pelicula agregada correctamente");
            
        }
    }
}
