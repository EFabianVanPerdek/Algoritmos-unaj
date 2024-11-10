using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmorecursivo
{
    public class Coordinador:Profesor
    {
        private string Area;

        public Coordinador(string nombre, int dni, int legajo, string materia, string area) : base( nombre, dni, legajo, materia)
        {
            this.Area=area;
        }
        public string area { set{ Area = value; }get{ return Area; } }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Profesor: {Nombre} Dni: {dni } Legajo: {legajo} Materia: {materia} Area: {Area}");         
        }
    }
}
