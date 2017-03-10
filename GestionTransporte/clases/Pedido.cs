using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionTransporte.clases
{
    public class Pedido
    {
        Login usuario;
        int id_pedido;

     
        int legajo_cliente;
        float peso_carga;
        DateTime fecha_sal_aprox;
        DateTime fecha_reg_aprox;
        DateTime fecha_pedido;
        string destinos;
        string cambios;//esta variable va a guardar datos (del pedido) como quien lo cargo,quien lo modifico,quien lo cancelo...puede ocurrir por ejemplo,que una empleado reciba solicitud y al fijaerse en el form 
        string observaciones;
        string estado;
      

        #region encapsulamiento de propiedades
        public int Id_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        public string Cambios
        {
            get { return cambios; }
            set { cambios = value; }
        }
        public string Destinos
        {
            get { return destinos; }
            set { destinos = value; }
        } 
    


    
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
 
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public DateTime Fecha_reg_aprox
        {
            get { return fecha_reg_aprox; }
            set { fecha_reg_aprox = value; }
        }
 

       
        public DateTime Fecha_sal_aprox
        {
            get { return fecha_sal_aprox; }
            set { fecha_sal_aprox = value; }
        }
        public float Peso_carga
        {
            get { return peso_carga; }
            set { peso_carga = value; }
        }
        public int Legajo_cliente
        {
            get { return legajo_cliente; }
            set { legajo_cliente = value; }
        }
        public DateTime Fecha_pedido
        {
            get { return fecha_pedido; }
            set { fecha_pedido = value; }
        }
     
    
        #endregion

        public Pedido(Login usuario)
        {
            this.usuario = usuario;
        }

        public string insertar_pedido()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "insert  into pedido (id_cliente,fecha_pedido,destino,fecha_sal_aprox,fecha_reg_aprox,peso_carga_aprox,cambios,observaciones,estado) values ('" + Legajo_cliente + "','" + DateTime.Now.ToString() + "','" + Destinos + "','" + Fecha_sal_aprox.ToString() + "','" + Fecha_reg_aprox.ToString() + "','" +Peso_carga + "','pedido realizado por usuario :"+usuario.Usuario+"','" + Observaciones + "','" + Estado + "');SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_insertado = cmd.ExecuteScalar().ToString();
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se inserto pedido numero  " + id_insertado + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al insertar pedido";
            }
            usuario.cnn.Close();
            return respuesta;
            // todas las funciones  de abm y otras se ejecutan con la propiedades y el login q pasamos por constructor 
        }
        public string cancelar_pedido()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = usuario.cnn;
            cmd.CommandText = "update pedido set estado='CANCELADO',cambio='"+Cambios+"\n cancelado por el usuario:"+usuario.Usuario+" ,fecha:"+DateTime.Now.ToString()+"' where id_pedido=" + Id_pedido + ";SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);

            string id_dado_de_baja = cmd.ExecuteScalar().ToString();
            //int  = 
            if (id_dado_de_baja != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se cancelo el pedido numero  " + id_dado_de_baja + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al insertar pedido";
            }
            usuario.cnn.Close();
            return respuesta;
        }
        public string modificar_pedido(int numPedido)//siempre y cuando el viaje aun no se haya realizado 
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "update pedido set id_cliente='" + Legajo_cliente + "',peso_carga_aprox='" + Peso_carga + "',observaciones='" + Observaciones + "',fecha_sal_aprox='" + Fecha_sal_aprox + "',fecha_reg_aprox='" + Fecha_reg_aprox + "',fecha_sal_aprox='" + Fecha_sal_aprox + "',destino='" + Destinos + "',cambios='" + Cambios + "' where num_pedido=" + Id_pedido + " ;SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_insertado = cmd.ExecuteScalar().ToString();
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se modifico pedido numero " + numPedido + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al modificar pedido";
            }
            usuario.cnn.Close();
            return respuesta;
            // todas las funciones  de abm y otras se ejecutan con la propiedades y el login q pasamos por constructor 
        }
        public DataTable ver_pedidos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "select id_pedido as 'Pedido Nº',fecha_pedido as 'Fecha de alta', fecha_sal_aprox as 'Salida prevista', fecha_reg_aprox as Fecha de 'Regreso previsto',descripcion as Observaciones,estado as Estado from pedido order by id_pedido asc";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }

    }
}
