using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    class conexion
    {
        private static SqlConnection objconexion;
        private static string error;

        public static SqlConnection getconexion()
        {
            if (objconexion != null)
                return objconexion;
            objconexion = new SqlConnection();
            objconexion.ConnectionString = "Data Source=LAPTOP-H4OQ11HQ; Initial catalog=SOE; Integrated Security=True";
            try
            {
                objconexion.Open();
                return objconexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }
        public void cerrarconexion()
        {
            if (objconexion != null)
                objconexion.Close();
        }
    }
}
