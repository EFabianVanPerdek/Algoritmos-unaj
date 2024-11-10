using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
{
    public class SalonDeFiesta
    {   //atributos
        private string NombreSalon;
        private static List<Servicio> Servicios=new List<Servicio>();
        private static List<Empleado> Empleados = new List<Empleado>();
        private static List<Evento> Eventos = new List<Evento>();
        //constructor
        public SalonDeFiesta(string nombresalon)
        {
            this.NombreSalon = nombresalon;
        }
        public string nombresalon
        {
            set { NombreSalon = value; }
            get { return NombreSalon; }
        }
        //propiedades de acceso
        public static List<Servicio> servicios
        {
            set { Servicios = value; }
            get{ return Servicios; }
        }
        public static List<Empleado> empleados
        {
            set { Empleados = value; }
            get { return Empleados; }
        }
        public static List<Evento> eventos
        {
            set { Eventos = value; }
            get { return Eventos; }
        }

        public static int ObtenerOpcion()
        {
            int opcion;//se usa para almacenar un entero en el menu, como para eliminar objetos en una lista
            while (!int.TryParse(Console.ReadLine(), out opcion))//se busca parciar a entero con tryparse el dato ingresado,sea un numero o un texto tambien, que gracias al signo ! hace que el bucle se repita
            {//se almacena el dato en opcion, si es texto retorna el mensaje de abajo, si es un numero fuera de rango concluye en default del switch
                Console.WriteLine("Opción inválida. Ingrese un número entero:");
            }
            return opcion;//entonces retorna la opcion
        }

        public static void AgregarServicio()//metodo para agregar un servicio a la lista servicios del salon de fiesta
        {
            Console.WriteLine("Ingrese el nombre del servicio:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion del servicio:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad solicitada:");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo unitario del servicio:");
            int costoUnitario = int.Parse(Console.ReadLine());

            Servicio nuevoServicio = new Servicio(nombre, descripcion, cantidad, costoUnitario);
            servicios.Add(nuevoServicio);


            Console.WriteLine("Servicio agregado correctamente.");
        }

        public static void EliminarServicio()//metodo para eliminar un servicio de la lista servicios del salon de fiesta
        {
            if (servicios.Count == 0)//si la lista esta vacia
            {
                Console.WriteLine("No hay servicios registrados.");
                return;
            }

            Console.WriteLine("Servicios disponibles:");
            for (int i = 0; i < servicios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {servicios[i].nombre}");//muestra la lista de servicios
            }

            Console.WriteLine("Ingrese el numero del servicio a eliminar:");
            int opcion = ObtenerOpcion() - 1;//se utiliza nuevamente el metodo obtener opcion para poder manejar el dato ingresado

            if (opcion >= 0 && opcion < servicios.Count)//si la opcion es mayor a 0 y opcion es menor a la longitud de la lista servicios
            {
                servicios.RemoveAt(opcion);//se borra el servicio que se encuentra en la posicion ingresada en opcion -1
                Console.WriteLine("Servicio eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Opción invalida.");//si el numero excede a la longitud de la lista devuelve el mensaje
            }
        }

        public static void DarDeAltaEmpleado()//metodo para cargar empleados en la lista empleados
        {
            Console.WriteLine("Ingrese el nombre y apellido del empleado:");
            string nombreApellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del empleado:");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el legajo del empleado:");
            int legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tarea del empleado:");
            string tarea = Console.ReadLine();

            Console.WriteLine("¿Es un encargado? (s/n)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s")//con el condicional se cargar al encargado en caso que el usuario lo desee
            {
                Console.WriteLine("Ingrese el plus por evento del encargado:");
                int plusPorEvento = int.Parse(Console.ReadLine());//se ingresa el plus que el encargado va cobrar por evento

                Encargado nuevoEncargado = new Encargado(nombreApellido, dni, legajo, sueldo, tarea, plusPorEvento);
                empleados.Add(nuevoEncargado);
            }
            else
            {
                Empleado nuevoEmpleado = new Empleado(nombreApellido, dni, legajo, sueldo, tarea);
                empleados.Add(nuevoEmpleado);//en caso que no se desee cargar como encargado finaliza de la misma manera agregando a la lista empleados
            }

            Console.WriteLine("Empleado dado de alta correctamente.");
        }

        public static void DarDeBajaEmpleado()//metodo para eliminar de la lista a empleados u encargados
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            Console.WriteLine("Empleados disponibles:");
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {empleados[i].nombreyapellido}");//se recorre con un for la lista de empleados para mostrar en pantalla
            }

            Console.WriteLine("Ingrese el número del empleado a dar de baja:");
            int opcion = ObtenerOpcion() - 1;//se vuelve a utilizar este metodo como en eliminarservicio()

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



        public static void ReservarSalon()//metodo para reservar un salon
        {
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del cliente:");
            int dniCliente = int.Parse(Console.ReadLine());
            //se almacenan los datos del cliente
            Console.WriteLine("Ingrese el año del evento: 2024 o 2025):");// se piden los datos para crear los datos del DateTime
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes del evento (01 al 12):");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia del evento (01 al 31):");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora del evento (0 a 23):");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos del evento (0 a 59):");
            int minutos = int.Parse(Console.ReadLine());
            DateTime fechaHoraEvento;//se declara la variable evento para luego instanciarla
            try//dentro de un bloque try ingreso el codigo que deseo que se ejecute
            {
                fechaHoraEvento = new DateTime(anio, mes, dia, hora, minutos, 0);//se crea el objeto DateTime con los datos ingresados
                Console.WriteLine("Fecha y hora del evento registrada: " + fechaHoraEvento.ToString("yyyy-MM-dd HH:mm"));//devuelve los datos ingresados por pantalla       
                foreach (Evento x in eventos)// se verifica si ya existe una reserva para la misma fecha
                {
                    if (x.fechaHoraevento.Date == fechaHoraEvento.Date)
                    {
                        throw new ReservaException("Fecha ya reservada"); // Lanza la excepcion
                    }
                }
                Console.WriteLine("Ingrese el tipo de evento:");
                string tipoEvento = Console.ReadLine();
                // Asignar un encargado al evento
                Encargado encargado = null;//se empieza declarando un encargado sin informacion
                Console.WriteLine("Encargados disponibles:");
                for (int i = 0; i < empleados.Count; i++)//recorre la lista de empleados para encontrar encargados
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

                if (opcion >= 0 && opcion < empleados.Count && empleados[opcion] is Encargado)//si la opcion ingresada es mayor a cero y menor a la longitud de la lista empleados,
                {// y ademas la opcion ingresada se refiere a un dato de tipo encargado
                    encargado = (Encargado)empleados[opcion];//se carga el encargado
                }
                else
                {
                    Console.WriteLine("Opción invalida.");
                    return;
                }

                // Crea el evento
                Evento nuevoEvento = new Evento(nombreCliente, dniCliente, fechaHoraEvento, tipoEvento);
                nuevoEvento.encargado = encargado;

                // Agregar servicios al evento
                Console.WriteLine("¿Desea agregar servicios al evento? (s/n)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "s")
                {
                    int opcionServicio;
                    do
                    {
                        Console.WriteLine("Servicios disponibles:");
                        for (int i = 0; i < servicios.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {servicios[i].nombre}");
                        }

                        Console.WriteLine("Ingrese el número del servicio a agregar (0 para terminar):");
                        opcionServicio = ObtenerOpcion() - 1;

                        if (opcionServicio == -1)
                        {
                            break;
                        }

                        if (opcionServicio >= 0 && opcionServicio < servicios.Count)
                        {
                            nuevoEvento.serviciosContratados.Add(servicios[opcionServicio]);
                        }
                        else
                        {
                            Console.WriteLine("Opcion invalida.");
                        }
                    } while (opcionServicio == 0);
                }

                nuevoEvento.CalcularCostoTotal();//se calculo el costo total mediante el metodo

                // Solicitar la seña
                Console.WriteLine("Ingrese el monto de la seña:");
                nuevoEvento.senia = double.Parse(Console.ReadLine());

                eventos.Add(nuevoEvento);

                Console.WriteLine("Reserva realizada correctamente.");
            }
            catch (ReservaException ex)//captura de la excepcion
            {
                Console.WriteLine(ex); //devuelve el mensaje del error
                return; // Termina la ejecución del metodo si hay un error
            }
            catch (ArgumentOutOfRangeException)// Captura errores si el usuario ingresa valores fuera de rango
            {
                Console.WriteLine("Error: Fecha y hora fuera de rango. Verifique los valores ingresados.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message); // Controlar si surgen otro tipo de errores
            }
        }

        public static void CancelarEvento()//metodo para cancelar un evento
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


        public static void MostrarListadoEventos()//a continuacion se muestran las listas evocando al metodo tostring() establecido en cada clase correspondiente
        {
            if (eventos.Count == 0)
            {
                Console.WriteLine("No hay eventos registrados.");
                return;
            }

            Console.WriteLine("Listado de eventos:");
            foreach (Evento evento in eventos)
            {
                Console.WriteLine(evento);
                Console.WriteLine("----------------------");
            }
        }

        public static void MostrarListadoClientes()
        {
            if (eventos.Count == 0)
            {
                Console.WriteLine("No hay eventos registrados.");
                return;
            }

            Console.WriteLine("Listado de clientes:");
            List<string> clientes = new List<string>();
            foreach (Evento evento in eventos)
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
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            Console.WriteLine("Listado de empleados:");
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado);
                Console.WriteLine("----------------------");
            }
        }

        public static void MostrarListadoEventosMes()
        {
            if (eventos.Count == 0)
            {
                Console.WriteLine("No hay eventos registrados.");
                return;
            }

            Console.WriteLine("Ingrese el mes (1-12):");
            int mes = ObtenerOpcion();

            Console.WriteLine("Listado de eventos del mes " + mes + ":");
            foreach (Evento evento in eventos)
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

