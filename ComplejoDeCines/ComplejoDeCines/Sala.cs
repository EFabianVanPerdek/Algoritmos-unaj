using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoDeCines
{
    public class Sala
    {
        private string Sede;
        private int Numero;
        private int Capacidad;
        private int CantEntVendidas;

        public Sala(string sede, int numero, int capacidad, int cantvendidas)
        {
            this.Sede = sede;
            this.Numero = numero;
            this.Capacidad = capacidad;
            this.CantEntVendidas = cantvendidas;
        }
        public string sede { set{ Sede = value; }get{ return Sede; } }
        public int numero { set{ Numero = value; }get{ return Numero; } }
        public int capacidad { set { Capacidad = value; } get { return Capacidad; } }
        public int cantentvendidas { set { CantEntVendidas = value; } get { return CantEntVendidas; } }
    }
}
