using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransporte.clases
{
    public class Auditoria
    {
        DateTime fecha_hs;
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        string accion;

        #region encapsulamiento de propiedades
        public DateTime Fecha_hs
        {
            get { return fecha_hs; }
            set { fecha_hs = value; }
        }
        public Login Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }
        #endregion
    }
}
