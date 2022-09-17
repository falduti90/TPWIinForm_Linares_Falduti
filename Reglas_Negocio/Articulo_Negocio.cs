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
                    //trunca a dos digitos el decimal
                    obj.Precio = decimal.Round(obj.Precio,2);

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
                DataBase.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) " +
                "values(@Codigo, @nombre, @desc, @Precio, @idMarca, @idDCategoria, @Url)");

                DataBase.setearParametro("@Codigo", NuevoArticulo.Codigo);
                DataBase.setearParametro("@nombre", NuevoArticulo.Nombre);
                DataBase.setearParametro("@desc", NuevoArticulo.Descripcion);
                DataBase.setearParametro("@Url", NuevoArticulo.URLImagen);
                DataBase.setearParametro("@idMarca", NuevoArticulo.Marca.MarcaId);
                DataBase.setearParametro("@idDCategoria", NuevoArticulo.Categoria.CategoriaId);
                DataBase.setearParametro("@Precio", NuevoArticulo.Precio);

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

        public void EliminarFisico(int id)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta("DELETE FROM ARTICULOS WHERE id = @id");

                DataBase.setearParametro("@id", id);

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

        public void Modificar_Articulo(Articulo NuevoArticulo, int IdArticulo)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();
            try
            {
                DataBase.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Desc, " +
                "IdMarca = @IdMarca, IdCategoria = @IdDCategoria, ImagenUrl = @Url, Precio = @Precio Where Id = @Id");

                DataBase.setearParametro("@Codigo", NuevoArticulo.Codigo);
                DataBase.setearParametro("@Nombre", NuevoArticulo.Nombre);
                DataBase.setearParametro("@Desc", NuevoArticulo.Descripcion);
                DataBase.setearParametro("@Url", NuevoArticulo.URLImagen);
                DataBase.setearParametro("@IdMarca", NuevoArticulo.Marca.MarcaId);
                DataBase.setearParametro("@IdDCategoria", NuevoArticulo.Categoria.CategoriaId);
                DataBase.setearParametro("@Precio", NuevoArticulo.Precio);

                DataBase.setearParametro("@Id", IdArticulo);

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

        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            Acceso_A_Db Aux = new Acceso_A_Db();

            try
            {
                string Consulta = ("SELECT ART.ID, ART.CODIGO, ART.NOMBRE, ART.DESCRIPCION, MAR.ID, MAR.DESCRIPCION AS MARCA, CAT.ID, CAT.DESCRIPCION AS TIPO, ART.IMAGENURL, ART.PRECIO  FROM ARTICULOS AS ART, MARCAS AS MAR, CATEGORIAS AS CAT WHERE MAR.ID = ART.IDMARCA AND CAT.ID = MAR.ID AND ");
                switch (campo)
                {
                    case "Precio":
                            
                        if (campo=="Precio" && criterio== "Mayor a")
                        {
                            Consulta += "ART.PRECIO >" + filtro;
                        }
                        else
                        {
                            if(criterio == "Menor a")
                            {
                                Consulta += "ART.PRECIO <" + filtro;
                            }
                            else
                            {
                                Consulta += "ART.PRECIO =" + filtro;
                            }
                        }
                       
                        break;

                    case "Nombre":
                        if (criterio =="Comienza con") Consulta += "ART.NOMBRE  like '" + filtro + "%' ";
                        if (criterio =="Termina con")  Consulta += "ART.NOMBRE like '%" + filtro + "'";
                        if (criterio == "Contine") Consulta += "ART.NOMBRE like '%" + filtro + "%'";
                        break;

                    case "Categoria":
                        if (criterio == "Celulares")    Consulta += "CAT.DESCRIPCION  like 'Celulares' ";
                        if (criterio == "Televisores") Consulta += "CAT.DESCRIPCION  like 'Televisores'";
                        if (criterio == "Media") Consulta += "CAT.DESCRIPCION  like 'Media'";
                        if (criterio == "Audio") Consulta += "CAT.DESCRIPCION  like 'Audio'";
                        break;

                    default:
                        break;


                }
                Aux.setearConsulta(Consulta);
                Aux.ejecutarLectura();

                 while (Aux.Lector.Read())
                {
                    Articulo obj = new Articulo();

                    obj.ArticuloId = Aux.Lector.GetInt32(0);
                    obj.Codigo = Aux.Lector.GetString(1);
                    obj.Nombre = Aux.Lector.GetString(2);
                    obj.Descripcion = Aux.Lector.GetString(3);

                    obj.Marca = new Marca();
                    obj.Marca.MarcaId = Aux.Lector.GetInt32(4);
                    obj.Marca.Descripcion = Aux.Lector.GetString(5);

                    obj.Categoria = new Categoria();
                    obj.Categoria.CategoriaId = Aux.Lector.GetInt32(6);
                    obj.Categoria.Descripcion = Aux.Lector.GetString(7);

                    obj.URLImagen = Aux.Lector.GetString(8);
                    obj.Precio = Aux.Lector.GetDecimal(9);

                    lista.Add(obj);

                }
                return lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}

