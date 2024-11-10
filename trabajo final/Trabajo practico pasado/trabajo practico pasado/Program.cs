using SalonDeEventos;
using System;
using System.Collections;


public class Program
{
    public static void Main(string[] args)
    {

        //Creacion del salon

        SalonDeFiesta salon = new SalonDeFiesta("Ensueño");

        //Menu principal

        int opcion = 999;
        
        do
        {
            MenuPrincipal();
            opcion = 999;
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────░");
            Console.Write("├ Ingrese la opción deseada: ");
            try { 
            	opcion = int.Parse(Console.ReadLine()); 
            	if (opcion > 5 | opcion < 0) {
            		Error();
            		Continuar(); 
            		Console.ReadKey();
            	} 
            } 
            catch (FormatException) { 
            	ErrorFormato(); 
            	Continuar(); 
            	Console.ReadKey(); 
            }



            switch (opcion)
            {

                //Dar de alta empleado  
                case 1:
                    try
                    {

                        { 
                            salon.AgregarEmpleado(CrearEmpleado());
                            Console.WriteLine("");
                            Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine("   ├ Empleado agregado correctamente.                                       │");
                            Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                        }

                        Continuar();
                    }
                    catch (FormatException) { 
                    	ErrorFormato(); 
                    }
                    Console.ReadKey();

                    break;

                //dar de baja empleado/encargado
                case 2:

                    try
                    {
                        Console.WriteLine("┌────────────────────────────────────────────────────────────────────────░");
                        Console.Write("├ Si el empleado a dar de baja es encargado ingrese <1> de lo contrario ingrese <2>: ");
                        int empOpcion = int.Parse(Console.ReadLine());
                        Console.Write("├ Ingrese el numero de legajo: ");
                        int legajoTemp = int.Parse(Console.ReadLine());

                        //Dar de baja encargado
                        if (empOpcion == 1)
                        {
                            if (salon.ElimEmpleado(salon.VerEncargado(legajoTemp)))
                            {

                                

                                Console.WriteLine("");
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ Encargado dado de baja.                                                │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");

                                
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ No se pudo dar de baja, vuelva a intentarlo.                           │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                            }
                        }

                        //Dar de baja empleado
                        if (empOpcion == 2)
                        {
                            if (salon.ElimEmpleado(salon.VerEmpleado(legajoTemp)))
                            {
                                Console.WriteLine("");
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ Empleado dado de baja                                                  │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                            }

                            else {
                                Console.WriteLine("");
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ No se pudo dar de baja, vuelva a intentarlo.                           │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                            }
                        }

                        //opcion incorrecta
                        if (empOpcion != 1 && empOpcion != 2) { 
                        	Error();
                        }
                    }//error de formato
                    catch (FormatException) { 
                    	ErrorFormato(); 
                    }
                    catch (Exception e) 
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine("   ├ El legajo indicado no pertenece a un encargado. Intentelo nuevamente.  │");
                        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                         
                    }

                    Continuar(); 
                    Console.ReadKey();
                    break;

                //reservar evento--> submenu
                            

                case 3:

                    if (salon.EmpleadosLibres())
                    {
                        try
                        {



                            Evento EventoTemporal = CrearEvento();

                            try
                            {
                                if (salon.AgregarEvento(EventoTemporal))
                                {
                                    salon.AsignarEncargadoEvento(EventoTemporal);
                                    

                                    Console.WriteLine("");
                                    Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine("   ├ Evento reservado correctamente, además se ha asignado un encargado al  │");
                                    Console.WriteLine("   │ Evento cuyo legajo es:" + EventoTemporal.EncargadoLegajo+"                                                |");
                                    Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");

                                    Console.WriteLine("");
                                    Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                    Console.WriteLine("   ├ Sera redireccionado al menu de eventos...                              │");
                                    Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                                    Continuar(); 
                                    Console.ReadKey();

                                    int eventoOpcion = 999;
                                    do
                                    {

                                        try
                                        {
                                            //submenu de eventos
                                            OpcionesSubMenu();
                                            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────░");
                                            Console.Write("├ Ingrese la opción deseada: ");
                                            eventoOpcion = int.Parse(Console.ReadLine());

                                            switch (eventoOpcion)
                                            {
                                                //caso 1 agregar servicio
                                                case 1:

                                                    Servicio ServTemp = CrearServicio();
                                                    EventoTemporal.AgregarServicio(ServTemp);
                                                    Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                                    Console.WriteLine("   ├ Servicio agregado correctamente.                                     │");
                                                    Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                                                    Console.ReadKey();
                                                    break;

                                                //caso 2 eliminar servicio
                                                case 2:
                                                    Console.Write("├ Ingrese el tipo de servicio que quiere eliminar: ");
                                                    string tipoTemp = Console.ReadLine();
                                                    if (EventoTemporal.EliminarServicio(tipoTemp))
                                                    {
                                                        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                                        Console.WriteLine("   ├ Servicio eliminado correctamente.                                      │");
                                                        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                                                    }
                                                    else 
                                                    {
                                                        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                                        Console.WriteLine("   ├ No se ha encontrado el servicio que esta intentando eliminar           │");
                                                        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                                                    } 
                                                    Console.ReadKey();
                                                    break;




                                            }
                                        }
                                        catch (FormatException) { 
                                        	ErrorFormato(); 
                                        	Console.ReadLine(); 
                                        }
                                    }

                                    while (eventoOpcion != 0);

                                    EventoTemporal.CalcularCostoTotal();
                                }


                            }//Fecha reservada
                            catch (ReservaException e) 
                            {
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ Fecha reservada, vuelva a intentarlo...                                │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");

                                Continuar(); 
                                Console.ReadKey();
                            }





                        }//Error de formato
                        catch (FormatException) { 
                        	ErrorFormato();
                        }

                        Continuar(); 
                        Console.ReadKey();
                        break;
                    }
                    //No hay empleados libres para asignarse al evento
                    else {
                        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine("   ├ No existen empleados libres para hacerse cargo del evento, por favor   │");
                        Console.WriteLine("   │cargue empleados para poder hacer la reserva correspondiente...         │");
                        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                        
                         Continuar(); 
                         Console.ReadKey();
                         break;}


                //Dar de baja un evento 
                case 4:

                    Evento eventoTemporal;
                    DateTime fechaTemp = new DateTime(1, 1, 1);
                    int anio, mes, dia;
                    int c = 0;


                    do
                    {

                        try
                        {
                            Console.Write("├ Ingrese el año en numeros: ");
                            anio = int.Parse(Console.ReadLine());
                            Console.Write("├ Ingrese el mes en numeros: ");
                            mes = int.Parse(Console.ReadLine());
                            Console.Write("├ Ingrese el dia en numeros: ");
                            dia = int.Parse(Console.ReadLine());
                            fechaTemp = new DateTime(anio, mes, dia);
                            c = 1;
                        }
                        //error de formato al crearse la variable del tipo DateTime
                        catch (Exception e)
                        {
                            ErrorFormato();
                            Continuar(); 
                            Console.ReadKey();
                        }
                    }//Solamente sale del loop si consigo crear la variable DateTime
                    while (c == 0);


                    eventoTemporal = salon.VerificarFecha(fechaTemp);
                    

                    if (eventoTemporal == null)
                    {
                        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine("   ├ Fecha de evento no existente, vuelva a intentarlo...                   │");
                        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                    }
                    else
                    {
                        if (salon.ElimEvento(eventoTemporal)) 
                        {
                            Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine("   ├ El evento ha sido cancelado correctamente.                             │");
                            Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");

                            if ((eventoTemporal.Fecha.Month - DateTime.Today.Month) > 0|eventoTemporal.Fecha.Year>DateTime.Today.Year)
                            {
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ Ya que ha cancelado por lo menos con un mes de antelacion no debe      │");
                                Console.WriteLine("   │abonar el servicio completo pero la seña no sera reembolsada.           │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                            }
                            else 
                            {
                                Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                                Console.WriteLine("   ├ Por haber cancelado con menos de un mes de antelacion debe abonar el   │");
                                Console.WriteLine("   │servicio completo.                                                      │");
                                Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");
                            }
                        }
                        else 
                        {
                            Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine("   ├ El evento no se ha podido cancelar. Vuelva a intentarlo                │");
                            Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×"); 
                        }
                    }

                    Continuar(); 
                    Console.ReadKey();

                    break;

                //submenu de impresiones

                case 5:
                    int ImpresionesSubmenuTemp = 999;
                    do
                    {
                        ImpresionSubmenu();

                        try
                        {
                            Console.Write("├ Ingrese la opción deseada: ");
                            ImpresionesSubmenuTemp = int.Parse(Console.ReadLine());
                            if (ImpresionesSubmenuTemp > 4 | ImpresionesSubmenuTemp < 0) {
                            	Error(); 
                            	Continuar();
                            	Console.ReadKey();
                            }
                            switch (ImpresionesSubmenuTemp)
                            {
                                // LISTADO DE EVENTOS
                                case 1:
                                    ImprimirEventos(salon);
                                    Continuar(); Console.ReadKey();
                                    break;

                                //LISTADO DE CLIENTES
                                case 2:
                                    ImprimirClientes(salon);
                                    Continuar(); Console.ReadKey();
                                    break;

                                //LISTADO DE EMPLEADOS
                                case 3:
                                    ImprimirEmpleados(salon);
                                    Continuar(); Console.ReadKey();
                                    break;

                                //LISTADO DE EVENTOS EN UN MES ESPECIFICO

                                case 4:

                                    Console.Write("├ Ingrese el mes del cual desea saber los eventos reservados: ");
                                    int mesEventoTemporal = int.Parse(Console.ReadLine());
                                    ImprimirEventosMes(mesEventoTemporal,salon);
                                    Continuar(); Console.ReadKey();
                                    break;


                            }
                        }//Error de formato
                        catch (FormatException) {
                        	ErrorFormato();
                        	Console.ReadKey(); 
                        }

                    }
                    while (ImpresionesSubmenuTemp != 0);
                    break;


            }



        }
        while (opcion != 0);


    }


    //Crea una instancia de empleado
    public static Empleado CrearEmpleado()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                 « Creando un empleado...                                ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("╚═════════════════════════────────────═══════════════════■■■■■■■■■■■══════╝");

        Console.WriteLine("┌────────────────────────────────────────────────────────────────────────░");
        Console.Write("├ Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();
        Console.Write("├ Ingrese el apellido del empleado: ");
        string apellido = Console.ReadLine();
        Console.Write("├ Ingrese el DNI del empleado en numeros: ");
        int dni = int.Parse(Console.ReadLine());
        Console.Write("├ Ingrese el legajo del empleado en numeros: ");
        int legajo = int.Parse(Console.ReadLine());
        Console.Write("├ Ingrese el sueldo del empleado en numeros: ");
        double sueldo = double.Parse(Console.ReadLine());
        Console.Write("├ Ingrese la tarea del empleado: ");
        string tarea = Console.ReadLine();
       

        Empleado temp = new Empleado(nombre, apellido, dni, legajo, sueldo, tarea);
        return temp;
    }


    
    //Crear un evento
    public static Evento CrearEvento()
    {

        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                 « Creando un Evento...                                  ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("╚═════════════════════════────────────═══════════════════■■■■■■■■■■■══════╝");

        

        Console.WriteLine("┌────────────────────────────────────────────────────────────────────────░");
        Console.Write("├ Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("├ Ingrese el dni del cliente en numeros: ");
        int dni = int.Parse(Console.ReadLine());

        //Comprobación de que el formato de la fecha sea el correcto
        DateTime fecha = new DateTime(1,1,1,1,1,1);
        int anio, mes, dia,hora,minuto;
        int c = 0;
        do
        {
            try
            {
                Console.Write("├ Ingrese el año en numeros: ");
                anio = int.Parse(Console.ReadLine());
                Console.Write("├ Ingrese el mes en numeros: ");
                mes = int.Parse(Console.ReadLine());
                Console.Write("├ Ingrese el dia en numeros: ");
                dia = int.Parse(Console.ReadLine());
                Console.Write("├ Ingrese la hora en numeros: ");
                hora = int.Parse(Console.ReadLine());
                Console.Write("├ Ingrese los minutos en numeros: ");
                minuto = int.Parse(Console.ReadLine());

                fecha = new DateTime(anio, mes, dia,hora,minuto,0);
                c = 1;
            }

            catch (Exception e)
            {
                ErrorFormato();
            }
        }
        while (c == 0);

       // Console.Write("├ Ingrese la hora del evento en el siguiente formato: (00:00): ");
       
        Console.Write("├ Ingrese el tipo de evento: ");
        string tipo = Console.ReadLine();

        Evento ev1 = new Evento(nombre, dni, fecha, tipo);
        return ev1;

    }

    //Crear servicio
    public static Servicio CrearServicio()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                 « Eventos                                               ║");
        Console.WriteLine("║                      « Creando un Servicio...                           ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("╚═════════════════════════────────────═══════════════════■■■■■■■■■■■══════╝");

       
        Console.Write("├ Ingrese el nombre del servicio: ");
        string nombre = Console.ReadLine();
        Console.Write("├ Ingrese el tipo del servicio: ");
        string tipo = Console.ReadLine();
        Console.Write("├ Ingrese la descripción del servicio: ");
        string descripcion = Console.ReadLine();
        Console.Write("├ Ingrese la cantidad solicitada del servicio: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Write("├ Ingrese el precio del servicio: ");
        int precio = int.Parse(Console.ReadLine());
        Servicio servTemp = new Servicio(nombre, tipo, descripcion, cantidad, precio);
        return servTemp;
    }

    

    public static void MenuPrincipal()
    {
        Console.Clear();

        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("║             ¤ 1  Dar de alta un Empleado                                ║");
        Console.WriteLine("║             ¤ 2  Dar de baja un Empleado/Encargado                      ║");
        Console.WriteLine("║             ¤ 3  Reservar evento                                        ║");  //Submenu
        Console.WriteLine("║             ¤ 4  Cancelar evento                                        ║");
        Console.WriteLine("║             ¤ 5  Impresion/Submenu                                      ║"); //Submenu de impresion
        Console.WriteLine("║             ¤ 0  Salir                                                  ║");
        Console.WriteLine("║┼                                                                        ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════■■■■■■■■■■■══════╝");
        Console.WriteLine("");
    }

    public static void OpcionesSubMenu()

    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                 « Eventos                                               ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("║            ¤ 1 Agregar Servicio                                         ║");
        Console.WriteLine("║            ¤ 2 Eliminar Servicio                                        ║");
        Console.WriteLine("║            ¤ 0 Volver al menu principal                                 ║");
        Console.WriteLine("║┼                                                                        ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════■■■■■■■■■■■══════╝");
        Console.WriteLine("");

    }

    public static void ImpresionSubmenu()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════════───────────═╗");
        Console.WriteLine("║         « SALON DE EVENTOS ENSUEÑO                                 ┌    ║");
        Console.WriteLine("║              « MENU PRINCIPAL                                       ┘   ║");
        Console.WriteLine("║                 « Impresion                                             ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("║                                                                         ║");
        Console.WriteLine("║            ¤ 1 Listado de eventos                                       ║");
        Console.WriteLine("║            ¤ 2 Listado de clientes                                      ║");
        Console.WriteLine("║            ¤ 3 Listado de empleados                                     ║");
        Console.WriteLine("║            ¤ 4 Listado de eventos en un mes especifico                  ║");
        Console.WriteLine("║            ¤ 0 Volver al menu principal                                 ║");
        Console.WriteLine("║┼                                                                        ║");
        Console.WriteLine("╚═════════════════════════────────────═══════════════════■■■■■■■■■■■══════╝");
        Console.WriteLine("");
    }

    public static void Error()
    {
        Console.WriteLine("");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░┌────────────────────────────────────────────────────────────────────────┐░");
        Console.WriteLine("░├ Opcion incorrecta! Vuelva a intentarlo...                              │░");
        Console.WriteLine("░└────────────────────────────────────────────────────────────────────────┘░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("");
    }

    public static void ErrorFormato()
    {
        Console.WriteLine("");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░┌────────────────────────────────────────────────────────────────────────┐░");
        Console.WriteLine("░├ Error de formato! Vuelva a intentarlo...                               │░");
        Console.WriteLine("░└────────────────────────────────────────────────────────────────────────┘░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("");
    }
    
    public static void Continuar() 
    {
        Console.WriteLine("");
        Console.WriteLine(" × ┌────────────────────────────────────────────────────────────────────────┐");
        Console.WriteLine("   ├ Pulse cualquier tecla para continuar...                                │");
        Console.WriteLine("   └────────────────────────────────────────────────────────────────────────┘ ×");     
    }
    
    //Impresion
    
    //Listado de eventos
    public static void ImprimirEventos(SalonDeFiesta s)
        {    	
    	ArrayList listaEventos = s.TodosEventos();	
            foreach (Evento e in listaEventos)
            {
                Console.WriteLine();
                Console.WriteLine("┌ Fecha: " + e.Fecha.Day + "/" + e.Fecha.Month + "/" + e.Fecha.Year+" | "+e.Fecha.Hour+":"+e.Fecha.Minute);
                Console.WriteLine("├ Encargado: " + e.EncargadoLegajo);
                Console.WriteLine("├ Costo: $" + e.CostoTotal);
                Console.WriteLine("└ Tipo: " + e.Tipo);
            }
        }


    //Listado de clientes
    public static void ImprimirClientes(SalonDeFiesta s)
        {
    	ArrayList listaEventos = s.TodosEventos();
        	
            foreach (Evento e in listaEventos)
            {
                Console.WriteLine();
                Console.WriteLine("┌ Cliente: " + e.NombreCliente);
                Console.WriteLine("└ Dni: " + e.DniCliente);
            }

        }



     //Listado de empleados
     public static void ImprimirEmpleados(SalonDeFiesta s){      	
     	ArrayList listaEmpleados = s.TodosEmpleados();
        	
            Empleado temp = new Empleado();
            
            foreach (Empleado e in listaEmpleados)
            {
                Console.WriteLine();
                //Encargado temp = e;
                var temp2 = e.GetType();
                if (temp2 == temp.GetType()) { Console.WriteLine("× Empleado ×"); }
                else { Console.WriteLine("× Encargado ×"); }

                Console.WriteLine("┌ Nombre: " + e.Nombre + " " + e.Apellido);
                Console.WriteLine("└ Legajo: " + e.Legajo);
            }
        }


     //Listado de eventos en un mes especifico
     public static void ImprimirEventosMes(int mes,SalonDeFiesta s)
        {
     	ArrayList listaEventos = s.TodosEventos();        	
            foreach (Evento e in listaEventos)
            {
                if (e.Fecha.Month == mes)
                {
                    Console.WriteLine();
                    Console.WriteLine("┌ Fecha: " + e.Fecha.Day + "/" + e.Fecha.Month + "/" + e.Fecha.Year);
                    Console.WriteLine("├ Encargado: "+e.EncargadoLegajo);
                    Console.WriteLine("└ Tipo: " + e.Tipo);
                }
            }
        }
}

    

    
