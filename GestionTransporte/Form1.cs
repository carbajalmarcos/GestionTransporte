using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//necesario para poder acceder a SQL

namespace GestionTransporte
{
    public partial class Form1 : Form
    {
        clsConexion Conexion;
        public Form1()
        {
            InitializeComponent();
            Conexion = new clsConexion();

        }
        

        private void btnLogear_Click(object sender, EventArgs e)
        {
            Conexion.Servidor = "DESKTOP-72D97C1";
            Conexion.BaseDatos = "gestiontransporte";
            Conexion.Usuario = tbUsuario.Text;
            Conexion.Clave = tbPassword.Text;
            string res = Conexion.Validar();
            if (res == string.Empty)
            {
                tbPassword.Clear();
                tbUsuario.Clear();
                this.Hide();
                frmPrincipal ofrmMain = new frmPrincipal();
                ofrmMain.ShowDialog();
                this.ShowDialog();
            }
            else
                MessageBox.Show(res, "E R R O R",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
