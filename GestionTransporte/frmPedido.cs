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
    public partial class frmPedido : Form
    {
        Login conexion;
        Pedido pedido;
        public frmPedido(Login conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            pedido = new Pedido(conexion);
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pedido.ver_pedidos();
            if (dgvPedidos.Rows.Count < 1)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String resp;
            if (sender == btnAgregar)
            {
                if (tbDescripcion.Text.Trim() == string.Empty)
                {
                    tbDescripcion.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbDescripcion.BackColor = Color.White;
               
                    pedido.Observaciones = tbDescripcion.Text.ToUpper();
                    pedido.Estado = "PENDIENTE";
                    resp = pedido.insertar_pedido();
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvPedidos.DataSource = pedido.ver_pedidos();
                    tbDescripcion.Clear();
                    dtpFecha_prevista.Value = DateTime.Now;
                }
            }

            if (sender == btnModificar)
            {
                if (tbDescripcion.Text.Trim() == string.Empty)
                {
                    tbDescripcion.BackColor = Color.OrangeRed;
                    MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbDescripcion.BackColor = Color.White;
                    pedido.Fecha_pedido = DateTime.Now;
                    pedido.Fecha_sal_aprox = dtpFecha_prevista.Value;
                    pedido.Observaciones = tbDescripcion.Text.ToUpper();
                    pedido.Estado = "PENDIENTE";
                    resp = pedido.modificar_pedido(Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value));
                    if (resp != String.Empty)
                        MessageBox.Show(resp);
                    dgvPedidos.DataSource = pedido.ver_pedidos();
                }
            }
            if (sender == btnEliminar)
            {
                if (dgvPedidos.CurrentRow.Cells[5].Value.ToString()=="PENDIENTE")
                {
                    pedido.Id_pedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value);
                    resp = pedido.cancelar_pedido();
                    if (resp != String.Empty)
                    {
                        MessageBox.Show(resp);
                    }
                }
                else if (dgvPedidos.CurrentRow.Cells[5].Value.ToString()!="PENDIENTE")
                {
                    MessageBox.Show("NO PUEDE DESAHABILITAR EL PEDIDO PORQUE SE ENCUENTRA EN TRANSCURSO");
                }
                else
                    MessageBox.Show("YA SE ENCUENTRA DESAHABILITADO EL PEDIDO SELECCIONADO");
                dgvPedidos.DataSource = pedido.ver_pedidos();
            }
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha_prevista.Value = DateTime.Parse(dgvPedidos.CurrentRow.Cells[2].Value.ToString());
            tbDescripcion.Text = dgvPedidos.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
