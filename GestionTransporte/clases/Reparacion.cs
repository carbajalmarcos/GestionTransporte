using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransporte.clases
{
    public class Reparacion
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        Camion camion;
        int num_legajo;
        DateTime entrada_taller;
        DateTime salida_taller;
        DateTime salida_aprox;
        string observaciones;

        #region encapsulamiento de propiedades
        public Camion Camion
        {
            get { return camion; }
            set { camion = value; }
        }
        public int Num_legajo
        {
            get { return num_legajo; }
            set { num_legajo = value; }
        }
        public DateTime Entrada_taller
        {
            get { return entrada_taller; }
            set { entrada_taller = value; }
        }
        public DateTime Salida_taller
        {
            get { return salida_taller; }
            set { salida_taller = value; }
        }
        public DateTime Salida_aprox
        {
            get { return salida_aprox; }
            set { salida_aprox = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        #endregion
    }
}
