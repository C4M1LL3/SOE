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
            System.Data.SqlClient.SqlConnection conect = new System.Data.SqlClient.SqlConnection("Data Source = LAPTOP-BI35QFNL\\MSSQLSERVER2; Initial Catalog = Soe; Integrated Security = true");
            conect.Open();

            return conect;
        }
    }
}
