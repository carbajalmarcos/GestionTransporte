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
    public partial class frmTipoCamion : Form
    {
        Tipo_camion tipoCamion;
        public frmTipoCamion(Login conexion)
        {
            InitializeComponent();
            this.tipoCamion = new Tipo_camion(conexion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string resp;
     
                if (tbAgregar.Text.Trim() == string.Empty)
                {
                    tbAgregar.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else{

                tipoCamion.Tipo = tbAgregar.Text.ToUpper().Trim();
                resp = tipoCamion.insertar();
                if (resp != String.Empty)
                    MessageBox.Show(resp);
                dgvTipoCamion.DataSource = tipoCamion.ver_tipoCamion();
                if (dgvTipoCamion.Rows.Count < 1)
                {
                    tbModificar.Enabled = false;
                    tbEliminar.Enabled = false;
                }

                tbAgregar.Clear();
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
                    tbModificar.BackColor=Color.White;
                    tipoCamion.Tipo = tbModificar.Text.ToUpper().Trim(); ;
                    resp = tipoCamion.modificar(dgvTipoCamion.CurrentCell.Value.ToString());
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvTipoCamion.DataSource = tipoCamion.ver_tipoCamion();
                }
              

            }
            if (sender == btnEliminar)
            {
                tbAgregar.BackColor = Color.White;
                tbModificar.BackColor = Color.White;
                tipoCamion.Tipo = tbEliminar.Text;
                resp = tipoCamion.eliminar();
                if (resp != String.Empty)
                    MessageBox.Show(resp);
                else
                {
                    tbEliminar.Clear();
                    tbModificar.Clear();
                }
                dgvTipoCamion.DataSource = tipoCamion.ver_tipoCamion();
                if (dgvTipoCamion.Rows.Count < 1)
                {
                    tbModificar.Enabled = false;
                    tbEliminar.Enabled = false;
                }
                
            }
        }

        private void frmTipoCamion_Load(object sender, EventArgs e)
        {
            dgvTipoCamion.DataSource = tipoCamion.ver_tipoCamion();
            if (dgvTipoCamion.Rows.Count < 1)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void dgvTipoCamion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModificar.Text = dgvTipoCamion.CurrentCell.Value.ToString();
            tbEliminar.Text = dgvTipoCamion.CurrentCell.Value.ToString();
        }

        private void dgvTipoCamion_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvTipoCamion.RowCount != 0)
            {
                tbModificar.Text = dgvTipoCamion.CurrentCell.Value.ToString();
                tbEliminar.Text = dgvTipoCamion.CurrentCell.Value.ToString();
            }
         
        }
    }
}
