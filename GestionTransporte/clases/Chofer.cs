using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransporte.clases
{
    public class Chofer
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        int num_legajo;
        string nombre;
        string num_cedula;
        string domicilio;
        string telefo1;
        string telefo2;
        string estado;

        #region encapsulamiento de propiedades
        public int Num_legajo
        {
            get { return num_legajo; }
            set { num_legajo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Num_cedula
        {
            get { return num_cedula; }
            set { num_cedula = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Telefo1
        {
            get { return telefo1; }
            set { telefo1 = value; }
        }
        public string Telefo2
        {
            get { return telefo2; }
            set { telefo2 = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

    }
}
