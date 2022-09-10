using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio_Clases;

namespace Reglas_Negocio
{
    public class Articulo_Negocio
    {

        public List <Articulo> ListarArticulos ()
        {
            List<Articulo> list = new List<Articulo> ();
            Acceso_A_Db DataBase = new Acceso_A_Db ();

            try
            {

                return list;
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
