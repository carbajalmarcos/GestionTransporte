using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace GestionTransporte.clases
{
    public class Funciones
    {
        public bool Valida_Controles(Control form)
        {
            bool validado=true;//retorna falso si algun campo esta vacio o un combobox en indice cero
            foreach (Control control in form.Controls)
            {
                if (control is TextBox && (control as TextBox).Name!="tbObservaciones" )
                {
                    if (control.Text.Trim() == string.Empty)
                    {
                        control.BackColor = Color.OrangeRed;
                        validado = false;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                        
                    }
                }
                if (control is ComboBox)
                {
                    if ((control as ComboBox).SelectedIndex == 0)
                    {
                        control.BackColor = Color.OrangeRed;
                        (control as ComboBox).FlatStyle = FlatStyle.Flat;
                        
                    }
                    else
                    {
                        control.BackColor = Color.White;
                        (control as ComboBox).FlatStyle =FlatStyle.System;
                    }
                }
            }
            return validado;
        }

        public void fondoBlanco_Controles(Object control)
        {
            if(control is TextBox)
            {
                var tb = control as TextBox;
                tb.BackColor = Color.White;
            }
            if(control is ComboBox)
            {
                var cb = control as ComboBox;
                cb.BackColor = Color.White;
                cb.FlatStyle = FlatStyle.System;
            }
        }
    }
}
