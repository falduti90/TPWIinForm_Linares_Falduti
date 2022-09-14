using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                DataBase.setearConsulta("select  Id, Descripcion from MARCAS"); //consulta SELECT sql
                DataBase.ejecutarLectura();

                while (DataBase.Lector.Read())
                {
                    Marca Obj = new Marca();
                    Obj.MarcaId = (int)DataBase.Lector["Id"];
                    Obj.Descripcion= (string)DataBase.Lector["Description"];    
                    //hay q hacer la consulta y cargar los valores obtenidos dentro del objeto obj

                    list.Add(Obj);
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
