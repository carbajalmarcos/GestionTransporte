using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  
using GestionTransporte.clases;


namespace GestionTransporte
{
    public partial class frmLogin : Form
    {
        Login Conexion;
        public frmLogin()
        {
            InitializeComponent();
            Conexion = new Login();
        }

        private void btnLogear_Click(object sender, EventArgs e)
        {
            if (!new Funciones().Valida_Controles(this))
            {
                MessageBox.Show("FALTA LLENAR CAMPOS MARCADOS CON COLOR ROJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conexion.Servidor = "MANAC\\SQLEXPRESS";  //Conexion Marcos Notebook
                //Conexion.Servidor = "DESKTOP-ABTLNM4\\SQLEXPRESS";  //Conexion Pablo PC
                //Conexion.Servidor = "DESKTOP-72D97C1";  //Conexion Pablo Notebook
                Conexion.BaseDatos = "gestiontransporte";  //Nombre de la base de datos
                Conexion.Usuario = tbUsuario.Text;      //Usuario que se logea en SQL server y que tambien existe en tabla login
                Conexion.Clave = tbPassword.Text;       //Password correspondiente
                string res = Conexion.Validar(); //Funcion que valida si la conexion fue o no exitosa.. devuelve un string vacio si fue exitosa
                if (res == string.Empty)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MANAC\SQLEXPRESS;Initial Catalog=gestiontransporte; User ID = " + tbUsuario.Text + "; Password= " + tbPassword.Text);  //Cadena de conexion Marcos Notebook
                    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABTLNM4\SQLEXPRESS;Initial Catalog=gestiontransporte; User ID = " + tbUsuario.Text + "; Password= " + tbPassword.Text);  //Cadena de conexion Pablo PC
                    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-72D97C1;Initial Catalog=gestiontransporte; User ID = " + tbUsuario.Text + "; Password= " + tbPassword.Text);  //Cadena de conexion Pablo Notebook
                    String query = "Select tipo_usuario From login Where usuario='" + tbUsuario.Text + "' and password='" + tbPassword.Text + "' ";  //Comprueba que exista en tabla login
                    SqlCommand command = new SqlCommand(query, con); //Ejecuta la query
                    con.Open();  //Abre la conexion
                    SqlDataReader reader = command.ExecuteReader();  //Lee la consulta
                    if (reader.Read()) //Verifica si hay datos en la consulta
                    {
                        String dato = reader.GetString(0); //Guardo el valor obtenido en la query, (0) posicion de la variable en el Select, este caso 0 xq es el unico
                        if (dato == "gordo")
                        {
                            this.Hide();
                            frmAdmin ofrmMain = new frmAdmin(Conexion);
                            ofrmMain.ShowDialog();
                            //this.ShowDialog();
                        }
                        else if (dato == "pedido")
                        {
                            this.Hide();
                            frmPedido frmPedido = new frmPedido(Conexion);
                            frmPedido.ShowDialog();
                            this.ShowDialog();
                        }
                        else if (dato == "mecanico")
                        {
                            this.Hide();
                            frmMecanico frmMecanico = new frmMecanico(Conexion);
                            frmMecanico.ShowDialog();
                            this.ShowDialog();
                        }

                    }
                    tbPassword.Clear();
                    tbUsuario.Clear();
                    con.Close();  //Cierra conexion
                }
                else
                    MessageBox.Show(res, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Si string es NO vacio, lanza mensaje de error.
            }    
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            new Funciones().fondoBlanco_Controles(sender);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
