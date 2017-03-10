using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionTransporte.clases
{
    public class Camion
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        string id;
        string dominio;
        int marca;
        string modelo;
        string año;
        float tara;
        int tipo;
        string nro_chasis;
        string nro_motor;
        float ancho_total;
        float alto_total;
        float long_total;
        string fecha_alta;
        string fecha_baja;
        string estado;// Disponible,en viaje,dado de baja ,en reparacion etc.
        string observacion;
        DataTable dt;
        SqlDataAdapter da;

        #region encapsulamiento de propiedades


        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Dominio
        {
            get { return dominio; }
            set { dominio = value; }
        }

        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        public string Año
        {
            get { return año; }
            set { año = value; }
        }

        public float Tara
        {
            get { return tara; }
            set { tara = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Nro_chasis
        {
            get { return nro_chasis; }
            set { nro_chasis = value; }
        }

        public string Nro_motor
        {
            get { return nro_motor; }
            set { nro_motor = value; }
        }


        public float Ancho_total
        {
            get { return ancho_total; }
            set { ancho_total = value; }
        }



        public float Alto_total
        {
            get { return alto_total; }
            set { alto_total = value; }
        }

        public float Long_total
        {
            get { return long_total; }
            set { long_total = value; }
        }

        public String Fecha_alta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }

        public String Fecha_baja
        {
            get { return fecha_baja; }
            set { fecha_baja = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        #endregion

        public Camion(Login usuario)
        {
            this.usuario = usuario;
        }
        public string insertar()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "insert into camion (dominio,marca,tara,modelo,año,tipo,nro_chasis,nro_motor,alt_total,ancho_total,long_total,estado,observaciones,fecha_alta) values ('" + Dominio + "','" + Marca + "','" + Tara + "','" + Modelo + "','" + Año + "','" + Tipo + "','" + Nro_chasis + "','" + Nro_motor + "','" + Alto_total + "','" + Ancho_total + "','" + Long_total + "','" + Estado + "','" + Observacion + "','" + Fecha_alta + "');SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_insertado = cmd.ExecuteScalar().ToString();
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se inserto camion id  " + id_insertado + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al insertar unidad";
            }
            usuario.cnn.Close();
            return respuesta;
            // todas las funciones  de abm y otras se ejecutan con la propiedades y el login q pasamos por constructor 
        }
        public string dar_baja()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = usuario.cnn;
            cmd.CommandText = "update camion set estado='DADO DE BAJA' where id=" + Id + ";SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);

            string id_dado_de_baja = cmd.ExecuteScalar().ToString();
            //int  = 
            if (id_dado_de_baja != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se dio de baja el camion id  " + id_dado_de_baja + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al insertar unidad";
            }
            usuario.cnn.Close();
            return respuesta;
        }
        public string modificar(string dominioModifica)
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "update camion set marca='" + Marca + "',tara='" + Tara + "',modelo='" + Modelo + "',año='" + Año + "',tipo='" + Tipo + "',nro_chasis='" + Nro_chasis + "',nro_motor='" + Nro_motor + "',alt_total='" + Alto_total + "',ancho_total='" + Ancho_total + "',long_total='" + Long_total + "',estado='" + Estado + "',observaciones='" + Observacion + "' where dominio='" + dominioModifica + "'SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_insertado = cmd.ExecuteScalar().ToString();
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se modifico camion dominio " + dominioModifica + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al modificar unidad";
            }
            usuario.cnn.Close();
            return respuesta;
            // todas las funciones  de abm y otras se ejecutan con la propiedades y el login q pasamos por constructor 
        }
        public DataTable carga_camiones_total()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception )
            {
                return null;
            }
        }
        public DataTable Busqueda_dominio(string dominio,bool exacta)
              {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                if (!exacta)
                {
                    da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.dominio like '%" + dominio + "%'", usuario.cnn);
                }else{

                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.dominio = '"+dominio+"'", usuario.cnn);
               
                }
                
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Busqueda_chasis(string chasis,bool exacta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                if (!exacta)
                {
                    da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.nro_chasis like '%"+chasis+"%'", usuario.cnn);
                }
                else
                {
                    da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.nro_chasis = '"+chasis+"'", usuario.cnn);
                }
              
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Busqueda_motor(string motor,bool exacta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                if (!exacta)
                {
                    da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.nro_motor like '%" + motor + "%'", usuario.cnn);
                }else
                {
                    da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.nro_motor ='"+motor+"'", usuario.cnn);
                }
              
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Busqueda_fecha_alta(string desde,string hasta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where fecha_alta between '" + desde + "' and '" + hasta + "'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Busqueda_fecha_baja(string desde, string hasta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.fecha_baja between '" + desde + "' and '" + hasta + "'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Camion Retorna_camion(string dom)
        {
            try
            {
                Camion camion = new Camion(usuario);
                SqlCommand cmd = new SqlCommand();
                usuario.cnn.Open();
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "Select dominio,marca,tara,modelo,año,tipo,nro_chasis,nro_motor,alt_total,ancho_total,long_total,estado,observaciones,fecha_alta,fecha_baja From camion where dominio = '" + dom + "' ";
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    camion.dominio = dr[0].ToString();
                    camion.marca = Convert.ToInt32(dr[1]);
                    camion.tara = float.Parse(dr[2].ToString());
                    camion.modelo=dr[3].ToString();
                    camion.año=dr[4].ToString();
                    camion.tipo=Convert.ToInt32(dr[5]);
                    camion.nro_chasis=dr[6].ToString();
                    camion.nro_motor=dr[7].ToString();
                    camion.alto_total = float.Parse(dr[8].ToString());
                    camion.ancho_total = float.Parse(dr[9].ToString());
                    camion.long_total = float.Parse(dr[10].ToString());
                    camion.estado=dr[11].ToString();
                    camion.observacion=dr[12].ToString();
                    camion.fecha_alta=dr[13].ToString();
                    camion.fecha_baja=dr[14].ToString();
                }
                usuario.cnn.Close();
                return camion;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Listar_dados_de_baja()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.estado='DADO DE BAJA'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Listar_disponibles()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.estado='DISPONIBLE'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Listar_en_viaje()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.estado='EN VIAJE'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Listar_taller()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.estado='TALLER'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Listar_reservados()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select c.dominio,m.marca,c.modelo,c.año,t.tipo,c.estado,c.tara,c.nro_chasis,c.nro_motor,c.alt_total,c.ancho_total,c.long_total,c.observaciones,c.fecha_alta as 'fecha alta',c.fecha_baja From camion c join marca m on c.marca=m.id join tipo_camion t on c.tipo=t.id where c.estado='RESERVADO'", usuario.cnn);
                dt = new DataTable();
                da.Fill(dt);
                usuario.Modo(TipoConexion.Cerrar);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
