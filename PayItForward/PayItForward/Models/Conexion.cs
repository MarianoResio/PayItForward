using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Web.Mvc;
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
            Comando.Parameters.AddWithValue("@pImagen1", UnaPublicacion.Imagenes[0].FileName);
            switch (UnaPublicacion.Imagenes.Length)
            {
                case 1:
                    Comando.Parameters.AddWithValue("@pImagen2", DBNull.Value);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 2:
                    Comando.Parameters.AddWithValue("@pImagen2", UnaPublicacion.Imagenes[1].FileName);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 3:
                    Comando.Parameters.AddWithValue("@pImagen2", UnaPublicacion.Imagenes[1].FileName);
                    Comando.Parameters.AddWithValue("@pImagen3", UnaPublicacion.Imagenes[2].FileName);
                    break;
            }
            Comando.Parameters.AddWithValue("@pAprobada", UnaPublicacion.Aprobada);
            Comando.Parameters.AddWithValue("@pValor", UnaPublicacion.Valor);
            Comando.Parameters.AddWithValue("@pTitulo", UnaPublicacion.Titulo);
            Comando.Parameters.AddWithValue("@pDescripcion", UnaPublicacion.Descripcion);
            Comando.Parameters.AddWithValue("@pLikes", UnaPublicacion.Likes);
            Comando.Parameters.AddWithValue("@pUbicacion", UnaPublicacion.Ubicacion);
            Comando.Parameters.AddWithValue("@pDestacada", UnaPublicacion.Destacada);

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
                DateTime Hasta_Traido = Convert.ToDateTime(DataReader["Hasta"]);

                Banners X = new Banners(IdBanner_Traido, Hasta_Traido, Imagen_Traida);
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

        public List<Categorias> TraerCategoriasHijasPorNombre(string NombreCategoriaPadre)
        {
            int id =-5;
            List<Categorias> Lista = new List<Categorias>();

            id = traerIDCategoriaPorNombre(NombreCategoriaPadre);

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerCategoriasPorNombrePadre";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", id);
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
                List<string> ImgTraida = new List<string>();
                ImgTraida.Add(DataReader["Imagen1"].ToString());
                ImgTraida.Add(DataReader["Imagen2"].ToString());
                ImgTraida.Add(DataReader["Imagen3"].ToString());
                bool Aprobado_Traido = Convert.ToBoolean(DataReader["Aprobada"]);
                int Valor_Traido = Convert.ToInt32(DataReader["Valor"]);
                string Titulo_Traido = DataReader["Titulo"].ToString();
                string Descripcion_Traida = DataReader["Descripcion"].ToString();
                int Likes_Traidos = Convert.ToInt32(DataReader["Likes"]);
                string Ubicacion_Traida = DataReader["Ubicacion"].ToString();
                bool Destacada_Traida = Convert.ToBoolean(DataReader["Destacada"]);

                Publicacion X = new Publicacion(IdPublicacion_Traido, IdCategoria_Traido, IdUsuario_Traido, ImgTraida, Aprobado_Traido, Valor_Traido, Titulo_Traido, Descripcion_Traida, Likes_Traidos, Ubicacion_Traida, Destacada_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public Publicacion TraerPublicacionPorId(int IdPublicacion)
        {
            Publicacion X = new Publicacion();
            X.NombreImagen = new List<string>();
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
                X.NombreImagen.Add(DataReader["Imagen1"].ToString());
                X.NombreImagen.Add(DataReader["Imagen2"].ToString());
                X.NombreImagen.Add(DataReader["Imagen3"].ToString());
                X.Aprobada = Convert.ToBoolean(DataReader["Aprobada"]);
                X.Valor = Convert.ToInt32(DataReader["Valor"]);
                X.Titulo = DataReader["Titulo"].ToString();
                X.Descripcion = DataReader["Descripcion"].ToString();
                X.Likes = Convert.ToInt32(DataReader["Likes"]);
                X.Ubicacion = DataReader["Ubicacion"].ToString();
                X.Destacada = Convert.ToBoolean(DataReader["Destacada"]);
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

        public void ModificarPublicacionSinImagen(Publicacion X)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ModificarPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdPublicacion", X.IdPublicacion);
            Comando.Parameters.AddWithValue("@pImagen1", X.NombreImagen[0]);
            switch (X.NombreImagen.Count)
            {
                case 1:
                    Comando.Parameters.AddWithValue("@pImagen2", DBNull.Value);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 2:
                    Comando.Parameters.AddWithValue("@pImagen2", X.NombreImagen[1]);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 3:
                    Comando.Parameters.AddWithValue("@pImagen2", X.NombreImagen[1]);
                    Comando.Parameters.AddWithValue("@pImagen3", X.NombreImagen[2]);
                    break;
            }
            Comando.Parameters.AddWithValue("@pValor", X.Valor);
            Comando.Parameters.AddWithValue("@pTitulo", X.Titulo);
            Comando.Parameters.AddWithValue("@pDescripcion", X.Descripcion);
            Comando.Parameters.AddWithValue("@pUbicacion", X.Ubicacion);
            Comando.Parameters.AddWithValue("@pDestacada", X.Destacada);

            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public void ModificarPublicacionConImagen(Publicacion X)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ModificarPublicacion";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdPublicacion", X.IdPublicacion);
            Comando.Parameters.AddWithValue("@pImagen1", X.Imagenes[0].FileName);
            switch (X.Imagenes.Length)
            {
                case 1:
                    Comando.Parameters.AddWithValue("@pImagen2", DBNull.Value);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 2:
                    Comando.Parameters.AddWithValue("@pImagen2", X.Imagenes[1].FileName);
                    Comando.Parameters.AddWithValue("@pImagen3", DBNull.Value);
                    break;
                case 3:
                    Comando.Parameters.AddWithValue("@pImagen2", X.Imagenes[1].FileName);
                    Comando.Parameters.AddWithValue("@pImagen3", X.Imagenes[2].FileName);
                    break;
            }
            Comando.Parameters.AddWithValue("@pValor", X.Valor);
            Comando.Parameters.AddWithValue("@pTitulo", X.Titulo);
            Comando.Parameters.AddWithValue("@pDescripcion", X.Descripcion);
            Comando.Parameters.AddWithValue("@pUbicacion", X.Ubicacion);
            Comando.Parameters.AddWithValue("@pDestacada", X.Destacada);

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

        public List<Publicacion> TraerTodxsLxsPublicacionos()
        {
            List<Publicacion> Lista = new List<Publicacion>();
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerTodasLasPublicaciones";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdPublicacion_Traido = Convert.ToInt32(DataReader["IdPublicacion"]);
                int IdCategoria_Traido = Convert.ToInt32(DataReader["IdCategoria"]);
                int IdUsuario_Traido = Convert.ToInt32(DataReader["IdUsuario"]);
                List<string> ImgTraida = new List<string>();
                ImgTraida.Add(DataReader["Imagen1"].ToString());
                ImgTraida.Add(DataReader["Imagen2"].ToString());
                ImgTraida.Add(DataReader["Imagen3"].ToString());
                bool Aprobado_Traido = Convert.ToBoolean(DataReader["Aprobada"]);
                int Valor_Traido = Convert.ToInt32(DataReader["Valor"]);
                string Titulo_Traido = DataReader["Titulo"].ToString();
                string Descripcion_Traida = DataReader["Descripcion"].ToString();
                int Likes_Traidos = Convert.ToInt32(DataReader["Likes"]);
                string Ubicacion_Traida = DataReader["Ubicacion"].ToString();
                bool Destacada_Traida = Convert.ToBoolean(DataReader["Destacada"]);

                Publicacion X = new Publicacion(IdPublicacion_Traido, IdCategoria_Traido, IdUsuario_Traido, ImgTraida, Aprobado_Traido, Valor_Traido, Titulo_Traido, Descripcion_Traida, Likes_Traidos, Ubicacion_Traida, Destacada_Traida);
                Lista.Add(X);
            }

            Conexion.Close();

            return Lista;
        }

        public Usuarios Login(string mail, string pass)
        {
            Usuarios X = new Usuarios();
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_Login";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pMail", mail);
            Comando.Parameters.AddWithValue("@pPassword", pass);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                int IdUsuario_Traido = Convert.ToInt32(DataReader["IdUsuario"]);
                string Nombre_Traido = DataReader["Nombre"].ToString();
                string Apellido_Traido = DataReader["Apellido"].ToString();
                string Imagen_Traida = DataReader["Imagen"].ToString();
                int Puntos_traidos = Convert.ToInt32(DataReader["Puntos"]);
                X.IdUsuario = IdUsuario_Traido;
                X.Nombre = Nombre_Traido;
                X.Apellido = Apellido_Traido;
                X.Contrasena = pass;
                X.Mail = mail;
                X.Imagen = Imagen_Traida;
                X.Puntos = Puntos_traidos;
            }
            return X;
        }

        public bool ValidarUsuarioEspecialPorCodigo(string codigo)
        {
            bool respuesta = false;

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ValidarUsuarioEspecialPorCodigo";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pCodigo", codigo);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                respuesta = true;
            }
            return respuesta;
        }

        public void altaUsuario(Usuarios user)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_altaUsuario";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pNombre", user.Nombre);
            Comando.Parameters.AddWithValue("@pApellido", user.Apellido);
            Comando.Parameters.AddWithValue("@pMail", user.Mail);
            Comando.Parameters.AddWithValue("@pContrasena", user.Contrasena);
            Comando.Parameters.AddWithValue("@pImagen", user.Imagen);
            Comando.Parameters.AddWithValue("@pPuntos", user.Puntos);
            Comando.Parameters.AddWithValue("@pEspecial", user.Especial);
            SqlDataReader DataReader = Comando.ExecuteReader();
        }

        public void borrarCodigoEspecial(string codigo)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_borrarCodigoEspecial";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pCodigo", codigo);
            Comando.ExecuteNonQuery();
            Conexion.Close();

        }
        public string TraerNombreCategoriaPorId(int idCategoria)
        {
            string Cate = "";
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerNombreCategoriaPorId";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", idCategoria);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                string Nombre_Traido = DataReader["Nombre"].ToString();
                Cate = Nombre_Traido;
            }
            return Cate;
        }

        public List<Publicacion> BusquedaPublicacionesPorTexto(string texto)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_busquedaPublicacionPorTexto";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pBusqueda", texto);
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                int IdPublicacion_Traido = Convert.ToInt32(DataReader["IdPublicacion"]);
                int IdCategoria_Traido = Convert.ToInt32(DataReader["IdCategoria"]);
                int IdUsuario_Traido = Convert.ToInt32(DataReader["IdUsuario"]);
                List<string> ImgTraida = new List<string>();
                ImgTraida.Add(DataReader["Imagen1"].ToString());
                ImgTraida.Add(DataReader["Imagen2"].ToString());
                ImgTraida.Add(DataReader["Imagen3"].ToString());
                bool Aprobado_Traido = Convert.ToBoolean(DataReader["Aprobada"]);
                int Valor_Traido = Convert.ToInt32(DataReader["Valor"]);
                string Titulo_Traido = DataReader["Titulo"].ToString();
                string Descripcion_Traida = DataReader["Descripcion"].ToString();
                int Likes_Traidos = Convert.ToInt32(DataReader["Likes"]);
                string Ubicacion_Traida = DataReader["Ubicacion"].ToString();
                bool Destacada_Traida = Convert.ToBoolean(DataReader["Destacada"]);

                Publicacion X = new Publicacion(IdPublicacion_Traido, IdCategoria_Traido, IdUsuario_Traido, ImgTraida, Aprobado_Traido, Valor_Traido, Titulo_Traido, Descripcion_Traida, Likes_Traidos, Ubicacion_Traida, Destacada_Traida);
                publicaciones.Add(X);
            }
            Conexion.Close();
            return publicaciones;
        }

        public Usuarios traerUsuarioPorId(int id)
        {
            Usuarios user = new Usuarios();

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerUsuarioPorId";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", id);
            SqlDataReader DataReader = Comando.ExecuteReader();

            if (DataReader.Read())
            {
                user.Apellido = DataReader["Apellido"].ToString();
                user.Nombre = DataReader["Nombre"].ToString();
                user.Puntos = Convert.ToInt32(DataReader["Puntos"]);
                user.Imagen = DataReader["Imagen"].ToString();
                user.Mail = DataReader["Mail"].ToString();
                user.Contrasena = DataReader["Contrasena"].ToString();
                user.Especial = Convert.ToBoolean(DataReader["Especial"]);
                user.IdUsuario = id;
            }

            Conexion.Close();

            return user;
        }

        public void ObtenerPublicacionNoEspecial (int idPublicacion, int idComprador, int idVendedor)
        {
            Publicacion publicacion = TraerPublicacionPorId(idPublicacion);

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ObtenerPublicacionNoEspecial";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdComprador", idComprador);
            Comando.Parameters.AddWithValue("@pIdVendedor", idVendedor);
            Comando.Parameters.AddWithValue("@pValor", publicacion.Valor);

            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ObtenerPublicacionEspecial(int idPublicacion, int idVendedor)
        {
            Publicacion publicacion = TraerPublicacionPorId(idPublicacion);

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_ObtenerPublicacionEspecial";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pIdVendedor", idVendedor);
            Comando.Parameters.AddWithValue("@pValor", publicacion.Valor);

            Comando.ExecuteNonQuery();
            Conexion.Close();
        }

        public int traerIDCategoriaPorNombre(string nombreCate)
        {
            int id = -10;

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_traerIDCategoriaPorNombre";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pNombreCate", nombreCate);
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                id = Convert.ToInt32(DataReader["IdCategoria"]);
            }

            Conexion.Close();

            return id;
        }

        public List<Publicacion> TraerPublicacionesPorIdCategoria (int id)
        {
            List<Publicacion> lista = new List<Publicacion>();
            Publicacion X = new Publicacion(); 

            SqlConnection Conexion = Conectar();
            SqlCommand Comando = Conexion.CreateCommand();

            Comando.CommandText = "sp_TraerPublicacionesPorCategoria";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@pId", id);
            SqlDataReader DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                X.NombreImagen = new List<string>();
                X.IdPublicacion = Convert.ToInt32(DataReader["IdPublicacion"]);
                X.IdCategoria = Convert.ToInt32(DataReader["IdCategoria"]);
                X.IdUsuario = Convert.ToInt32(DataReader["IdUsuario"]);
                X.NombreImagen.Add(DataReader["Imagen1"].ToString());
                X.NombreImagen.Add(DataReader["Imagen2"].ToString());
                X.NombreImagen.Add(DataReader["Imagen3"].ToString());
                X.Aprobada = Convert.ToBoolean(DataReader["Aprobada"]);
                X.Valor = Convert.ToInt32(DataReader["Valor"]);
                X.Titulo = DataReader["Titulo"].ToString();
                X.Descripcion = DataReader["Descripcion"].ToString();
                X.Likes = Convert.ToInt32(DataReader["Likes"]);
                X.Ubicacion = DataReader["Ubicacion"].ToString();
                X.Destacada = Convert.ToBoolean(DataReader["Destacada"]);

                lista.Add(X);
            }

            Conexion.Close();

            return lista;
        }

        public List<Publicacion> TraerPublicacionesBusquedaCategoria(string nombrePadre)
        {
            int IdCate = traerIDCategoriaPorNombre(nombrePadre);
            
            List<Publicacion> Lista = new List<Publicacion>();

            List<Categorias> catHijas = new List<Categorias>();
            catHijas = TraerCategoriasHijas(IdCate);

            foreach (Categorias cat in catHijas)
            {
                List<Publicacion> listaPubHijas = TraerPublicacionesPorIdCategoria(cat.IdCategoria);
                foreach (Publicacion P in listaPubHijas)
                {
                    Lista.Add(P);
                }
            }

            return Lista;
        }
    }
}