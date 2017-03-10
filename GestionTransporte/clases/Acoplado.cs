using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GestionTransporte.clases
{
    public class Acoplado
    {
        Login usuario;//el usuario trae consigo la coneccion a la bd 
        string id;
        string dominio;
        int marca;
        string modelo;
        string año;
        float tara;
        int tipo;
        float alt_total;
        string nro_chasis;
        float ancho_interior;
        float ancho_exterior;
        float long_plataforma;
        float capacidad_carga;
        float cant_de_ejes;
        string observaciones;
        string fecha_alta;
        string fecha_baja;
        string estado;// Disponible,en viaje,dado de baja ,en reparacion etc.
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

        public float Alt_total
        {
            get { return alt_total; }
            set { alt_total = value; }
        }

        public string Nro_chasis
        {
            get { return nro_chasis; }
            set { nro_chasis = value; }
        }


        public float Ancho_interior
        {
            get { return ancho_interior; }
            set { ancho_interior = value; }
        }



        public float Ancho_exterior
        {
            get { return ancho_exterior; }
            set { ancho_exterior = value; }
        }

        public float Long_plataforma
        {
            get { return long_plataforma; }
            set { long_plataforma = value; }
        }



        public float Capacidad_carga
        {
            get { return capacidad_carga; }
            set { capacidad_carga = value; }
        }


        public float Cant_de_ejes
        {
            get { return cant_de_ejes; }
            set { cant_de_ejes = value; }
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

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        #endregion
        public Acoplado(Login usuario)
        {
            this.usuario = usuario;
        }
        public string insertar()
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "insert into acoplado (dominio,marca,modelo,año,tara,tipo,alt_total,nro_chasis,ancho_interior,ancho_exterior,long_plataforma,capacidad_carga,cant_ejes,estado,observaciones) values ('" + Dominio + "','" + Marca + "','" + Modelo + "','" + Año + "','" + Tara + "','" + Tipo + "','" + Alt_total + "','" + Nro_chasis + "','" + Ancho_interior + "','" + Ancho_exterior + "','" + Long_plataforma + "','" + Capacidad_carga + "','" + Cant_de_ejes + "','" + Estado + "','" + Observaciones + "');SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);

            string id_insertado = cmd.ExecuteScalar().ToString();
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se inserto acoplado id  " + id_insertado + "')";
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
            cmd.CommandText = "update acoplado set estado='DADO DE BAJA' where id=" + Id + ";SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_dado_de_baja = cmd.ExecuteScalar().ToString();
            //int  = 
            if (id_dado_de_baja != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se dio de baja el acoplado id  " + id_dado_de_baja + "')";
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
        public string modificar(string domModifica)
        {
            string respuesta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = usuario.cnn;
            cmd.CommandText = "update acoplado set marca='" + Marca + "',modelo='" + Modelo + "',año='" + Año + "',tara='" + Tara + "',tipo='" + Tipo + "',alt_total='" + Alt_total + "',nro_chasis='" + Nro_chasis + "',ancho_interior='" + Ancho_interior + "',ancho_exterior='" + Ancho_exterior + "',long_plataforma='" + Long_plataforma + "',capacidad_carga='" + Capacidad_carga + "',cant_ejes='" + Cant_de_ejes + "',estado='" + Estado + "',observaciones='" + Observaciones + "' where dominio='"+domModifica+"');SELECT Scope_Identity();";
            cmd.CommandType = CommandType.Text;
            usuario.Modo(TipoConexion.Abrir);
            string id_insertado = cmd.ExecuteScalar().ToString();
            //int  = 
            if (id_insertado != null)
            {
                cmd.CommandText = "insert into auditoria values ('" + (DateTime.Now).ToString() + "','" + usuario.Usuario + "','" + "se modifico acoplado dominio  " + domModifica + "')";
                cmd.ExecuteNonQuery();
                respuesta = string.Empty;
            }
            else
            {
                respuesta = "Error al modificar acoplado";
            }
            usuario.cnn.Close();
            return respuesta;
            // todas las funciones  de abm y otras se ejecutan con la propiedades y el login q pasamos por constructor 
        }     
        public DataTable carga_acoplados_total()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id", usuario.cnn);
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
        public DataTable Busqueda_dominio(string dominio,bool exacta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                if (!exacta) {
                    da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id  where a.dominio like '%"+ dominio +"%'", usuario.cnn);
                }else
                {
                    da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id  where a.dominio = '"+ dominio +"'", usuario.cnn);
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
                    da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.nro_chasis like '%"+chasis+"%'", usuario.cnn);
                }
                else
                {
                    da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.nro_chasis ='"+chasis+"'", usuario.cnn);
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
        public DataTable Busqueda_fecha_alta(string desde, string hasta)
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where fecha_alta between '" + desde + "' and '" + hasta + "'", usuario.cnn);
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
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where fecha_baja between '" + desde + "' and '" + hasta + "'", usuario.cnn);
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
        public Acoplado Retorna_acoplado(string dom)
        {
            try
            {
                Acoplado acoplado = new Acoplado(usuario);
                SqlCommand cmd = new SqlCommand();
                usuario.cnn.Open();
                cmd.Connection = usuario.cnn;
                cmd.CommandText = "Select dominio,marca,modelo,año,tara,tipo,alt_total,nro_chasis,ancho_interior,ancho_exterior,long_plataforma,capacidad_carga,cant_ejes,estado,observaciones,fecha_alta,fecha_baja From acoplado where dominio = '" + dom + "' ";
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    acoplado.dominio = dr[0].ToString();
                    acoplado.marca = Convert.ToInt32(dr[1]);
                    acoplado.modelo = dr[2].ToString();
                    acoplado.año = dr[3].ToString();
                    acoplado.tara = float.Parse(dr[4].ToString());
                    acoplado.tipo = Convert.ToInt32(dr[5]);
                    acoplado.alt_total = float.Parse(dr[6].ToString());
                    acoplado.nro_chasis = dr[7].ToString();
                    acoplado.ancho_interior = float.Parse(dr[8].ToString());
                    acoplado.ancho_exterior = float.Parse(dr[9].ToString());
                    acoplado.long_plataforma = float.Parse(dr[10].ToString());
                    acoplado.capacidad_carga = float.Parse(dr[11].ToString());
                    acoplado.cant_de_ejes = float.Parse(dr[12].ToString());
                    acoplado.estado = dr[13].ToString();
                    acoplado.observaciones = dr[14].ToString();
                    acoplado.fecha_alta = dr[15].ToString();
                    acoplado.fecha_baja = dr[16].ToString();
                }
                usuario.cnn.Close();
                return acoplado;
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
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.estado='DADO DE BAJA'", usuario.cnn);
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
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.estado='DISPONIBLE'", usuario.cnn);
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
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.estado='EN VIAJE'", usuario.cnn);
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
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.estado='RESERVADO'", usuario.cnn);
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
        public DataTable Listar_Taller()
        {
            try
            {
                usuario.Modo(TipoConexion.Abrir);
                da = new SqlDataAdapter("Select a.dominio dominio,m.marca marca,a.modelo modelo,a.año año,a.tara tara,t.tipo tipo,a.alt_total as 'alt total',a.nro_chasis as 'nº chasis',a.ancho_interior as  'ancho interior',a.ancho_exterior  as 'ancho exterior',a.long_plataforma as 'long plataforma',a.capacidad_carga as 'capacidad de carga',a.cant_ejes as 'cant de ejes',a.estado estado,a.observaciones as observaciones,a.fecha_alta 'fecha alta',a.fecha_baja 'fecha baja' From acoplado a join marca m on a.marca=m.id join tipo_acoplado t on a.tipo=t.id where a.estado='TALLER'", usuario.cnn);
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
