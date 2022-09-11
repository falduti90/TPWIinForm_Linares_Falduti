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
                DataBase.setearConsulta(""); //consulta SELECT sql
                DataBase.ejecutarLectura();

                while (DataBase.Lector.Read())
                {
                    Articulo obj = new Articulo();

                    //hay q hacer la consulta y cargar los valores obtenidos dentro del objeto obj

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

