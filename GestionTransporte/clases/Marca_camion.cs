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
    public class Marca_camion
    {
        string marca;
        string estado;
        Login usuario;
      
        public Marca_camion(Login usuario)
        {
            this.usuario = usuario;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public string insertar()
        {
            string respuesta=string.Empty;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "insert into marca (marca) values ('" + Marca + "');SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                string id_insertado = cmd.ExecuteScalar().ToString();
                if (id_insertado != null)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se inserto la marca " + Marca + "')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al insertar marca";
                }
            }
            catch (SqlException e)
            {
                if (e.ErrorCode == -2146232060)
                {
                    respuesta = "YA EXISTE ESA MARCA ";

                }
               
           
            }

            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;
        }

        public string modificar(string vieja)
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            try
            {
                    cmd.Connection = usuario.cnn;
                cmd.CommandText = "update marca set marca='" + Marca + "' where marca='"+vieja+"';SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                string id_insertado = cmd.ExecuteScalar().ToString();
                if (id_insertado != null)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se modifico la marca " + vieja + " a "+Marca+"')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al modificar marca";
                }
            }
            catch (SqlException e)
            {
                respuesta = e.ErrorCode.ToString();
            }

            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;
        }

        public DataTable ver_marcas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select marca as MARCAS from marca order by marca asc";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }

        public string eliminar()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "delete from marca  where marca='" + Marca + "';SELECT Scope_Identity();";
                cmd.CommandType = CommandType.Text;
                usuario.Modo(TipoConexion.Abrir);
                int id_insertado = cmd.ExecuteNonQuery();
                if (id_insertado !=0)
                {
                    cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "elimino la marca " + Marca +  "')";
                    cmd.ExecuteNonQuery();
                    respuesta = string.Empty;
                }
                else
                {
                    respuesta = "Error al eliminar marca,ya existe una unidad utilizando esta marca";
                }
            }
            catch (SqlException )
            {
                respuesta = "Error al eliminar marca,ya existe una unidad utilizando esta marca";
            }

            usuario.Modo(TipoConexion.Cerrar);
            return respuesta;
        }

        public int retornaID_marca(string marca)
        {
            int retorno = -1;
            SqlCommand cmd = new SqlCommand();
            usuario.cnn.Open();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select id from marca where marca='"+ marca +"' ";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                retorno= Convert.ToInt32(dr[0]);
            }
            usuario.cnn.Close();
            return retorno;
        }

        public String retornaMarca(int id)
        {
            string retorno = string.Empty;
            SqlCommand cmd = new SqlCommand();
            usuario.cnn.Open();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select marca from marca where id='" + id + "' ";
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
