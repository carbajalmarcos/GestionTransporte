using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTransporte.clases;

namespace GestionTransporte
{
    public partial class frmTipoAcoplado : Form
    {
        Tipo_acoplado tipo;
        public frmTipoAcoplado(Login conexion)
        {
            InitializeComponent();
            this.tipo = new Tipo_acoplado(conexion);
        }

   

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string resp;
  
            if (sender == btnAgregar)
            {
                if (tbAgregar.Text.Trim()==string.Empty)
                {
                    tbAgregar.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbAgregar.BackColor = Color.White;
                    tipo.Tipo = tbAgregar.Text.ToUpper().Trim();
                    resp = tipo.insertar();
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvTipo_Acoplado.DataSource = tipo.ver_tipoAcoplado();
                    tbAgregar.Clear();
                    tbModificar.Enabled = true;
                    tbEliminar.Enabled = true;

                }
                
            }
            if (sender == btnModificar)
            {
                if (tbModificar.Text.Trim() == string.Empty)
                {
                    tbModificar.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbModificar.BackColor = Color.White;
                    tipo.Tipo = tbModificar.Text.ToUpper().Trim(); ;
                    resp = tipo.modificar(dgvTipo_Acoplado.CurrentCell.Value.ToString());
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvTipo_Acoplado.DataSource = tipo.ver_tipoAcoplado();
                    if (dgvTipo_Acoplado.Rows.Count < 1)
                    {
                        tbModificar.Enabled = false;
                        tbEliminar.Enabled = false;
                    }
                }

               
            }
            if (sender == btnEliminar)
            {

                tipo.Tipo = tbEliminar.Text;
                resp = tipo.eliminar();
                if (resp != String.Empty)
                    MessageBox.Show(resp);
           
                dgvTipo_Acoplado.DataSource = tipo.ver_tipoAcoplado();
                if (dgvTipo_Acoplado.Rows.Count < 1)
                {
                    tbModificar.Enabled = false;
                    tbEliminar.Enabled = false;
                }

            }
                
        }

        private void dgvTipo_Acoplado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvTipo_Acoplado.RowCount != 0)
            {
                tbModificar.Text = dgvTipo_Acoplado.CurrentCell.Value.ToString();
                tbEliminar.Text = dgvTipo_Acoplado.CurrentCell.Value.ToString();
            }
        }

        private void dgvTipo_Acoplado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModificar.Text = dgvTipo_Acoplado.CurrentCell.Value.ToString();
            tbEliminar.Text = dgvTipo_Acoplado.CurrentCell.Value.ToString();
        }

        private void frmTipoAcoplado_Load(object sender, EventArgs e)
        {
            dgvTipo_Acoplado.DataSource = tipo.ver_tipoAcoplado();
            if (dgvTipo_Acoplado.Rows.Count < 1)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
    }
}
