using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace diseño
{
    class RegistrarUsuarioDAL
    {
        public static int RegistrarUsuario(string plogin, string ppassword, string pinstitutional_email)
        {
            int resultado = 0;
            System.Data.SqlClient.SqlConnection conect = conexion.ObtenerConexion();
            {

                SqlCommand comando = new SqlCommand(string.Format("Insert Into system_userr(login, password, institutional_email) values ('{0}',HashBytes('MD5','{1}'),'{2}')", plogin, ppassword, pinstitutional_email), conect);
                resultado = comando.ExecuteNonQuery();

            }
            return resultado;
        }

        public static int AutenticarUsu(string plogin, string ppassword)
        {
            int resultado = -1;
            System.Data.SqlClient.SqlConnection conect = conexion.ObtenerConexion();
            SqlCommand comando = new SqlCommand(String.Format("Select * from system_userr where login = '{0}' and HashBytes('MD5','{1}')= password", plogin, ppassword), conect);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conect.Close();
            return resultado;

        }

    }
}
