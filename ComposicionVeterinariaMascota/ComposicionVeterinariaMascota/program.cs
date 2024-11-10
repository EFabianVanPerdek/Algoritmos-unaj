using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionVeterinariaMascota
{
    class Program
    {
        static void Main()
        {
            ClaseVeterinaria Veterinaria;
            string sigue;
            Veterinaria = new ClaseVeterinaria("Huesitos");/*creamos la veterinaria*/
            /*Al trabajar con objetos compuestos, se deben usar los distintos niveles de abstracción,
             * es decir, los métodos correspondientes a cada clase.*/
            Console.WriteLine("Desea cargar una mascota ? s / n");
            sigue = Console.ReadLine(); 
            while (sigue.ToLower() =="s") 
                {
                string nombre, nomdueño, especie; int edad; 
                Console.WriteLine("ingrese nombre, dueño, especie y edad de una mascota");
                nombre = Console.ReadLine(); 
                nomdueño = Console.ReadLine(); 
                especie = Console.ReadLine();
                edad = int.Parse(Console.ReadLine());
                ClaseMascota mas = new ClaseMascota(nombre, nomdueño, especie, edad);  /*se crea una mascota*/
                Veterinaria.AgregarMascotas(mas); /*se agrega a la veterinaria*/
                Console.WriteLine("ingresa otra mascota ?");
                sigue = Console.ReadLine();
                }
            int cant = 0;
            Console.WriteLine("hay mascota a atender ? s / n");
            sigue = Console.ReadLine();
            while (sigue.ToLower() =="s") 
                {
                Console.WriteLine("ingrese nombre de la mascota y del dueño");
                string nombre = Console.ReadLine();
                string nomdueño = Console.ReadLine();
                Console.WriteLine("ingrese diagnostico");
                string diag = Console.ReadLine();
                Veterinaria.AtenderMascotas(nombre,nomdueño,diag);/*atiende a una mascota*/
                cant += 1;/*cuenta la mascota atendida*/
                Console.WriteLine("hay otra mascota a atender ? s / n");
                sigue = Console.ReadLine();
                }
            Console.WriteLine("El total de mascotas atendidas es { 0}", cant);
            /*imprimir el listado de mascotas con más de 5 años de edad*/
            for(int j = 0; j < Veterinaria.CantMasc; j++)
{
                ClaseMascota mas = Veterinaria.VerDatosMascota(j);   /*toma una mascota*/
                if (mas.edad > 5)
                    Console.WriteLine(mas.nombremascota);
            }
            /*Combina el uso de métodos/propiedades de la clase Veterinaria con los/las de la clase Mascota, según corresponda.*/
            //o con un foreach
            foreach (ClaseMascota m in Veterinaria.Lista)
            {
                if (m.edad> 5) Console.WriteLine(m.nombremascota);
            }
            Console.ReadKey(true);
        }
    }
}
