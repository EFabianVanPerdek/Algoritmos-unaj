using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProyectoSalonDeFiesta
{
    public class Servicio
    {   //Atributos
        private string Nombre;
        private string Descripcion;
        private int CantidadSolicitada;
        private int CostoUnitario;
        // Constructor
        public Servicio(string nombre, string descripcion, int cantidadSolicitada, int costoUnitario)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            CantidadSolicitada = cantidadSolicitada;
            CostoUnitario = costoUnitario;
        }
        //Propiedades
        public string nombre { set{ Nombre = value; }get{ return Nombre; } }
        public string descripcion { set { Descripcion = value; } get { return Descripcion; } }
        public int cantidadsolicitada { set { CantidadSolicitada = value; } get { return CantidadSolicitada; } }
        public int costounitario { set { CostoUnitario = value; } get { return CostoUnitario; } }

        // Método para calcular el costo total del servicio
        public decimal CalcularCostoTotal()
        {
            return CantidadSolicitada * CostoUnitario;
        }

        // Método para actualizar la cantidad solicitada
        public void ActualizarCantidad(int nuevaCantidad)
        {
            CantidadSolicitada = nuevaCantidad;
        }

        // Método para actualizar el costo unitario
        public void ActualizarCostoUnitario(int nuevoCostoUnitario)
        {
            CostoUnitario = nuevoCostoUnitario;
        }

        // Sobrecarga del método ToString() para mostrar la información del servicio
        public override string ToString()
        {
            return $"Servicio: {Nombre}\n" +
                   $"Descripción: {Descripcion}\n" +
                   $"Cantidad: {CantidadSolicitada}\n" +
                   $"Costo unitario: {CostoUnitario:C2}\n" +
                   $"Costo total: {CalcularCostoTotal():C2}";
        }
    }
}
