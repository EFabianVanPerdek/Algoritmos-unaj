using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Autor
    {
        protected string Nombre;
        protected string Apellido{ get; set; }
        public static List<Autor> autores;

    public Autor(string nombre, string apellido) 
        {
            Nombre = nombre;
            Apellido = apellido;
            autores = new List<Autor>();
        }
        public string nombre 
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
    public string GetInformacion() //falta completar el metodo
        {
            return $"{Nombre}{Apellido}";
        }
    }
    

}
