using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salondefiestas
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
            public string nombre { set { Nombre = value; } get { return Nombre; } }
            public string descripcion { set { Descripcion = value; } get { return Descripcion; } }
            public int cantidadsolicitada { set { CantidadSolicitada = value; } get { return CantidadSolicitada; } }
            public int costounitario { set { CostoUnitario = value; } get { return CostoUnitario; } }

            // Metodo para calcular el costo total del servicio
            public int CalcularCostoTotal()
            {
                return CantidadSolicitada * CostoUnitario;
            }

            // Metodo para actualizar la cantidad solicitada
            public void ActualizarCantidad(int nuevaCantidad)
            {
                CantidadSolicitada = nuevaCantidad;
            }

            // Metodo para actualizar el costo unitario
            public void ActualizarCostoUnitario(int nuevoCostoUnitario)
            {
                CostoUnitario = nuevoCostoUnitario;
            }

            // Sobrecarga del metodo ToString() para mostrar la información del servicio, conviertiendo los datos del objeto en string
            public override string ToString()
            {
                return $"Servicio: {Nombre}\n" +
                       $"Descripción: {Descripcion}\n" +
                       $"Cantidad: {CantidadSolicitada}\n" +
                       $"Costo unitario: ${CostoUnitario}\n" +
                       $"Costo total: $ {CalcularCostoTotal()}";
            }
        }
}

