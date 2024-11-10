using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    class Obra_de_teatro:Espectaculo
    {
        private string Genero;
        private string Autor;
        private string Director;
        public Obra_de_teatro(string nombre, string genero, string autor, string director):base(nombre)
        {
            this.Genero=genero;
            this.Autor = autor;
            this.Director = director;
        }
        public override void ImprimirDatos()
        {
            Console.WriteLine($"Espectaculo {Nombre} \nGenero: {Genero}\nAutor: {Autor}\nDirector: {Director} ");
        }
    }
}
