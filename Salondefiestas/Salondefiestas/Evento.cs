using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
{
    public class Evento
    {   //atributos
        private string NombreCliente;
        private int DNICliente;
        private DateTime FechaHoraEvento;
        private string TipoEvento;
        private Encargado Encargado;
        private List<Servicio> ServiciosContratados = new List<Servicio>();//lista para cargar los servicios que se cargan a un evento
        private int CostoTotal;
        private double Senia; 

        // Constructor
        public Evento(string nombreCliente, int dniCliente, DateTime fechaHoraEvento, string tipoEvento)
        {
            NombreCliente = nombreCliente;
            DNICliente = dniCliente;
            FechaHoraEvento = fechaHoraEvento;
            TipoEvento = tipoEvento;
        }
        //propiedades
        public string nombrecliente { set { NombreCliente = value; } get { return NombreCliente; } }
        public int DNIcliente { set { DNICliente = value; } get { return DNICliente; } }
        public DateTime fechaHoraevento { set { FechaHoraEvento = value; } get { return FechaHoraEvento; } }
        public string tipoEvento { set { TipoEvento = value; } get { return TipoEvento; } }
        public Encargado encargado { set { Encargado = value; } get { return Encargado; } }
        public List<Servicio> serviciosContratados { set { ServiciosContratados = value; } get { return ServiciosContratados; } }
        public int costoTotal { set { CostoTotal = value; } get { return CostoTotal; } }
        public double senia { set { Senia = value; } get { return Senia; } }

        // Metodo para calcular el costo total del evento
        public void CalcularCostoTotal()
        {
            CostoTotal = 0;
            foreach (Servicio servicio in ServiciosContratados)
            {
                CostoTotal += servicio.cantidadsolicitada * servicio.costounitario;
            }
        }

        // Sobrecarga del metodo ToString() para mostrar la informacion del evento, conviertiendo los datos del objeto en string
        public override string ToString()
        {
            return $"Nombre del cliente: {NombreCliente}\n" +
                   $"DNI del cliente: {DNICliente}\n" +
                   $"Fecha y hora del evento: {FechaHoraEvento:dd/MM/yyyy HH:mm}\n" +
                   $"Tipo de evento: {TipoEvento}\n" +
                   $"Encargado: {Encargado}\n" +
                   $"Servicios contratados:\n" + string.Join("\n", ServiciosContratados) +
                   $"\nCosto total: $ {CostoTotal}\n" +
                   $"Seña: $ {Senia}";
        }

    }
}
