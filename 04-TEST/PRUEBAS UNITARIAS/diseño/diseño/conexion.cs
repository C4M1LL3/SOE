using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LinqToDB;
using static LinqToDB.DataProvider.SqlServer.SqlServerProviderAdapter;

namespace diseño
{
    class conexion
    {
        public static System.Data.SqlClient.SqlConnection ObtenerConexion()
        {
            System.Data.SqlClient.SqlConnection conect = new System.Data.SqlClient.SqlConnection("Data Source = LAPTOP-H4OQ11HQ; Initial Catalog = SOE; Integrated Security = true");
            conect.Open();

            return conect;
        }
    }
}
