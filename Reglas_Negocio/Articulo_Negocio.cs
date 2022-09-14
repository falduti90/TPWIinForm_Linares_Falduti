using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Clases;
using Reglas_Negocio;

namespace Reglas_Negocio
{
    public class Articulo_Negocio
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> list = new List<Articulo>();
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta("SELECT ART.ID, ART.CODIGO, ART.NOMBRE, ART.DESCRIPCION, MAR.ID, MAR.DESCRIPCION AS MARCA, CAT.ID, CAT.DESCRIPCION AS TIPO, ART.IMAGENURL, ART.PRECIO  FROM ARTICULOS AS ART " +
                    "INNER JOIN MARCAS AS MAR ON MAR.ID = ART.IDMARCA " +
                    "INNER JOIN CATEGORIAS AS CAT ON CAT.ID = MAR.ID");
                DataBase.ejecutarLectura();

                while (DataBase.Lector.Read())
                {
                    Articulo obj = new Articulo();

                    obj.ArticuloId = DataBase.Lector.GetInt32(0);
                    obj.Codigo = DataBase.Lector.GetString(1);
                    obj.Nombre = DataBase.Lector.GetString(2);
                    obj.Descripcion = DataBase.Lector.GetString(3);

                    obj.Marca = new Marca();
                    obj.Marca.MarcaId = DataBase.Lector.GetInt32(4);
                    obj.Marca.Descripcion = DataBase.Lector.GetString(5);

                    obj.Categoria = new Categoria();
                    obj.Categoria.CategoriaId = DataBase.Lector.GetInt32(6);
                    obj.Categoria.Descripcion = DataBase.Lector.GetString(7);

                    obj.URLImagen = DataBase.Lector.GetString(8);
                    obj.Precio = DataBase.Lector.GetDecimal(9);

                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DataBase.cerrarConexion();
            }

            return list;
        }

        public void Insertar_Articulo(Articulo NuevoArticulo)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                /*DataBase.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) " +
                "values('" + NuevoArticulo.Codigo + "', '" + NuevoArticulo.Nombre + "', '" + NuevoArticulo.Descripcion + "', " +
                "" + NuevoArticulo.Precio + ", @IdMarca, @IdCategoria, @ImagenUrl");

                DataBase.setearParametro("@ImagenUrl", NuevoArticulo.URLImagen);
                
                DataBase.setearParametro("@idMarca", NuevoArticulo.Marca.MarcaId);
                DataBase.setearParametro("@idCategoria", NuevoArticulo.Categoria.CategoriaId);*/


                DataBase.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) " +
                "values(@Codigo, @nombre, @desc, @Precio, @idMarca, @idDCategoria, @Url)");

                DataBase.setearParametro("@Codigo", NuevoArticulo.Codigo);
                DataBase.setearParametro("@nombre", NuevoArticulo.Nombre);
                DataBase.setearParametro("@desc", NuevoArticulo.Descripcion);
                DataBase.setearParametro("@Url", NuevoArticulo.URLImagen);
                DataBase.setearParametro("@idMarca", NuevoArticulo.Marca.MarcaId);
                DataBase.setearParametro("@idDCategoria", NuevoArticulo.Categoria.CategoriaId);
                DataBase.setearParametro("@Precio", NuevoArticulo.Precio);
                DataBase.setearParametro("@Id", NuevoArticulo.ArticuloId);

                DataBase.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DataBase.cerrarConexion();
            }
        }

        public void EliminarFisico(Articulo ArticuloEliminar)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta("delete from CATALOGO_DB where id=@id"); //consulta DELETE sql NO OLVIDAR WHERE
                DataBase.setearParametro("@id", ArticuloEliminar.ArticuloId);
                DataBase.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DataBase.cerrarConexion();
            }

        }

        public void Modificar_Articulo(Articulo NuevoArticulo)
        {
            Acceso_A_Db datos = new Acceso_A_Db();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo =@Codigo , Nombre = @nombre, Descripcion = @desc, " +
                "ImagenUrl = @Url, IdMarca = @idMarca, IdCategoria= @idDCategoria,Precio= @Precio Where Id =@Id");
                datos.setearParametro("@Codigo", NuevoArticulo.Codigo);
                datos.setearParametro("@nombre", NuevoArticulo.Nombre);
                datos.setearParametro("@desc", NuevoArticulo.Descripcion);
                datos.setearParametro("@Url", NuevoArticulo.URLImagen);
                datos.setearParametro("@idMarca", NuevoArticulo.Marca.MarcaId);
                datos.setearParametro("@idDCategoria", NuevoArticulo.Categoria.CategoriaId);
                datos.setearParametro("@Precio", NuevoArticulo.Precio);
                datos.setearParametro("@Id", NuevoArticulo.ArticuloId);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

