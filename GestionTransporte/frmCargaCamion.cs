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
using System.Data.SqlClient;

namespace GestionTransporte
{
    public partial class frmCargaCamion : Form
    {

        Camion camion,camionModifica;
        Marca_camion marca;
        Tipo_camion tipo_camion;
        Login conexion;
        public frmCargaCamion(Login conexion,Camion camionModifica)
        {
            InitializeComponent();
            this.conexion = conexion;
            camion = new Camion(conexion);
            this.camionModifica = camionModifica;
            marca = new Marca_camion(conexion);
            tipo_camion = new Tipo_camion(conexion);
        }

        private void agregarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGestorDeMarca(conexion).ShowDialog();
        }

        private void gestionarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTipoCamion(conexion).ShowDialog();
        }

        private void frmCargaCamion_Load(object sender, EventArgs e)
        {
            cbMarca.Items.Add("SELECCIONE MARCA");
            cbTipo.Items.Add("SELECCIONE TIPO");
            tbDominio.Enabled = true;
            SqlConnection cn = conexion.cnn;
            cn.Open();
            SqlCommand cmdMarca = new SqlCommand("Select * From marca", cn);
            SqlDataReader drMarca = cmdMarca.ExecuteReader();
            while(drMarca.Read())
            {
                cbMarca.Items.Add(drMarca["marca"]);
            }
            cn.Close();
            cn.Open();
            SqlCommand cmdTipo = new SqlCommand("Select * From tipo_camion", cn);
            SqlDataReader drTipo = cmdTipo.ExecuteReader();
            while (drTipo.Read())
            {
                cbTipo.Items.Add(drTipo["tipo"]);
            }
            cn.Close();
            if(camionModifica!=null)
            {
                string marca_camion=marca.retornaMarca(camionModifica.Marca);
                string tipoCamion=tipo_camion.retornaTipoCamion(camionModifica.Tipo);
                tbDominio.Enabled = false;
                tbDominio.Text = camionModifica.Dominio;
                cbMarca.SelectedItem = marca_camion;
                tbTara.Text = camionModifica.Tara.ToString();
                tbModelo.Text = camionModifica.Modelo.ToString();
                tbAño.Text = camionModifica.Año.ToString();
                cbTipo.SelectedItem = tipoCamion;
                tbNro_chasis.Text = camionModifica.Nro_chasis;
                tbNro_motor.Text = camionModifica.Nro_motor;
                tbAlt_total.Text = camionModifica.Alto_total.ToString();
                tbAncho_total.Text = camionModifica.Ancho_total.ToString();
                tbLong_total.Text = camionModifica.Long_total.ToString();
                tbObservaciones.Text = camionModifica.Observacion;
            }
            cbMarca.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
        }

        private void btnGuardar_unidad_Click(object sender, EventArgs e)
        {
            if (camion.Busqueda_dominio(tbDominio.Text.Trim(), true).Rows.Count>0)
            {
                MessageBox.Show("YA EXISTE UNA UNIDAD CON ESE DOMINIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDominio.BackColor = Color.OrangeRed;
            }else if(camion.Busqueda_chasis(tbNro_chasis.Text.Trim(),true).Rows.Count>0){

                tbDominio.BackColor = Color.White;
                MessageBox.Show("YA EXISTE UNA UNIDAD CON ESE Nº CHASIS YA EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNro_chasis.BackColor = Color.OrangeRed;
            }else if(camion.Busqueda_motor(tbNro_motor.Text.Trim(),true).Rows.Count>0){
                tbDominio.BackColor = Color.White;
                tbNro_chasis.BackColor = Color.White;

                MessageBox.Show("YA EXISTE UNA UNIDAD CON ESE Nº DE MOTOR YA EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNro_motor.BackColor = Color.OrangeRed;
            }
            else  if (!new Funciones().Valida_Controles(this))
            {
                MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (camionModifica != null)
                {
                    int marcaID = marca.retornaID_marca(cbMarca.SelectedItem.ToString().ToUpper().Trim());
                    int tipo_camionID = tipo_camion.retornaID_tipoCamion(cbTipo.SelectedItem.ToString().ToUpper().Trim());
                    camion.Dominio = tbDominio.Text.ToUpper().Trim();
                    camion.Marca = marcaID;
                    camion.Modelo = tbModelo.Text.ToUpper().Trim();
                    camion.Año = tbAño.Text.ToUpper().Trim();
                    camion.Tara = float.Parse(tbTara.Text.ToUpper().Trim());
                    camion.Tipo = tipo_camionID;
                    camion.Nro_chasis = tbNro_chasis.Text.ToUpper().Trim();
                    camion.Nro_motor = tbNro_motor.Text.ToUpper().Trim();
                    camion.Ancho_total = float.Parse(tbAncho_total.Text.ToUpper().Trim());
                    camion.Alto_total = float.Parse(tbAlt_total.Text.ToUpper().Trim());
                    camion.Long_total = float.Parse(tbLong_total.Text.ToUpper().Trim());
                    camion.Fecha_alta = camionModifica.Fecha_alta;
                    camion.Fecha_baja = camionModifica.Fecha_baja;
                    camion.Estado = camionModifica.Estado;
                    camion.Observacion = tbObservaciones.Text.Trim();
                    camion.modificar(camion.Dominio.ToString().Trim());
                    MessageBox.Show("CAMION INSERTADO CON EXITO", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int marcaID = marca.retornaID_marca(cbMarca.SelectedItem.ToString().ToUpper().Trim());
                    int tipo_camionID = tipo_camion.retornaID_tipoCamion(cbTipo.SelectedItem.ToString().ToUpper().Trim());
                    camion.Dominio = tbDominio.Text.ToUpper().Trim();
                    camion.Marca = marcaID;
                    camion.Modelo = tbModelo.Text.ToUpper().Trim();
                    camion.Año = tbAño.Text.ToUpper().Trim();
                    camion.Tara = float.Parse(tbTara.Text.ToUpper().Trim());
                    camion.Tipo = tipo_camionID;
                    camion.Nro_chasis = tbNro_chasis.Text.ToUpper().Trim();
                    camion.Nro_motor = tbNro_motor.Text.ToUpper().Trim();
                    camion.Ancho_total = float.Parse(tbAncho_total.Text.ToUpper().Trim());
                    camion.Alto_total = float.Parse(tbAlt_total.Text.ToUpper().Trim());
                    camion.Long_total = float.Parse(tbLong_total.Text.ToUpper().Trim());
                    camion.Fecha_alta = DateTime.Now.ToShortDateString();
                    camion.Fecha_baja = null;
                    camion.Estado = "DISPONIBLE";
                    camion.Observacion = tbObservaciones.Text.Trim();
                    camion.insertar();
                    MessageBox.Show("CAMION MODIFICADO CON EXITO", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbDominio.Clear();
                tbModelo.Clear();
                tbAño.Clear();
                tbTara.Clear();
                tbAlt_total.Clear();
                tbNro_chasis.Clear();
                tbNro_motor.Clear();
                tbAncho_total.Clear();
                tbLong_total.Clear();
                tbObservaciones.Clear();
                cbMarca.SelectedIndex = 0;
                cbTipo.SelectedIndex = 0;
            }

           
        }

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbDominio_TextChanged(object sender, EventArgs e)
        {
            new Funciones().fondoBlanco_Controles(sender);
        }

    }
}
