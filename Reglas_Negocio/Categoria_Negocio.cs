using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio_Clases;

namespace Reglas_Negocio
{
    public class Categoria_Negocio
    {

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> list = new List<Categoria>();
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta(""); //consulta SELECT sql
                DataBase.ejecutarLectura();

                while (DataBase.Lector.Read())
                {
                    Categoria obj = new Categoria();

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
    }
}
