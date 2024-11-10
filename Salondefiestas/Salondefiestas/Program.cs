using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
{
        public class Program //(Menú principal)
        {
            static SalonDeFiesta nuevosalon;
        
            static void Main()
            {
                bool salir = false;
                while (!salir)//mientras que salir se mantenga en false
                {
                    MostrarMenu();//muestra el menu mediante el metodo
                    int opcion = SalonDeFiesta.ObtenerOpcion();
                    //una vez que mediante el metodo obteneropcion devuelve el numero entero
                    switch (opcion)
                    {
                        case 1:
                            SalonDeFiesta.AgregarServicio();
                            break;
                        case 2:
                            SalonDeFiesta.EliminarServicio();
                            break;
                        case 3:
                            SalonDeFiesta.DarDeAltaEmpleado();
                            break;
                        case 4:
                            SalonDeFiesta.DarDeBajaEmpleado();
                            break;
                        case 5:
                            SalonDeFiesta.ReservarSalon();
                            break;
                        case 6:
                            SalonDeFiesta.CancelarEvento();
                            break;
                        case 7:
                            MostrarSubmenuImpresion();
                            break;
                        case 0:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida. Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            public static void MostrarMenu()
            {
                nuevosalon = new SalonDeFiesta("la encantada");//instancio el objeto de tipo salon de fiesta
                Console.WriteLine($"Menu del Salon de Fiestas:   {nuevosalon.nombresalon.ToUpper()}"); 
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Eliminar un servicio");
                Console.WriteLine("3. Dar de alta un empleado/encargado");
                Console.WriteLine("4. Dar de baja un empleado/encargado");
                Console.WriteLine("5. Reservar el salon para un evento");
                Console.WriteLine("6. Cancelar un evento");
                Console.WriteLine("7. Submenu de impresión");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Ingrese una opcion:");
            }

            
            
      
            static void MostrarSubmenuImpresion()//metodo para mostrar el submenu de la opcion 7, en la cual imprime listado de eventos, clientes, empleados,etc.
            {
                Console.WriteLine("Submenú de impresion");
                Console.WriteLine("1. Listado de eventos");
                Console.WriteLine("2. Listado de clientes");
                Console.WriteLine("3. Listado de empleados");
                Console.WriteLine("4. Listado de eventos de un mes determinado");
                Console.WriteLine("0. Volver al menu principal");

                int opcion = SalonDeFiesta.ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        SalonDeFiesta.MostrarListadoEventos();
                        break;
                    case 2:
                        SalonDeFiesta.MostrarListadoClientes();
                        break;
                    case 3:
                        SalonDeFiesta.MostrarListadoEmpleados();
                        break;
                    case 4:
                        SalonDeFiesta.MostrarListadoEventosMes();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intente de nuevo.");
                        break;
                }
            }
        }
}
