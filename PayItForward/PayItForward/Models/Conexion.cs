using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using PayItForward.Models;

namespace PayItForward.Models
{
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            //ORT
            string SC = "Server=.;Database=PayItForward;Trusted_Connection=True;";

            //Marian
            //string SC = "Server=LAPTOP-BT997U35\\SQLEXPRESS;Database=PayItForward;Trusted_Connection=True;";
            SqlConnection Conexion = new SqlConnection(SC);
            Conexion.Open();
            return Conexion;
        }

        private int TraerUltimaPublicacion()
        {
            int Id_Traido = -1;

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();
            Comando.CommandText = "sp_UltimaPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                Id_Traido = Convert.ToInt32(DataReader["UltimaPublicacion"]);
            }

            Conexion.Close();

            return Id_Traido;
        }

        public int CrearPublicacion(Publicacion UnaPublicacion)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_AltaPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdCategoria", UnaPublicacion.IdCategoria);
            Comando.Parameters.AddWithValue("@pIdUsuario", UnaPublicacion.IdUsuario);
            Comando.Parameters.AddWithValue("@pImagen1", UnaPublicacion.Imagen1);
            Comando.Parameters.AddWithValue("@pImagen2", UnaPublicacion.Imagen2);
            Comando.Parameters.AddWithValue("@pImagen3", UnaPublicacion.Imagen3);
            Comando.Parameters.AddWithValue("@pAprobada", UnaPublicacion.Aprobada);
            Comando.Parameters.AddWithValue("@pValor", UnaPublicacion.Valor);
            Comando.Parameters.AddWithValue("@pTitulo", UnaPublicacion.Titulo);
            Comando.Parameters.AddWithValue("@pDescripcion", UnaPublicacion.Descripcion);
            Comando.Parameters.AddWithValue("@pLikes", UnaPublicacion.Likes);
            Comando.Parameters.AddWithValue("@pUbicacion", UnaPublicacion.Ubicacion);

            Comando.ExecuteNonQuery();

            Conexion.Close();

            return TraerUltimaPublicacion();
        }

        public List<Categorias> TraerCategoriasPadres()
        {
            List<Categorias> Lista = new List<Categorias>();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerCategoriasPadres";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdCategoria_Traido = Convert.ToInt32(DataReader["IdCategoria"].ToString());
                int IdCategoriaPadre_Traido = Convert.ToInt32(DataReader["IdCategoriaPadre"].ToString());
                string Nombre_Traido = DataReader["Nombre"].ToString();
                string Imagen_Traida = DataReader["Imagen"].ToString();

                Categorias X = new Categorias(IdCategoria_Traido, IdCategoriaPadre_Traido, Nombre_Traido, Imagen_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public List<Banners> TraerBanners()
        {
            List<Banners> Lista = new List<Banners>();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerBannersHome";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdBanner_Traido = Convert.ToInt32(DataReader["IdBanner"].ToString());
                string Imagen_Traida = DataReader["Imagen"].ToString();
                DateTime Desde_Traido = Convert.ToDateTime(DataReader["Desde"]);
                DateTime Hasta_Traido = Convert.ToDateTime(DataReader["Hasta"]);

                Banners X = new Banners(IdBanner_Traido, Desde_Traido, Hasta_Traido, Imagen_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public List<Categorias> TraerCategoriasHijas(int IdCategoriaPadre)
        {
            List<Categorias> Lista = new List<Categorias>();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerCategoriasPorIdPadre";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdPadre", IdCategoriaPadre);
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdCategoria_Traida = Convert.ToInt32(DataReader["IdCategoria"].ToString());
                int IdCategoriaPadre_Traida = Convert.ToInt32(DataReader["IdCategoriaPadre"].ToString());
                string Nombre_Traido = DataReader["Nombre"].ToString();
                string Imagen_Traida = DataReader["Imagen"].ToString();

                Categorias X = new Categorias(IdCategoria_Traida, IdCategoriaPadre_Traida, Nombre_Traido, Imagen_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public List<Publicacion> TraerPublicacionesPorUsuario(int IdUsuario)
        {
            List<Publicacion> Lista = new List<Publicacion>();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerPublicacionesPorUsuario";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", IdUsuario);
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdPublicacion_Traido = Convert.ToInt32(DataReader["IdPublicacion"]);
                int IdCategoria_Traido = Convert.ToInt32(DataReader["IdCategoria"]);
                int IdUsuario_Traido = Convert.ToInt32(DataReader["IdUsuario"]);
                string Imagen1_Traida = DataReader["Imagen1"].ToString();
                string Imagen2_Traida = DataReader["Imagen2"].ToString();
                string Imagen3_Traida = DataReader["Imagen3"].ToString();
                bool Aprobado_Traido = Convert.ToBoolean(DataReader["Aprobada"]);
                int Valor_Traido = Convert.ToInt32(DataReader["Valor"]);
                string Titulo_Traido = DataReader["Titulo"].ToString();
                string Descripcion_Traida = DataReader["Descripcion"].ToString();
                int Likes_Traidos = Convert.ToInt32(DataReader["Likes"]);
                string Ubicacion_Traida = DataReader["Ubicacion"].ToString();

                Publicacion X = new Publicacion(IdPublicacion_Traido, IdCategoria_Traido, IdUsuario_Traido, Imagen1_Traida, Imagen2_Traida, Imagen3_Traida, Aprobado_Traido, Valor_Traido, Titulo_Traido, Descripcion_Traida, Likes_Traidos, Ubicacion_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public Publicacion TraerPublicacionPorId(int IdPublicacion)
        {
            Publicacion X = new Publicacion();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerPublicacionPorId";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", IdPublicacion);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                X.IdPublicacion = IdPublicacion;
                X.IdCategoria = Convert.ToInt32(DataReader["IdCategoria"]);
                X.IdUsuario = Convert.ToInt32(DataReader["IdUsuario"]);
                X.Imagen1 = DataReader["Imagen1"].ToString();
                X.Imagen2 = DataReader["Imagen2s"].ToString();
                X.Imagen3 = DataReader["Imagen3"].ToString();
                X.Aprobada = Convert.ToBoolean(DataReader["Aprobada"]);
                X.Valor = Convert.ToInt32(DataReader["Valor"]);
                X.Titulo = DataReader["Titulo"].ToString();
                X.Descripcion = DataReader["Descripcion"].ToString();
                X.Likes = Convert.ToInt32(DataReader["Likes"]);
                X.Ubicacion = DataReader["Ubicacion"].ToString();
            }

            Conexion.Close();

            return X;
        }

        public void EliminarPublicacion(int IdPublicacion)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_BajaPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", IdPublicacion);

            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public Categorias TraerCategoriaPorID(int ID)
        {
            Categorias X = new Categorias();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerCategoriaPorID";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pID", ID);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                X.IdCategoria = ID;
                X.IdCategoriaPadre = Convert.ToInt32(DataReader["IdCategoriaPadre"]);
                X.Imagen = DataReader["Imagen"].ToString();
                X.Nombre = DataReader["Nombre"].ToString();
            }

            Conexion.Close();

            return X;
        }

        public void ModificarPublicacion (Publicacion X)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ModificarPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdPublicacion", X.IdPublicacion);
            Comando.Parameters.AddWithValue("@pImagen1", X.Titulo);
            Comando.Parameters.AddWithValue("@pImagen2", X.Titulo);
            Comando.Parameters.AddWithValue("@pImagen3", X.Titulo);
            Comando.Parameters.AddWithValue("@pValor", X.Valor);
            Comando.Parameters.AddWithValue("@pTitulo", X.Titulo);
            Comando.Parameters.AddWithValue("@pDescripcion", X.Descripcion);
            Comando.Parameters.AddWithValue("@pUbicacion", X.Ubicacion);

            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public List<Categorias> TraerCategoriaPadreDesdeCategoriaHija(int IDHija, int IdUsuario)
          {
            List<Categorias> X = new List<Categorias>();

            Categorias cat = TraerCategoriaPorID(IDHija);
            while (cat.IdCategoriaPadre != -1)
            {
                X.Add(cat);
                cat = TraerCategoriaPorID(cat.IdCategoriaPadre);
            }
            X.Add(cat);

            return X;
          }
    }
}