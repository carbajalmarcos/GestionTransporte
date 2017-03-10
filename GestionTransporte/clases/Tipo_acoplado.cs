using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace GestionTransporte.clases
{
    public class Tipo_acoplado
    {
        string tipo;
        Login usuario;

        #region Get y Set
        public Tipo_acoplado(Login usuario)
        {
            this.usuario = usuario;
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        public string insertar()
        {

            string respuesta=string.Empty;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "insert into tipo_acoplado (tipo) values ('" + Tipo + "');SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                string id_insertado = cmd.ExecuteScalar().ToString();
                if (id_insertado != null)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se inserto tipo de acoplado " + Tipo + "')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al insertar tipo de acoplado";
                }
            }
            catch (SqlException e)
            {
                if (e.ErrorCode == -2146232060)
                {
                    respuesta = "YA EXISTE ESE TIPO DE CAMION ";

                }
            }
            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;

        }
        public DataTable ver_tipoAcoplado()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select tipo as TIPO from tipo_acoplado order by tipo asc";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            usuario.Modo(TipoConexion.Cerrar);
            return datatable;
        }
        public string modificar(string vieja)
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "update tipo_acoplado set tipo='" + Tipo + "' where tipo='" + vieja + "';SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                string id_insertado = cmd.ExecuteScalar().ToString();
                if (id_insertado != null)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se modifico el tipo de acoplado" + vieja + " a " + Tipo + "')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al modificar tipo de acoplado";
                }
            }
            catch (Exception e)
            {
                respuesta = e.Message;

            }
            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;
        }
        public string eliminar()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "delete from tipo_acoplado where tipo='" + Tipo + "';SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                int id_insertado = cmd.ExecuteNonQuery();
                if (id_insertado != 0)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "elimino el tipo de acoplado " + Tipo + "')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al eliminar tipo,ya existe una unidad utilizando este tipo";
                }
            }
            catch (SqlException)
            {
                respuesta = "Error al eliminar tipo,ya existe una unidad utilizando este tipo";
            }

            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;
        }
        public int retornaID_tipoAcoplado(string tipo)
        {
            int retorno = 1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            usuario.cnn.Open();
            cmd.CommandText = "select id from tipo_acoplado where tipo='" + tipo + "' ";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retorno = Convert.ToInt32(dr[0]);
            }
            usuario.cnn.Close();
            return retorno;
        }
        public String retornaTipoAcoplado(int id)
        {
            string retorno = string.Empty;
            SqlCommand cmd = new SqlCommand();
            usuario.cnn.Open();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select tipo from tipo_acoplado where id='" + id + "' ";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retorno = dr[0].ToString();
            }
            usuario.cnn.Close();
            return retorno;
        }


    }
}
