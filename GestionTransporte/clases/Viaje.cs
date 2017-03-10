using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransporte.clases
{
    public class Viaje
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        Camion camion;
        DateTime fecha_salida;
        DateTime fecha_entrada;
        DateTime fecha_regreso_aprox;
        float peso_carga;
        string observaciones;

        #region encapsulamiento de propiedades
        public Camion Camion
        {
            get { return camion; }
            set { camion = value; }
        }
        public DateTime Fecha_salida
        {
            get { return fecha_salida; }
            set { fecha_salida = value; }
        }
        public DateTime Fecha_entrada
        {
            get { return fecha_entrada; }
            set { fecha_entrada = value; }
        }
        public DateTime Fecha_regreso_aprox
        {
            get { return fecha_regreso_aprox; }
            set { fecha_regreso_aprox = value; }
        }
        public float Peso_carga
        {
            get { return peso_carga; }
            set { peso_carga = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        #endregion
    }
}
