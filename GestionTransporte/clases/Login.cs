using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionTransporte
{
    public enum TipoConexion
    {
        Abrir,Cerrar
    }
    public class Login
    {
        public string Servidor;
        public string Usuario;
        public string Clave;
        public string BaseDatos;
        public SqlConnection cnn = new SqlConnection();
        public string Modo(TipoConexion Tipo)
        {
            string res = string.Empty;
            string StrCnn = @"Data Source=" + Servidor + ";Initial Catalog=" + BaseDatos + "; User ID = " + Usuario + "; Password= " + Clave;
            try
            {
            if ((cnn.State == System.Data.ConnectionState.Closed) && (Tipo ==
            TipoConexion.Abrir))
            {
            cnn.ConnectionString = StrCnn;
            cnn.Open();
            }
            else
            cnn.Close();
            }
            catch (SqlException ex)
            {
            res = ex.Message;
            }
            return res;
        }
        public string Validar()
        {
        string res = string.Empty;
        string StrCnn = @"Data Source=" + Servidor + ";Initial Catalog=" + BaseDatos + "; User ID = " + Usuario + "; Password= " +
        Clave;
        try
        {
        cnn.ConnectionString = StrCnn;
        cnn.Open();
        cnn.Close();
        }
        catch (SqlException ex)
        {
        res = ex.Message;
        }
        return res;
        }

    }
}
