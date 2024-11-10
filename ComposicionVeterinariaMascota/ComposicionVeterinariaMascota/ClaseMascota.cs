using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionVeterinariaMascota
{
    public class ClaseMascota
    {
        /*Nombre, NombreDelDueño y Diagnostico son propiedades de los objetos de la clase Mascota y por lo tanto las entienden sus instancias.*/
            private string Nombre;
            private string NombreDueño;
            private string Diagnostico;
            private string Especie {set; get; }
            private int Edad { set; get; }

        public ClaseMascota(string nombre, string dueño,string Especie, int edad, string diagnostico)
        { this.Nombre = nombre;
          this.NombreDueño= dueño;
          this.Especie = Especie;
          this.Edad = edad;
          this.Diagnostico = diagnostico;
        }
        public ClaseMascota(string nombre, string dueño, string Especie, int edad)
        {
            this.Nombre = nombre;
            this.NombreDueño = dueño;
            this.Especie = Especie;
            this.Edad = edad;
        }
        public string nombremascota
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string dueño
        {
            set { NombreDueño = value; }
            get { return NombreDueño; }
        }
        public string diagnostico
        {
            set { Diagnostico = value; }
            get { return Diagnostico; }
        }
        public int edad
        {
            set { Edad = value; }
            get { return edad; }
        }

        public void Imprimir() { Console.WriteLine($"El nombre de la mascota es {Nombre } , su dueño se llama { NombreDueño}"); }
            // Sobrescribimos el método ToString para imprimir correctamente la información de la mascota
            public override string ToString()
            {
                return $"Mascota: {Nombre}, Nombre dueño: {NombreDueño}";
            }
        
    }
}
