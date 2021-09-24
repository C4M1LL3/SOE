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
        public static List<Persona> BuscarPersona(string pDocumento)
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection conet = conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select id,document_number,type_document_id,first_name,second_name,first_last_name,second_last_name From person where document_number like '{0}'", pDocumento), conet);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Persona pPersona = new Persona();
                    pPersona.id = reader.GetInt32(0);
                    pPersona.document_number = reader.GetString(1);
                    pPersona.type_document_id = reader.GetString(2);
                    pPersona.first_name = reader.GetString(3);
                    pPersona.second_name = reader.GetString(4);
                    pPersona.first_last_name = reader.GetString(5);
                    pPersona.second_last_name = reader.GetString(6);
                    lista.Add(pPersona);
                }
                conet.Close();
                return lista;
            }
        }
    }
   
}
