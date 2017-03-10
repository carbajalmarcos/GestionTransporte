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
    public partial class frmCargaAcoplado : Form
    {
        Acoplado acoplado,acopladoMod;
        Marca_camion marca;
        Tipo_acoplado tipo_acoplado;
        Login conexion;
        public frmCargaAcoplado(Login conexion, Acoplado acopladoMod)
        {
            InitializeComponent();
            this.conexion = conexion;
            acoplado = new Acoplado(conexion);
            marca = new Marca_camion(conexion);
            tipo_acoplado = new Tipo_acoplado(conexion);
            this.acopladoMod = acopladoMod;
        }

        private void btnGuardar_unidad_Click(object sender, EventArgs e)
        {
            if (acoplado.Busqueda_dominio(tbDominio.Text.Trim(), true).Rows.Count > 0)
            {
                MessageBox.Show("YA EXISTE UNA UNIDAD CON ESE DOMINIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDominio.BackColor = Color.OrangeRed;
            }
            else if (acoplado.Busqueda_chasis(tbNro_chasis.Text.Trim(), true).Rows.Count > 0)
            {

                tbDominio.BackColor = Color.White;
                MessageBox.Show("YA EXISTE UNA UNIDAD CON ESE Nº CHASIS YA EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNro_chasis.BackColor = Color.OrangeRed;
            }
            else if( !new Funciones().Valida_Controles(this))
            {
                MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                if (acopladoMod != null)
                {
                    int marcaID = marca.retornaID_marca(cbMarca.SelectedItem.ToString().ToUpper().Trim());
                    int tipo_acopladoID = tipo_acoplado.retornaID_tipoAcoplado(cbTipo.SelectedItem.ToString().ToUpper().Trim());
                    acoplado.Dominio = tbDominio.Text.ToUpper().Trim();
                    acoplado.Marca = marcaID;
                    acoplado.Modelo = tbModelo.Text.ToUpper().Trim();
                    acoplado.Año = tbAño.Text.ToUpper().Trim();
                    acoplado.Tara = float.Parse(tbTara.Text.ToUpper().Trim());
                    acoplado.Tipo = tipo_acopladoID;
                    acoplado.Alt_total = float.Parse(tbAlt_total.Text.ToUpper().Trim());
                    acoplado.Nro_chasis = tbNro_chasis.Text.ToUpper().Trim();
                    acoplado.Ancho_interior = float.Parse(tbAncho_interior.Text.ToUpper().Trim());
                    acoplado.Ancho_exterior = float.Parse(tbAncho_exterior.Text.ToUpper().Trim());
                    acoplado.Long_plataforma = float.Parse(tbLong_plataforma.Text.ToUpper().Trim());
                    acoplado.Capacidad_carga = float.Parse(tbCapacidad_carga.Text.ToUpper().Trim());
                    acoplado.Cant_de_ejes = float.Parse(tbCant_de_ejes.Text.ToUpper().Trim());
                    acoplado.Fecha_alta = acopladoMod.Fecha_alta;
                    acoplado.Fecha_baja = acopladoMod.Fecha_baja;
                    acoplado.Observaciones = tbObservaciones.Text.ToUpper().Trim();
                    acoplado.Estado = acopladoMod.Estado;
                    acoplado.modificar(acoplado.Dominio.ToString().Trim());
                    MessageBox.Show("ACOPLADO INSERTADO CON EXITO", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int marcaID = marca.retornaID_marca(cbMarca.SelectedItem.ToString().ToUpper().Trim());
                    int tipo_acopladoID = tipo_acoplado.retornaID_tipoAcoplado(cbTipo.SelectedItem.ToString().ToUpper().Trim());
                    acoplado.Dominio = tbDominio.Text.ToUpper().Trim();
                    acoplado.Marca = marcaID;
                    acoplado.Modelo = tbModelo.Text.ToUpper().Trim();
                    acoplado.Año = tbAño.Text.ToUpper().Trim();
                    acoplado.Tara = float.Parse(tbTara.Text.ToUpper().Trim());
                    acoplado.Tipo = tipo_acopladoID;
                    acoplado.Alt_total = float.Parse(tbAlt_total.Text.ToUpper().Trim());
                    acoplado.Nro_chasis = tbNro_chasis.Text.ToUpper().Trim();
                    acoplado.Ancho_interior = float.Parse(tbAncho_interior.Text.ToUpper().Trim());
                    acoplado.Ancho_exterior = float.Parse(tbAncho_exterior.Text.ToUpper().Trim());
                    acoplado.Long_plataforma = float.Parse(tbLong_plataforma.Text.ToUpper().Trim());
                    acoplado.Capacidad_carga = float.Parse(tbCapacidad_carga.Text.ToUpper().Trim());
                    acoplado.Cant_de_ejes = float.Parse(tbCant_de_ejes.Text.ToUpper().Trim());
                    acoplado.Fecha_alta = DateTime.Now.ToString();
                    acoplado.Fecha_baja = null;
                    acoplado.Observaciones = tbObservaciones.Text.Trim();
                    acoplado.Estado = "DISPONIBLE";
                    acoplado.insertar();
                  
                  
                    MessageBox.Show("ACOPLADO MODIFICADO CON EXITO", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            acoplado.carga_acoplados_total();
            tbDominio.Clear();
            tbModelo.Clear();
            tbAño.Clear();
            tbTara.Clear();
            tbAlt_total.Clear();
            tbNro_chasis.Clear();
            tbAncho_exterior.Clear();
            tbAncho_interior.Clear();
            tbLong_plataforma.Clear();
            tbCapacidad_carga.Clear();
            tbCant_de_ejes.Clear();
            tbObservaciones.Clear();
       
        }

        private void gestionarTiposDeAcopladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTipoAcoplado(conexion).ShowDialog();
        }

        private void gestionarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGestorDeMarca(conexion).ShowDialog();
        }

        private void frmCargaAcoplado_Load(object sender, EventArgs e)
        {
            cbMarca.Items.Add("SELECCIONE MARCA");
            cbTipo.Items.Add("SELECCIONE TIPO");
            tbDominio.Enabled = true;
            SqlConnection cn = conexion.cnn;
            cn.Open();
            SqlCommand cmdMarca = new SqlCommand("Select * From marca", cn);
            SqlDataReader drMarca = cmdMarca.ExecuteReader();
            while (drMarca.Read())
            {
                cbMarca.Items.Add(drMarca["marca"]);
            }
            cn.Close();
            cn.Open();
            SqlCommand cmdTipo = new SqlCommand("Select * From tipo_acoplado", cn);
            SqlDataReader drTipo = cmdTipo.ExecuteReader();
            while (drTipo.Read())
            {
                cbTipo.Items.Add(drTipo["tipo"]);
            }
            cn.Close();
            if(acopladoMod!=null)
            {
                string marca_acoplado = marca.retornaMarca(acopladoMod.Marca);
                string tipoAcoplado = tipo_acoplado.retornaTipoAcoplado(acopladoMod.Tipo);
                tbDominio.Enabled = false;
                tbDominio.Text = acopladoMod.Dominio;
                cbMarca.SelectedItem = marca_acoplado;
                tbModelo.Text = acopladoMod.Modelo.ToString();
                tbAño.Text = acopladoMod.Año.ToString();
                tbTara.Text = acopladoMod.Tara.ToString();
                cbTipo.SelectedItem = tipoAcoplado;
                tbAlt_total.Text = acopladoMod.Alt_total.ToString();
                tbNro_chasis.Text = acopladoMod.Nro_chasis;
                tbAncho_interior.Text = acopladoMod.Ancho_interior.ToString();
                tbAncho_exterior.Text = acopladoMod.Ancho_exterior.ToString();
                tbLong_plataforma.Text = acopladoMod.Long_plataforma.ToString();
                tbCapacidad_carga.Text = acopladoMod.Capacidad_carga.ToString();
                tbCant_de_ejes.Text = acopladoMod.Cant_de_ejes.ToString();
                tbObservaciones.Text = acopladoMod.Observaciones;
            }
            cbMarca.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;

           
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
