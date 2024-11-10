using System;
using System.Collections;

namespace SalonDeEventos
{
    public class Evento
    {
        //Atributos

        private ArrayList Servicios; //Cargar a medida que se cargan los servicios
        private string nombreCliente;
        private int dniCliente;
        private DateTime fecha;
        
        private string tipo;
        private int encargadoLegajo; //Agregar con el metodo AgregarEncargado
        private int costoTotal; //calcular despues de los servicios cargados

        //constructores

        public Evento(string nombreCliente, int dniCliente, DateTime fecha, string tipo)
        {

            Servicios = new ArrayList();

            this.nombreCliente = nombreCliente;
            this.dniCliente = dniCliente;
            this.fecha = fecha;
            this.tipo = tipo;

        }

        //Properties

        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }

        public int DniCliente
        {
            set
            {
                dniCliente = value;
            }

            get
            {
                return dniCliente;
            }
        }

        public DateTime Fecha
        {
            set
            {
                fecha = value;
            }

            get
            {
                return fecha;
            }
        }
        
        public string Tipo
        {
            set
            {
                tipo = value;
            }

            get
            {
                return tipo;
            }
        }

        public int EncargadoLegajo 
        { 
            get{return encargadoLegajo; }
            set{encargadoLegajo = value;}
        }
        
        public int CostoTotal 
        {
            set { costoTotal = value;}
            get { return costoTotal; } 
        }
        
        //metodos
       
        public bool AgregarServicio(Servicio s) { 
        	Servicios.Add(s);
        	return true;
        }
        
        public bool EliminarServicio(string tipo) 
        { 
        	
        	int c = 0;
        	Servicio s;
        	
        	if (Servicios.Count==0) {return false;}
        	
            foreach (Servicio e in Servicios) 
            { 
                if (e.Tipo == tipo) { 
            		s = e; Servicios.RemoveAt(c); 
            		return true; 
            	}
                c++;
            }
            return false;
        }

        public void CalcularCostoTotal() 
        {
            int resultado=0;
            foreach (Servicio e in Servicios) 
            {
                resultado = e.CostoFinal + resultado;
            }
            costoTotal = resultado;
        } 
		
        public Servicio VerServicio (int i)
        {
        	return (Servicio)Servicios[i];
        }
        
        public ArrayList todosServ()
        {
        	return Servicios;
        }
        

    }

}
