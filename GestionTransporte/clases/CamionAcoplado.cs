using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionTransporte.CLASES;

namespace GestionTransporte.clases
{
    public class CamionAcoplado
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        Camion camion;
        Acoplado acoplado;

        #region encapsulamiento de propiedades
        public Camion Camion
        {
            get { return camion; }
            set { camion = value; }
        }
        public Acoplado Acoplado
        {
            get { return acoplado; }
            set { acoplado = value; }
        }
        #endregion
    }
}
