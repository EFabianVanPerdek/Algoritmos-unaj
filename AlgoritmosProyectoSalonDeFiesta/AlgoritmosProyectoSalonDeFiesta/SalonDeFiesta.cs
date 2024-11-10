using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
    public class SalonDeFiesta
    {
        private string NombreSalon;
        private static List<Empleado>Empleados;
        private static List<Evento> Eventos;
        private static List<Servicio> Servicios;
        public SalonDeFiesta(string nombresalon)
            {
                this.NombreSalon = nombresalon;
                Empleados = new List<Empleado>();
                Eventos = new List<Evento>();
                Servicios = new List<Servicio>();
            }
        public string nombresalon
        {
                set { NombreSalon = value; }
                get { return NombreSalon; }
        }
        public static List<Empleado> empleados { set{ Empleados = value; }get{ return Empleados; } }
        public static List<Evento> eventos { set { Eventos = value; } get { return Eventos; } }
        public static List<Servicio> servicios { set { Servicios = value; } get { return Servicios; } }

        public static void AgregarServicio()
        {
            Console.WriteLine("Ingrese el nombre del servicio:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripción del servicio:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad solicitada:");
            
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo unitario del servicio:");
            int costoUnitario = int.Parse(Console.ReadLine());

            Servicio nuevoServicio = new Servicio(nombre, descripcion, cantidad, costoUnitario);
            Servicios.Add(nuevoServicio);

            Console.WriteLine("Servicio agregado correctamente.");
        }
        public static void EliminarServicio()
        {
            if (Servicios.Count == 0)
            {
                Console.WriteLine("No hay servicios registrados.");
                return;
            }

            Console.WriteLine("Servicios disponibles:");
            for (int i = 0; i < Servicios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Servicios[i].nombre}");
            }

            Console.WriteLine("Ingrese el número del servicio a eliminar:");
            int opcion = ObtenerOpcion() - 1;

            if (opcion >= 0 && opcion < Servicios.Count)
            {
                Servicios.RemoveAt(opcion);
                Console.WriteLine("Servicio eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
        public static void DarDeAltaEmpleado()
        {
            Console.WriteLine("Ingrese el nombre y apellido del empleado:");
            string nombreApellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del empleado:");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese el legajo del empleado:");
            int legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tarea del empleado:");
            string tarea = Console.ReadLine();

            Console.WriteLine("¿Es un encargado? (s/n)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "s")
            {
                Console.WriteLine("Ingrese el plus por evento del encargado:");
                int plusPorEvento = int.Parse(Console.ReadLine());

                Encargado nuevoEncargado = new Encargado(nombreApellido, dni, legajo, sueldo, tarea, plusPorEvento);
                empleados.Add(nuevoEncargado);
            }
            else
            {
                Empleado nuevoEmpleado = new Empleado(nombreApellido, dni, legajo, sueldo, tarea);
                empleados.Add(nuevoEmpleado);
            }

            Console.WriteLine("Empleado dado de alta correctamente.");
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
        public static void DarDeBajaEmpleado()
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            Console.WriteLine("Empleados disponibles:");
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {empleados[i].nombreyapellido}");
            }

            Console.WriteLine("Ingrese el número del empleado a dar de baja:");
            int opcion = ObtenerOpcion() - 1;

            if (opcion >= 0 && opcion < empleados.Count)
            {
                empleados.RemoveAt(opcion);
                Console.WriteLine("Empleado dado de baja correctamente.");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
        public static void ReservarSalon()
        {
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del cliente:");
            string dniCliente = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha y hora del evento (AAAA-MM-DD HH:mm):");
            DateTime fechaHoraEvento;
            while (!DateTime.TryParse(Console.ReadLine(), out fechaHoraEvento))
            {
                Console.WriteLine("Formato de fecha y hora inválido. Ingrese la fecha y hora en formato 'AAAA-MM-DD HH:mm':");
            }

            Console.WriteLine("Ingrese el tipo de evento:");
            string tipoEvento = Console.ReadLine();

            // Verificar si ya existe una reserva para la misma fecha
            if (eventos.Exists(e => e.fechaHoraevento.Date == fechaHoraEvento.Date))
            {
                Console.WriteLine("El salón ya está reservado para esa fecha.");
                return;
            }

            // Asignar un encargado al evento
            Encargado encargado = null;
            Console.WriteLine("Encargados disponibles:");
            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleados[i] is Encargado)
                {
                    Console.WriteLine($"{i + 1}. {empleados[i].nombreyapellido}");
                    encargado = (Encargado)empleados[i];
                }
            }

            if (encargado == null)
            {
                Console.WriteLine("No hay encargados disponibles.");
                return;
            }

            Console.WriteLine("Ingrese el número del encargado:");
            int opcion = ObtenerOpcion() - 1;

            if (opcion >= 0 && opcion < empleados.Count && empleados[opcion] is Encargado)
            {
                encargado = (Encargado)empleados[opcion];
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            // Crear el evento
            Evento nuevoEvento = new Evento(nombreCliente, dniCliente, fechaHoraEvento, tipoEvento);
            nuevoEvento.encargado = encargado;

            // Agregar servicios al evento
            Console.WriteLine("¿Desea agregar servicios al evento? (s/n)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "s")
            {
                while (true)
                {
                    Console.WriteLine("Servicios disponibles:");
                    for (int i = 0; i < Servicios.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Servicios[i].nombre}");
                    }

                    Console.WriteLine("Ingrese el número del servicio a agregar (0 para terminar):");
                    int opcionServicio = ObtenerOpcion() - 1;

                    if (opcionServicio == -1)
                    {
                        break;
                    }

                    if (opcionServicio >= 0 && opcionServicio < Evento.serviciosContratados.Count)
                    {
                        Evento.serviciosContratados.Add(Servicios[opcionServicio]);
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
            }

            nuevoEvento.CalcularCostoTotal();

            // Solicitar la seña
            Console.WriteLine("Ingrese el monto de la seña:");
            nuevoEvento.senia = double.Parse(Console.ReadLine());

            eventos.Add(nuevoEvento);

            Console.WriteLine("Reserva realizada correctamente.");
        }
        public static void CancelarEvento()
        {
            if (eventos.Count == 0)
            {
                Console.WriteLine("No hay eventos registrados.");
                return;
            }

            Console.WriteLine("Eventos disponibles:");
            for (int i = 0; i < eventos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {eventos[i].nombrecliente} - {eventos[i].fechaHoraevento:dd/MM/yyyy HH:mm}");
            }

            Console.WriteLine("Ingrese el número del evento a cancelar:");
            int opcion = ObtenerOpcion() - 1;

            if (opcion >= 0 && opcion < eventos.Count)
            {
                Evento eventoACancelar = eventos[opcion];

                // Verificar si la cancelación se realiza con más de un mes de anticipación
                TimeSpan tiempoRestante = eventoACancelar.fechaHoraevento - DateTime.Now;
                if (tiempoRestante.TotalDays > 30)
                {
                    Console.WriteLine("La cancelación se realiza con más de un mes de anticipación. No se reintegra la seña.");
                }
                else
                {
                    Console.WriteLine("La cancelación se realiza con menos de un mes de anticipación. Se deberá abonar el servicio completo.");
                }

                eventos.RemoveAt(opcion);
                Console.WriteLine("Evento cancelado correctamente.");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}
