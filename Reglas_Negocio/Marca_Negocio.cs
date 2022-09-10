using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio_Clases;

namespace Reglas_Negocio
{
    public class Marca_Negocio
    {

        public List<Marca> ListarMarcas()
        {
            List<Marca> list = new List<Marca>();
            Acceso_A_Db DataBase = new Acceso_A_Db();

            try
            {
                DataBase.setearConsulta(""); //consulta SELECT sql
                DataBase.ejecutarLectura();

                while (DataBase.Lector.Read())
                {
                    Marca obj = new Marca();

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
