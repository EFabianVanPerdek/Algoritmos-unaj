using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionVeterinariaMascota
{
    class ClaseVeterinaria
    {
        private string NombreVeterinaria;
        //private ArrayList ListaMascotas;
        private ClaseMascota[] ListaMascotas;
        private int CantidadMascotas;
        
        public ClaseVeterinaria(string nombrevet)//constructor
        /*El constructor es el lugar para instanciar la lista de mascotas.
        Allí se hace el new. NO se recibe NUNCA como parámetro del constructor  la lista.*/
        {
            this.NombreVeterinaria = nombrevet;
            //ListaMascotas = new ArrayList();
            ListaMascotas = new ClaseMascota[100];
            CantidadMascotas = 0;
        }
        //propiedades
        public string NombreVet
        {
            set { NombreVeterinaria = value; }
             get{ return NombreVeterinaria; }
        }
        public int CantMasc
        {
            set { CantidadMascotas = value; }
            get { return CantidadMascotas; }
        }
        public ClaseMascota [] Lista
        {
            get { return ListaMascotas; }//se agrega propiedad de solo lectura
        }

        public void AgregarMascotas(ClaseMascota UnaMascota)
        {
            int posicion = CantidadMascotas;/*obtiene última posición libre*/
            ListaMascotas[posicion] = UnaMascota;/* asigna en esa posición*/
            CantidadMascotas += 1;
        }
        public void AtenderMascotas(string NombreMascota, string NombreDueño, string NuevoDiagnostico)
        {/*dada una mascota y dueño, la busca y le pone su nuevo diagnóstico*/
        for(int j = 0; j < CantidadMascotas; j++)
            {
                ClaseMascota M = (ClaseMascota)ListaMascotas[j]; /*toma una Mascota*/
                if ((M.nombremascota == NombreMascota) && (M.dueño == NombreDueño)) { M.diagnostico = NuevoDiagnostico; break; }
            }
        /*Como Veterinaria es un objeto compuesto, al acceder a una mascota,
        deben aplicarse las propiedades de dicha clase. No se pueden usar las variables de instancia de mascota directamente.*/
        }
        public ClaseMascota VerDatosMascota(int posicion) { return ListaMascotas[posicion]; }
        //devuelve los datos de la mascota con los datos de la posicion
        public void EliminarMascota(ClaseMascota UnaMascota) 
        {
            int posicion = Array.IndexOf(ListaMascotas, UnaMascota);// busca la posición de la mascota a borrar
            for (int k = posicion; k < CantidadMascotas; k++)
            //en un Array no se pueden borrar elementos, hacemos corrimiento de elementos
            { ListaMascotas[k] = ListaMascotas[k + 1]; }
            ListaMascotas[CantidadMascotas] = null;//limpio la última posición 
            CantidadMascotas = CantidadMascotas - 1;
        }
        public void TotalMascotas()
        {for(int i=0; i < ListaMascotas.Length; i++)
            {
                Console.WriteLine("la cantidad de mascotas son " + i); 
            }
        }

    }

}
