using System;
using System.Collections;

namespace SalonDeEventos
{
    public class SalonDeFiesta
    {
        //Atributos
        private string nombre;

        private ArrayList listaEmpleados;
        private ArrayList listaEventos;

        //Constructores
        public SalonDeFiesta(string nombre)
        {
            listaEmpleados = new ArrayList();
            listaEventos = new ArrayList();
            this.nombre = nombre;
        }


        //Metodos

        //Agrega empleado
        public bool AgregarEmpleado(Empleado empleado)

        {
           foreach (Empleado e in listaEmpleados) { 
        		if (e.Legajo == empleado.Legajo) { 
        			return false; 
        		} 
        	}
           
           listaEmpleados.Add(empleado); 
           return true;
        }
        //Elimina empleado
        public bool ElimEmpleado(Empleado empleado)
        {
            
            
            foreach(Empleado e in listaEmpleados)
            {
            	if (e.Legajo == empleado.Legajo){listaEmpleados.Remove(empleado);return true;}
            }
            
            return false;
        }

        //retorna la cantidad de empleados

        public int CantEmpleado()
        {
            return listaEmpleados.Count;
        }

        //Consulta si Existe el empleado

        public bool ExisteEmpleado(Empleado empleado)
        {
            foreach (Empleado e in listaEmpleados) { if (e.Legajo == empleado.Legajo) { return true; } }
            return false;
        }

        //Recupera el empleado

        public Empleado VerEmpleado(int legajo)
        {
            //
            foreach (Empleado e in listaEmpleados) { if (e.Legajo == legajo) { return (Empleado)e; } }
            //

            return null;
        }

        //recupera el encargado
        public Encargado VerEncargado(int legajo)
        {
            //
            foreach (Empleado e in listaEmpleados) { if (e.Legajo == legajo) { return (Encargado)e; } }
            //

            return null;
        }


        //Agrega evento
        public bool AgregarEvento(Evento evento)

        {
            DateTime Temp;
            foreach (Evento e in listaEventos){
            	if (e.Fecha == evento.Fecha){
            		throw new ReservaException();
            	}
            }
            foreach (Evento e in listaEventos){ 
            	Temp = e.Fecha; if (evento.Fecha == Temp){ 
            		throw new ReservaException();
            	}
            }
            //ASIGNAR ENCARADO
            listaEventos.Add(evento); return true;
        }
        //Elimina evento
        public bool ElimEvento(Evento evento)

       	{
            
        	int leg;
        	
        	
            Encargado temp = new Encargado();
            Encargado eliminar;
            var tipo = temp.GetType();
            
            
            foreach(Evento e in listaEventos)
            {
            	leg = e.EncargadoLegajo;
            	if (e.Fecha==evento.Fecha)
            	{
            		listaEventos.Remove(e);
            		foreach (Empleado f in listaEmpleados)
                    { 
            			if (tipo == f.GetType()) { 
            				if (f.Legajo==leg) {
            					eliminar=(Encargado)f;
            					Descender(eliminar);return true;
            				}
            			}           			
                    }
             	}
            }
            
            
            return false; 
        }
        

        //Devuelve el evento en una fecha determinada 
        public Evento VerificarFecha(DateTime fecha)
        {
            foreach (Evento e in listaEventos)
            { if (e.Fecha.Year == fecha.Year && e.Fecha.Month == fecha.Month && e.Fecha.Day == fecha.Day) { return e; } }

            return null;
        }

        //CAMBIAR UN OBJ EMPLEADO A ENCARGADO --> ASIGNANDO UN PLUS DE SUELDO que por defecto es de 10%
        public bool Ascender(Empleado empleado,string eventoEncargo) 
        {
            Encargado temp;

            if (ElimEmpleado(empleado))
            {
                string nombre = empleado.Nombre;
                string apellido = empleado.Apellido;
                int dni = empleado.Dni;
                int legajo = empleado.Legajo;
                double sueldo = empleado.Sueldo;
                string tarea = empleado.Tarea;

                temp = new Encargado(nombre, apellido, dni, legajo, sueldo, tarea, 10);
                temp.EventoEncargado = eventoEncargo;

                AgregarEmpleado(temp);
                return true;
            }

            return false;
        }

        //CAMBIAR UN OBJ ENCARGADO A EMPLEADO, UNA VEZ QUE SE ELIMINA UN EVENTO YA CARGADO
        public bool Descender(Encargado encargado) 
        {
            Empleado temp;

            if (ElimEmpleado(encargado))
            {
                string nombre = encargado.Nombre;
                string apellido = encargado.Apellido;
                int dni = encargado.Dni;
                int legajo = encargado.Legajo;
                double sueldo = (encargado.Sueldo);//-(encargado.Sueldo*0.1); //Se baja el sueldo ya que no es encargado y pasa a ser un empleado normal
                
                string tarea = encargado.Tarea;

                temp = new Empleado(nombre,apellido,dni,legajo,sueldo,tarea);
                AgregarEmpleado(temp);

                return true;
            }

            return false;

        }

        //Empleados libres --> Si hay por lo menos un empleado devuelve true ya que puede tomar un evento como encargado

        public bool EmpleadosLibres() 
        {

            
            if (listaEmpleados.Count == 0) {return false;}
                        
            Empleado temp2 = new Empleado();

            foreach (Empleado e in listaEmpleados) 
            {
                var temp = e.GetType();
                if (temp == temp2.GetType()) { return true;}
            }

            return false;
        }

        //Asigna un encargado al evento

        public void AsignarEncargadoEvento(Evento eventot) 
        {
            Empleado temp = new Empleado();
            foreach (Empleado e in listaEmpleados) { 
            	var temp2 = e.GetType(); 
            	if (temp.GetType() == temp2) { 
            		temp = e;
            	}
            }
            Ascender(temp, eventot.Tipo); 
            eventot.EncargadoLegajo = temp.Legajo;
        }
        
        public ArrayList TodosEventos()
        {
        	return listaEventos;
        }
                  
        public ArrayList TodosEmpleados()
        {
        	return listaEmpleados;
        }
        
        public Evento VerEvento(int i)
        {
         return (Evento)listaEventos[i];
        }

    }
}
