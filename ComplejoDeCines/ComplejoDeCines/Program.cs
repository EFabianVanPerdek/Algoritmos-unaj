using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoDeCines
{
    class Program
    {
        public class sinCapacidadExeption : Exception
        {
            public string Motivo;
            public sinCapacidadExeption(string motivo) { this.Motivo = motivo; }
        }
        static void Main()
        {
            ComplejoCine Cinemark = new ComplejoCine("Cinemark");
            Console.WriteLine($"----------complejo de cine {Cinemark.nombre}-------------");
            Sala Fv = new Sala("Florencio Varela",1,5000,0);
            Sala Quil = new Sala("Quilmes",2, 6000, 0);
            Sala Av = new Sala("Avellaneda",3, 7000, 0);
            Sala Cf = new Sala("Capital Federal",4, 8000, 0);
            Sala Bera = new Sala("Berazategui",5, 9000, 0);
            Sala Ad = new Sala("Adrogue",6, 10000, 0);
            ComplejoCine.AgregarSala(Fv);
            ComplejoCine.AgregarSala(Quil);
            ComplejoCine.AgregarSala(Av);
            ComplejoCine.AgregarSala(Cf);
            ComplejoCine.AgregarSala(Bera);
            ComplejoCine.AgregarSala(Ad);
            Console.WriteLine("Salas agregadas correctamente");
            //ComplejoCine.EliminarSala();
            Pelicula Senior = new Pelicula("el señor de los anillos", "accion", "20:00",15000, Fv);
            Pelicula Terminator = new Pelicula("terminator", "accion", "18:00",12000,Fv);
            Pelicula Toy_Story = new Pelicula("toy Story", "Infantil", "14:00",12000, Fv);
            Pelicula Crepusculo = new Pelicula("crepusculo", "Romance", "12:00",8000, Fv);
            Pelicula Harry = new Pelicula("harrypotter", "thriller", "12:00",6000, Quil);
            Pelicula Spiderman = new Pelicula("spiderman", "Romance", "14:00",9000, Quil);
            Pelicula Batman = new Pelicula("batman", "Romance", "18:00",70000, Quil);
            Pelicula Marvel1 = new Pelicula("marvel1", "suspenso", "20:00",11000, Quil);
            Pelicula Marvel2 = new Pelicula("marvel2", "suspenso", "12:00",15000, Cf);
            Pelicula Marvel3 = new Pelicula("marvel3", "suspenso", "14:00",8500, Cf);
            Pelicula Marvel4 = new Pelicula("marvel4", "suspenso", "20:00",10500, Cf);
            Pelicula Rocky = new Pelicula("rocky", "Romance", "24:00",9500, Cf);
            Pelicula Rambo = new Pelicula("rambo", "Accion", "12:00",11350, Bera);
            Pelicula Mision = new Pelicula("misionimposible", "suspenso", "16:00",7900, Bera);
            Pelicula.AddPeliculas(Senior);
            Pelicula.AddPeliculas(Terminator);
            Pelicula.AddPeliculas(Toy_Story);
            Pelicula.AddPeliculas(Crepusculo);
            Pelicula.AddPeliculas(Harry);
            Pelicula.AddPeliculas(Spiderman);
            Pelicula.AddPeliculas(Batman);
            Pelicula.AddPeliculas(Marvel1);
            Pelicula.AddPeliculas(Marvel2);
            Pelicula.AddPeliculas(Marvel3);
            Pelicula.AddPeliculas(Marvel4);
            Pelicula.AddPeliculas(Rocky);
            Pelicula.AddPeliculas(Rambo);
            Pelicula.AddPeliculas(Mision);
            Console.WriteLine("se agregaron todas las peliculas");
            Console.ReadKey();
            Simularventa();
            
        }
        public static void Simularventa()
        {
            Console.Clear();string continuetion;
            do
            {
                Console.WriteLine("vamos a simular la venta de entradas:");
                Console.WriteLine("a continuacion les mostraremos las peliculas, horarios y sala que corresponde:");
                foreach (Pelicula x in ComplejoCine.Peliculas)
                {
                    Console.WriteLine($"Pelicula: {x.titulo} Horario: {x.horario} Sala: {x.num.sede}");
                }
                Console.WriteLine("por favor elija la pelicula que desea comprar:");
                string pelicula = Console.ReadLine().ToLower();
                Pelicula peliculaseleccionada = null;

                foreach (Pelicula p in ComplejoCine.Peliculas)
                {
                    if (p.titulo.ToLower() == pelicula)
                    {
                        peliculaseleccionada = p;
                        break;
                    }
                }

                if (peliculaseleccionada == null) { Console.WriteLine("la pelicula ingresada no se encuentra,intente nuevamente"); }
                    else
                    {
                    try { 
                        Console.WriteLine("cuantas entradas desea comprar?");
                        int cantidad = int.Parse(Console.ReadLine());
                        Sala salacorrespondiente = null;
                        foreach (Sala x in ComplejoCine.Salas)
                        {
                            if (peliculaseleccionada.num==ComplejoCine.Salas[x.numero])
                            {
                                salacorrespondiente = x;
                                break;
                            }
                        }
                        if(salacorrespondiente!=null)
                        {
                            if(salacorrespondiente.capacidad - salacorrespondiente.cantentvendidas  < cantidad) 
                            {
                                throw new Exception("no hay entradas suficientes");
                            }
                            salacorrespondiente.cantentvendidas += cantidad;
                            Console.WriteLine("ENTRADA COMPRADA!");
                        }
                        else { Console.WriteLine("No se encontro la sala correspondiente"); }
                    }
                    catch (sinCapacidadExeption)
                    {
                        Console.WriteLine($"ERROR");
                        Console.WriteLine("la venta ha sido cancelada");
                    }
                }

                
                Console.WriteLine("desea comprar otra entrada?? si/no");
                continuetion = Console.ReadLine();
            } while (continuetion.ToLower() == "si");

            Console.WriteLine("a continuacion realizaremos un porcentaje de las peliculas de suspenso vendidas:");
            int contador = 0;
            int sumavalores = 0;
            int cantsuspenso = 0;
            int cantsala1 = 0;
            int cantsala2 = 0;
            int cantsala3 = 0;
            int cantsala4 = 0;
            int cantsala5 = 0;
            int cantsala6 = 0;
            for (int i=0; i<ComplejoCine.Peliculas.Count;i++)
            {
                if (ComplejoCine.Peliculas[i].num.cantentvendidas > 0)
                { contador += ComplejoCine.Peliculas[i].num.cantentvendidas;
                    sumavalores = (int)(ComplejoCine.Peliculas[i].num.cantentvendidas * ComplejoCine.Peliculas[i].precio);
                }
                if(ComplejoCine.Peliculas[i].genero=="suspenso")
                {
                    cantsuspenso += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if(ComplejoCine.Peliculas[i].num.sede== "Florencio Varela")
                {
                    cantsala1 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if (ComplejoCine.Peliculas[i].num.sede == "Quilmes")
                {
                    cantsala2 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if (ComplejoCine.Peliculas[i].num.sede == "Avellaneda")
                {
                    cantsala3 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if (ComplejoCine.Peliculas[i].num.sede == "Capital Federal")
                {
                    cantsala4 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if (ComplejoCine.Peliculas[i].num.sede == "Berazategui")
                {
                    cantsala5 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
                if (ComplejoCine.Peliculas[i].num.sede == "Adrogue")
                {
                    cantsala6 += ComplejoCine.Peliculas[i].num.cantentvendidas;
                }
            }
            Console.WriteLine($"Monto total recaudado: {sumavalores}");
            Console.WriteLine($"Porcentaje cantidad peliculas suspenso { cantsuspenso}");
            Console.WriteLine($"SALA 1 {ComplejoCine.Salas[0].sede } CANT. VENDIDAS:{cantsala1 }\nSALA 2 {ComplejoCine.Salas[1].sede } CANT. VENDIDAS:{cantsala2 }\nSALA 3 {ComplejoCine.Salas[2].sede } CANT. VENDIDAS:{cantsala3 }\nSALA 4 {ComplejoCine.Salas[3].sede } CANT. VENDIDAS:{cantsala4 }\nSALA 5 {ComplejoCine.Salas[4].sede } CANT. VENDIDAS:{ cantsala5}\nSALA 6 { ComplejoCine.Salas[5].sede} CANT. VENDIDAS:{cantsala6 }");
            
            
            
            Console.ReadKey();
        
        }
    }
}
