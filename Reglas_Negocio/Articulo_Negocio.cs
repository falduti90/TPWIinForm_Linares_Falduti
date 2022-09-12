using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Clases;

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
                    obj.Marca.Id = DataBase.Lector.GetInt32(4);
                    obj.Marca.Descripcion = DataBase.Lector.GetString(5);

                    obj.Categoria = new Categoria();
                    obj.Categoria.Id = DataBase.Lector.GetInt32(6);
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

        public void Agregar(Articulo NuevoArticulo)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta(""); //consulta INSERT sql
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

        public void Modificar(Articulo ArticuloModificar)
        {
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta(""); //consulta UPDATE sql NO OLVIDAR WHERE
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
                DataBase.setearConsulta(""); //consulta DELETE sql NO OLVIDAR WHERE
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
    }
}

