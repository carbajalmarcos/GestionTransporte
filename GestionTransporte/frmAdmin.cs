using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionTransporte.clases;

namespace GestionTransporte
{
    public partial class frmAdmin : Form
    {
        Login conexion;
        DataTable dtCamion;
        DataTable dtAcoplado;
        Camion camion;
        Acoplado acoplado;

        public frmAdmin(Login conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            camion = new Camion(conexion);
            acoplado = new Acoplado(conexion);
            carga_camiones_total();
            carga_acoplados_total();  //Problemas con esta funcion, revisar el error que lanza
            Verifica_dgv_vacio_acoplado();
            Verifica_dgv_vacio_camion();
            
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //inicializa combobox ,hace visible o invisible los objetos segun la busqueda *(por fecha,dominio ,etc )
            cbCamionListar.SelectedIndex = 0;
            cbCamionBuscar.SelectedIndex = 0;
            tbCamionBuscar.Visible = false;
            pnlCamionBuscar.Visible = false;
            

            cbAcopladoBuscar.SelectedIndex = 0;
            cbAcopladoListar.SelectedIndex = 0;
            tbAcopladoBuscar.Visible = false;
            pnlAcopladoBuscar.Visible = false;
        }
        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region ACOPLADO
        public void Verifica_dgv_vacio_acoplado()//si no hay resultados en la grilla esta funcion deshabilita los botones q se usan para seleccionar o algo de la grilla
        {
            if (dgvAcoplado.Rows.Count < 1)
            {
                btnSelecAcoplado.Enabled = false;
                btnModificarAcoplado.Enabled = false;
                btnBajaAcoplado.Enabled = false;
                MessageBox.Show("NO SE ENCONTRARON RESULTADOS PARA ACOPLADOS");
            }
            else
            {
                btnSelecAcoplado.Enabled = true;
                btnModificarAcoplado.Enabled = true;
                btnBajaAcoplado.Enabled = true;
            }
        }
       
        public void carga_acoplados_total()
        {//este metodo reune a todos los demas metodos para la caga total de los acoplados 

         Carga_todos_acoplados_al_dgv();
         ColumnasInvisiblesAcoplado();
         Carga_datos_Acoplado_a_label();

        }
        private void ColumnasInvisiblesAcoplado()
        {
           dgvAcoplado.Columns[4].Visible = false;
            dgvAcoplado.Columns[6].Visible = false;
            dgvAcoplado.Columns[7].Visible = false;
            dgvAcoplado.Columns[8].Visible = false;
            dgvAcoplado.Columns[9].Visible = false;
            dgvAcoplado.Columns[10].Visible = false;
            dgvAcoplado.Columns[11].Visible = false;
            dgvAcoplado.Columns[12].Visible = false;
            dgvAcoplado.Columns[13].Visible = false;
            dgvAcoplado.Columns[14].Visible = false;
            dgvAcoplado.Columns[16].Visible = false;
            
        }
        private void Carga_todos_acoplados_al_dgv()
        {
            dtAcoplado = acoplado.carga_acoplados_total();
            dgvAcoplado.DataSource = dtAcoplado;
       
            
        }
        private void Carga_datos_Acoplado_a_label()
        {
            lblAcopladoTara.DataBindings.Clear();
            lblAcopladoTara.DataBindings.Add(new Binding("Text", dtAcoplado, "tara"));
            lblAcopladoCapCarga.DataBindings.Clear();
            lblAcopladoCapCarga.DataBindings.Add(new Binding("Text", dtAcoplado, "capacidad de carga"));
            lblAcopladoNroChasis.DataBindings.Clear();
            lblAcopladoNroChasis.DataBindings.Add(new Binding("Text", dtAcoplado, "nº chasis"));
            lblAcopladoLongPlat.DataBindings.Clear();
            lblAcopladoLongPlat.DataBindings.Add(new Binding("Text", dtAcoplado, "long plataforma"));
            lblAcopladoAnchoInt.DataBindings.Clear();
            lblAcopladoAnchoInt.DataBindings.Add(new Binding("Text", dtAcoplado, "ancho interior"));
            lblAcopladoAnchoExt.DataBindings.Clear();
            lblAcopladoAnchoExt.DataBindings.Add(new Binding("Text", dtAcoplado, "ancho exterior"));
            lblAcopladoAltoTotal.DataBindings.Clear();
            lblAcopladoAltoTotal.DataBindings.Add(new Binding("Text", dtAcoplado, "alt total"));
            lblAcopladoCantEjes.DataBindings.Clear();
            lblAcopladoCantEjes.DataBindings.Add(new Binding("Text", dtAcoplado, "cant de ejes"));
            lblAcopladoObservaciones.DataBindings.Clear();
            lblAcopladoObservaciones.DataBindings.Add(new Binding("Text", dtAcoplado, "observaciones"));
        
        
                  
        
        
        }
        private void btnNuevoAcoplado_Click(object sender, EventArgs e)
        {
            new GestionTransporte.frmCargaAcoplado(conexion,null).ShowDialog();
        }
        private void btnBajaAcoplado_Click(object sender, EventArgs e)
        {
            string dom = dgvAcoplado.CurrentRow.Cells[0].Value.ToString();
            string estado = dgvAcoplado.CurrentRow.Cells[5].Value.ToString();
            if (estado == "DISPONIBLE")
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = conexion.cnn;
                    cmd.CommandText = "update acoplado set estado='DESAHABILITADO' where dominio='" + dom + "';SELECT Scope_Identity();";
                    cmd.CommandType = CommandType.Text;
                    conexion.Modo(TipoConexion.Abrir);
                    string id_insertado = cmd.ExecuteScalar().ToString();
                    if (id_insertado != null)
                    {
                        cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + conexion.Usuario + "','" + "se dio de baja acoplado dominio" + dom + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Listorti");
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja acoplado");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ErrorCode.ToString());
                }
                conexion.Modo(TipoConexion.Cerrar);
            }
            else
                MessageBox.Show("Error, no se puede desahabilitar. Compruebe que el estado del mismo sea DISPONIBLE");
        }
        private void btnModificarAcoplado_Click(object sender, EventArgs e)
        {
            Acoplado acopl = new Acoplado(conexion);
            if (dgvCamion.RowCount > 0)
            {
                string dom = dgvAcoplado.CurrentRow.Cells[0].Value.ToString();
                acopl = acopl.Retorna_acoplado(dom);
                new GestionTransporte.frmCargaAcoplado(conexion, acopl).ShowDialog();
            }
            else
                MessageBox.Show("NO HAY ACOPLADOS PARA MODIFICAR");
            acopl.carga_acoplados_total();
        }

        #endregion
      
        #region CAMIONES
        public void Verifica_dgv_vacio_camion()
        {
            if (dgvCamion.Rows.Count < 1)
            {
                btnBajaCamion.Enabled = false;
                btnModificarCamion.Enabled = false;
                btnSelecCamion.Enabled = false;
                MessageBox.Show("NO SE ENCONTRARON RESULTADOS PARA CAMIONES");
            }
            else
            {
                btnBajaCamion.Enabled = true;
                btnModificarCamion.Enabled = true;
                btnSelecCamion.Enabled = true;

            }

        }
        public void carga_camiones_total() {//este metodo reune a todos los demas metodos para la caga total de los camiones 

            Carga_todos_los_Camiones_al_dgv();
            ColumnasInvisiblesCamion();
            Carga_datos_Camion_a_label();
        }
        private void ColumnasInvisiblesCamion()
        {
            
            dgvCamion.Columns[6].Visible = false;
            dgvCamion.Columns[7].Visible = false;
            dgvCamion.Columns[8].Visible = false;
            dgvCamion.Columns[9].Visible = false;
            dgvCamion.Columns[10].Visible = false;
            dgvCamion.Columns[11].Visible = false;
            dgvCamion.Columns[12].Visible = false;
            dgvCamion.Columns[14].Visible = false;
        
          }//escondo las columnas q no se tendrian q ver porq se salen del ancho del dgv
        private void Carga_todos_los_Camiones_al_dgv()
        {
            dtCamion = camion.carga_camiones_total();
            dgvCamion.DataSource = dtCamion;
        }
        private void Carga_datos_Camion_a_label()
        {
            lblCamionTara.DataBindings.Clear();
            lblCamionTara.DataBindings.Add(new Binding("Text", dtCamion, "tara"));
            lblCamionNroChasis.DataBindings.Clear();
            lblCamionNroChasis.DataBindings.Add(new Binding("Text",dtCamion,"nro_chasis"));
            lblCamionNroMotor.DataBindings.Clear();
            lblCamionNroMotor.DataBindings.Add(new Binding("Text", dtCamion, "nro_motor"));
            lblCamionAltoTotal.DataBindings.Clear();
            lblCamionAltoTotal.DataBindings.Add(new Binding("Text", dtCamion, "alt_total")); ;
            lblCamionAnchoTotal.DataBindings.Clear();
            lblCamionAnchoTotal.DataBindings.Add(new Binding("Text", dtCamion, "ancho_total"));
            lblCamionLongTotal.DataBindings.Clear();
            lblCamionLongTotal.DataBindings.Add(new Binding("Text", dtCamion, "long_total"));
            lblCamionObservaciones.DataBindings.Clear();
            lblCamionObservaciones.DataBindings.Add(new Binding("Text", dtCamion, "observaciones"));
        }
        private void btnNuevoCamion_Click(object sender, EventArgs e)
        {
            new GestionTransporte.frmCargaCamion(conexion,null).ShowDialog();
        }
        private void btnBajaCamion_Click(object sender, EventArgs e)
        {
            string dom = dgvCamion.CurrentRow.Cells[0].Value.ToString();
            string estado = dgvCamion.CurrentRow.Cells[5].Value.ToString();
            if (estado == "DISPONIBLE")
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = conexion.cnn;
                    cmd.CommandText = "update camion set estado='DESAHABILITADO' where dominio='" + dom + "';SELECT Scope_Identity();";
                    cmd.CommandType = CommandType.Text;
                    conexion.Modo(TipoConexion.Abrir);
                    string id_insertado = cmd.ExecuteScalar().ToString();
                    if (id_insertado != null)
                    {
                        cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + conexion.Usuario + "','" + "se dio de baja camion dominio" + dom + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Listorti");
                        this.Carga_todos_los_Camiones_al_dgv();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja camion");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ErrorCode.ToString());
                }
                conexion.Modo(TipoConexion.Cerrar);
            }
            else
                MessageBox.Show("Error, no se puede desahabilitar. Compruebe que el estado del mismo sea DISPONIBLE");
        }
        private void btnModificarCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(conexion);
            if (dgvCamion.RowCount > 0)
            {
                string dom = dgvCamion.CurrentRow.Cells[0].Value.ToString();
                camion = camion.Retorna_camion(dom);
                new GestionTransporte.frmCargaCamion(conexion, camion).ShowDialog();
            }
            else
                MessageBox.Show("NO HAY CAMIONES PARA MODIFICAR");
            camion.carga_camiones_total();
        }

        #endregion

        #region FUNCIONES COMPARTIDAS, CAMION-ACOPLADO
        private void cbCamionListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region cbCamionBuscar/listar

            if (sender == cbCamionBuscar)
            {    
                tbCamionBuscar.Clear();
                
                if (cbCamionBuscar.SelectedIndex == 0)
                {
                    tbCamionBuscar.Visible = false;
                    pnlCamionBuscar.Visible = false;
                }
                if (cbCamionBuscar.SelectedIndex == 1 || cbCamionBuscar.SelectedIndex == 2 || cbCamionBuscar.SelectedIndex == 3)
                {

                    tbCamionBuscar.Visible = true;
                    tbCamionBuscar.Location = new Point(238, 92);
                    pnlCamionBuscar.Visible = false;
                    pnlCamionBuscar.Location = new Point(362, 86);

                }
                if (cbCamionBuscar.SelectedIndex == 4 || cbCamionBuscar.SelectedIndex == 5)
                {

                    tbCamionBuscar.Visible = false;
                    tbCamionBuscar.Location = new Point(362, 86);
                    pnlCamionBuscar.Visible = true;
                    pnlCamionBuscar.Location = new Point(238, 91);
                }

               
            }
            #endregion

            #region cbAcopladoBuscar/listar
            if (sender == cbAcopladoBuscar)
            {
              
               
                tbAcopladoBuscar.Clear();
                

                if (cbAcopladoBuscar.SelectedIndex == 0)
                {
                    tbAcopladoBuscar.Visible = false;
                    pnlAcopladoBuscar.Visible = false;
                }
                if (cbAcopladoBuscar.SelectedIndex == 1 || cbAcopladoBuscar.SelectedIndex == 2)
                {

                    tbAcopladoBuscar.Visible = true;
                    tbAcopladoBuscar.Location = new Point(883, 92);
                    pnlAcopladoBuscar.Visible = false;
                    pnlAcopladoBuscar.Location = new Point(1007, 85);

                }
                if (cbAcopladoBuscar.SelectedIndex == 3 || cbAcopladoBuscar.SelectedIndex == 4)
                {

                    tbAcopladoBuscar.Visible = false;
                    tbAcopladoBuscar.Location = new Point(1007, 86);
                    pnlAcopladoBuscar.Visible = true;
                    pnlAcopladoBuscar.Location = new Point(883, 91);
                }

                Verifica_dgv_vacio_acoplado();
            }
            if (sender == cbCamionListar)
            {
                switch (cbCamionListar.SelectedIndex)
                {
                    case 0:
                        dtCamion = camion.carga_camiones_total();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;

                    case 1:
                        dtCamion = camion.Listar_disponibles();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;
                    case 2:
                    dtCamion = camion.Listar_reservados();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;
                    case 3:
                           dtCamion = camion.Listar_dados_de_baja();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;
                    case 4:
                        dtCamion = camion.Listar_taller();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;
                    case 5:
                          dtCamion = camion.Listar_en_viaje();
                        dgvCamion.DataSource = dtCamion;
                        ColumnasInvisiblesCamion();
                        Carga_datos_Camion_a_label();
                        break;

                }
                Verifica_dgv_vacio_acoplado();
            }
            
            if (sender == cbAcopladoListar)
            {
                switch(cbAcopladoListar.SelectedIndex){
                    case 0:
                        dtAcoplado=acoplado.carga_acoplados_total();
                        dgvAcoplado.DataSource=dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;
                    case 1:
                        dtAcoplado = acoplado.Listar_disponibles();
                        dgvAcoplado.DataSource = dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;
                    case 2:
                         dtAcoplado=acoplado.Listar_reservados();
                        dgvAcoplado.DataSource=dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;
                    case 3:
                         dtAcoplado=acoplado.Listar_dados_de_baja();
                        dgvAcoplado.DataSource=dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;
                    case 4:
                         dtAcoplado=acoplado.Listar_Taller();
                        dgvAcoplado.DataSource=dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;
                    case 5: 
                        dtAcoplado=acoplado.Listar_en_viaje();
                        dgvAcoplado.DataSource=dtAcoplado;
                        ColumnasInvisiblesAcoplado();
                        Carga_datos_Acoplado_a_label();
                        break;

                }
                Verifica_dgv_vacio_acoplado();
            }
           

            #endregion
        }
        #region tbBusqueda
        private void tbCamionBuscar_TextChanged(object sender, EventArgs e)//busca camiones/acoplados desde el textbox segun la opcion que se desea buscar (combobox)
        {
            
            if (sender == tbCamionBuscar)
            {
              
                switch(cbCamionBuscar.SelectedIndex)
                {
                    case 1:
                    dtCamion = camion.Busqueda_dominio(tbCamionBuscar.Text,false);
                    dgvCamion.DataSource = dtCamion;
                    ColumnasInvisiblesCamion();
                    Carga_datos_Camion_a_label();
                    break;
                    case 2:
                    dtCamion = camion.Busqueda_chasis(tbCamionBuscar.Text,false);
                    dgvCamion.DataSource = dtCamion;
                    ColumnasInvisiblesCamion();
                    Carga_datos_Camion_a_label();
                    break;
                    case 3:
                    dtCamion = camion.Busqueda_motor(tbCamionBuscar.Text,false);

                    dgvCamion.DataSource = dtCamion;
                    ColumnasInvisiblesCamion();
                    Carga_datos_Camion_a_label();
                    break;
          

                }
                Verifica_dgv_vacio_camion();
            }
            if (sender == tbAcopladoBuscar)
            {
                switch (cbAcopladoBuscar.SelectedIndex)
                {
                    case 1:
                   dtAcoplado = acoplado.Busqueda_dominio(tbAcopladoBuscar.Text,false);
                    dgvAcoplado.DataSource = dtAcoplado;
                    ColumnasInvisiblesAcoplado();
                    Carga_datos_Acoplado_a_label();
                    break; 
                    case 2:
                    dtAcoplado = acoplado.Busqueda_chasis(tbAcopladoBuscar.Text,false);
                    dgvAcoplado.DataSource = dtAcoplado;
                    ColumnasInvisiblesAcoplado();
                    Carga_datos_Acoplado_a_label();
                    break;

                }
                Verifica_dgv_vacio_acoplado();
            }

            
        }



        private void dtpCamionBusquedaHasta_ValueChanged(object sender, EventArgs e)//maneja las busquedas de camiones/acoplados por fechas 
        {
            if (cbCamionBuscar.SelectedIndex == 4)
            {
                if (dtpCamionBusquedaCamionDesde.Value <= dtpCamionBusquedaHasta.Value)
                {
                    dtCamion = camion.Busqueda_fecha_alta(dtpCamionBusquedaCamionDesde.Value.ToString("yyyy-MM-dd"), dtpCamionBusquedaHasta.Value.ToString("yyyy-MM-dd"));
                    dgvCamion.DataSource = dtCamion;
                    ColumnasInvisiblesCamion();
                    Carga_datos_Camion_a_label();
                }
            }
            if (cbCamionBuscar.SelectedIndex == 5)
            {
                if (dtpCamionBusquedaCamionDesde.Value <= dtpCamionBusquedaHasta.Value)
                {
                    dtCamion = camion.Busqueda_fecha_baja(dtpCamionBusquedaCamionDesde.Value.ToString("yyyy-MM-dd"), dtpCamionBusquedaHasta.Value.ToString("yyyy-MM-dd"));
                    dgvCamion.DataSource = dtCamion;
                    ColumnasInvisiblesCamion();
                    Carga_datos_Camion_a_label();
                }
            }
            if (cbAcopladoBuscar.SelectedIndex == 3)
            {
                if (dtpAcopladoBuscarDesde.Value <= dtpAcopladoBuscarHasta.Value)
                {
                    dtAcoplado = acoplado.Busqueda_fecha_alta(dtpAcopladoBuscarDesde.Value.ToString("yyyy-MM-dd"), dtpAcopladoBuscarHasta.Value.ToString("yyyy-MM-dd"));
                    dgvAcoplado.DataSource = dtAcoplado;
                    ColumnasInvisiblesAcoplado();
                     Carga_datos_Acoplado_a_label();
                }
            }
            if (cbAcopladoBuscar.SelectedIndex == 4)
            {
                if (dtpAcopladoBuscarDesde.Value <= dtpAcopladoBuscarHasta.Value)
                {
                    dtAcoplado = acoplado.Busqueda_fecha_baja(dtpAcopladoBuscarDesde.Value.ToString("yyyy-MM-dd"), dtpAcopladoBuscarHasta.Value.ToString("yyyy-MM-dd"));
                    dgvAcoplado.DataSource = dtAcoplado;
                    ColumnasInvisiblesAcoplado();
                    Carga_datos_Acoplado_a_label();
                }
            }
            Verifica_dgv_vacio_acoplado();
            Verifica_dgv_vacio_camion();
         
        }

  
        }
        #endregion


        #endregion
}

