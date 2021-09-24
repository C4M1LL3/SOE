using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace diseño
{
    class RegistrarPersonaDAL
    {
        public static int AgregarP(Persona pPerson)
        {
            int retorno = 0;
            using (SqlConnection conect = conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into person (document_number, type_document_id, first_name, second_name, first_last_name, second_last_name) values ('{0}','{1}','{2}','{3}','{4}','{5}')", pPerson.document_number, pPerson.type_document_id, pPerson.first_name, pPerson.second_name, pPerson.first_last_name, pPerson.second_last_name), conect);
                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
