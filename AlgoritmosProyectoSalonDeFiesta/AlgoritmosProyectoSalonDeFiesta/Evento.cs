using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
    public class Evento
    {   //Atributos
        private string NombreCliente;
        private string DNICliente;
        private DateTime FechaHoraEvento;
        private string TipoEvento;
        private Encargado Encargado;
        private static List<Servicio> ServiciosContratados;
        private int CostoTotal;
        private double Senia;

        // Constructor
        public Evento(string nombreCliente, string dniCliente, DateTime fechaHoraEvento, string tipoEvento)
        {
            NombreCliente = nombreCliente;
            DNICliente = dniCliente;
            FechaHoraEvento = fechaHoraEvento;
            TipoEvento = tipoEvento;
            ServiciosContratados = new List<Servicio>();
        }
        //Propiedades
        public string nombrecliente { set{ NombreCliente = value; }get{ return NombreCliente; } }
        public string DNIcliente { set { DNICliente = value; } get { return DNICliente; } }
        public DateTime fechaHoraevento { set { FechaHoraEvento = value; } get { return FechaHoraEvento; } }
        public string tipoEvento { set { TipoEvento = value; } get { return TipoEvento; } }
        public Encargado encargado { set { Encargado = value; } get { return Encargado; } }
        public static List<Servicio> serviciosContratados { set { ServiciosContratados = value; } get { return ServiciosContratados; } }
        public int costoTotal { set { CostoTotal = value; } get { return CostoTotal; } }
        public double senia { set { Senia = value; } get { return Senia; } }
        // Método para calcular el costo total del evento
        public void CalcularCostoTotal()
        {
            CostoTotal = 0;
            foreach (Servicio servicio in serviciosContratados)
            {
                CostoTotal += servicio.cantidadsolicitada * servicio.costounitario;
            }
        }

        // Sobrecarga del método ToString() para mostrar la información del evento
        public override string ToString()
        {
            return $"Nombre del cliente: {NombreCliente}\n" +
                   $"DNI del cliente: {DNICliente}\n" +
                   $"Fecha y hora del evento: {FechaHoraEvento:dd/MM/yyyy HH:mm}\n" +
                   $"Tipo de evento: {TipoEvento}\n" +
                   $"Encargado: {Encargado}\n" +
                   $"Servicios contratados:\n" + string.Join("\n", serviciosContratados) +
                   $"\nCosto total: {CostoTotal:C2}\n" +
                   $"Seña: {Senia:C2}";
        }

    }
}
