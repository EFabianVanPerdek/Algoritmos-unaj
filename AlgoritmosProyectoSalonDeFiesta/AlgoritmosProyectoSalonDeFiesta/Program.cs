using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
        public class Program // Clase Program (Menú principal)
        {   
            static void Main(string[] args)
            {
                bool salir = false;

                while (!salir)
                {
                    MostrarMenu();
                    int opcion = ObtenerOpcion();

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
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            public static void MostrarMenu()
            {
                SalonDeFiesta nuevo = new SalonDeFiesta("la encantada");
                Console.WriteLine("Menú del Salón de Fiestas");
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Eliminar un servicio");
                Console.WriteLine("3. Dar de alta un empleado/encargado");
                Console.WriteLine("4. Dar de baja un empleado/encargado");
                Console.WriteLine("5. Reservar el salón para un evento");
                Console.WriteLine("6. Cancelar un evento");
                Console.WriteLine("7. Submenú de impresión");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Ingrese una opción:");
            }
            
            public static int ObtenerOpcion()
            {
                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Ingrese un número entero:");
                }
                return opcion;
            }
            public static void MostrarSubmenuImpresion()
            {
                Console.WriteLine("Submenú de impresión");
                Console.WriteLine("1. Listado de eventos");
                Console.WriteLine("2. Listado de clientes");
                Console.WriteLine("3. Listado de empleados");
                Console.WriteLine("4. Listado de eventos de un mes determinado");
                Console.WriteLine("0. Volver al menú principal");

                int opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        MostrarListadoEventos();
                        break;
                    case 2:
                        MostrarListadoClientes();
                        break;
                    case 3:
                        MostrarListadoEmpleados();
                        break;
                    case 4:
                        MostrarListadoEventosMes();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }

            public static void MostrarListadoEventos()
            {
                if (SalonDeFiesta.eventos.Count == 0)
                {
                    Console.WriteLine("No hay eventos registrados.");
                    return;
                }

                Console.WriteLine("Listado de eventos:");
                foreach (Evento evento in SalonDeFiesta.eventos)
                {
                    Console.WriteLine(evento);
                    Console.WriteLine("----------------------");
                }
            }

            public static void MostrarListadoClientes()
            {
                if (SalonDeFiesta.eventos.Count == 0)
                {
                    Console.WriteLine("No hay eventos registrados.");
                    return;
                }

                Console.WriteLine("Listado de clientes:");
                List<string> clientes = new List<string>();
                foreach (Evento evento in SalonDeFiesta.eventos)
                {
                    if (!clientes.Contains(evento.nombrecliente))
                    {
                        clientes.Add(evento.nombrecliente);
                        Console.WriteLine(evento.nombrecliente);
                    }
                }
            }

            public static void MostrarListadoEmpleados()
            {
                if (SalonDeFiesta.empleados.Count == 0)
                {
                    Console.WriteLine("No hay empleados registrados.");
                    return;
                }

                Console.WriteLine("Listado de empleados:");
                foreach (Empleado empleado in SalonDeFiesta.empleados)
                {
                    Console.WriteLine(empleado);
                    Console.WriteLine("----------------------");
                }
            }

            public static void MostrarListadoEventosMes()
            {
                if (SalonDeFiesta.eventos.Count == 0)
                {
                    Console.WriteLine("No hay eventos registrados.");
                    return;
                }

                Console.WriteLine("Ingrese el mes (1-12):");
                int mes = ObtenerOpcion();

                Console.WriteLine("Listado de eventos del mes " + mes + ":");
                foreach (Evento evento in SalonDeFiesta.eventos)
                {
                    if (evento.fechaHoraevento.Month == mes)
                    {
                        Console.WriteLine(evento);
                        Console.WriteLine("----------------------");
                    }
                }
            }
        }

 }
