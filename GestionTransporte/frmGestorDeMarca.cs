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
    public partial class frmGestorDeMarca : Form
    {

        Marca_camion marca;
        public frmGestorDeMarca(Login conexion)
        {
            InitializeComponent();
            this.marca = new Marca_camion(conexion);
        }

        private void frmGestorDeMarca_Load(object sender, EventArgs e)
        {
            dgvMarcas.DataSource = marca.ver_marcas();
            if (dgvMarcas.Rows.Count < 1)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String resp;
            if(sender==btnAgregar)
            {
                if (tbAgregar.Text.Trim() == string.Empty)
                {
                    tbAgregar.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbAgregar.BackColor = Color.White;
                    marca.Marca = tbAgregar.Text.ToUpper().Trim(); ;
                    resp = marca.insertar();
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvMarcas.DataSource = marca.ver_marcas();
                    if (dgvMarcas.Rows.Count < 1)
                    {
                        tbModificar.Enabled = false;
                        tbEliminar.Enabled = false;
                    }
                    tbAgregar.Clear();
                }     
            }
            
            if(sender==btnModificar)
            {

                if (tbModificar.Text.Trim() == string.Empty)
                {
                    tbModificar.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbModificar.BackColor = Color.White;
                    marca.Marca = tbModificar.Text.ToUpper().Trim() ;
                    resp = marca.modificar(dgvMarcas.CurrentCell.Value.ToString());
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvMarcas.DataSource = marca.ver_marcas();

                }
           
             
            }
            if (sender == btnEliminar)
            {
                tbAgregar.BackColor = Color.White;
                tbModificar.BackColor = Color.White;
                marca.Marca = tbEliminar.Text;
                resp = marca.eliminar();
                if (resp != String.Empty)
                    MessageBox.Show(resp);
                else
                {
                    tbEliminar.Clear();
                    tbModificar.Clear();
                }
                dgvMarcas.DataSource = marca.ver_marcas();
                if (dgvMarcas.Rows.Count < 1)
                {
                    tbModificar.Enabled = false;
                    tbEliminar.Enabled = false;
                }

            }
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModificar.Text = dgvMarcas.CurrentCell.Value.ToString();
            tbEliminar.Text = dgvMarcas.CurrentCell.Value.ToString();
        }

       private void dgvMarcas_DataSourceChanged(object sender, EventArgs e)
       {
            if (dgvMarcas.RowCount != 0)
            {
                tbModificar.Text = dgvMarcas.CurrentCell.Value.ToString();
                tbEliminar.Text = dgvMarcas.CurrentCell.Value.ToString();
            }
       }
    }
}
