using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace datos
{
    public class GestionarDatos
    {

        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string error;

        public GestionarDatos()
        {

            this.conexion = datos.conexion.getconexion();
        }
        public bool agregarUser(user unUser)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into system_userr values(@login, ENCRYPTBYPASSPHRASE(@patron, @password), @institutional_email, @image)";
            comando.Parameters.AddWithValue("@login", unUser.Login);
            comando.Parameters.AddWithValue("@password", unUser.Password);
            comando.Parameters.AddWithValue("@patron", unUser).Value = "patron";
            comando.Parameters.AddWithValue("@institutional_email", unUser.Institutional_email);
            comando.Parameters.AddWithValue("@image", unUser.Image);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarRolUser (user_rol unRolUser)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into rol_user values(@name_rol, (select id from system_userr where id = (select max(id) from system_userr)))";
            comando.Parameters.AddWithValue("@name_rol", unRolUser.Name_rol);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarPerson(person unaPerson)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into person values(@document_number, @type_document_id, @first_name, @second_name, @first_last_name, @second_last_name,(select id from system_userr where id = (select max(id) from system_userr)))";
            comando.Parameters.AddWithValue("@document_number", unaPerson.Document_number);
            comando.Parameters.AddWithValue("@type_document_id", unaPerson.Type_document_id);
            comando.Parameters.AddWithValue("@first_name", unaPerson.First_name);
            comando.Parameters.AddWithValue("@second_name", unaPerson.Second_name);
            comando.Parameters.AddWithValue("@first_last_name", unaPerson.First_last_name);
            comando.Parameters.AddWithValue("@second_last_name", unaPerson.Second_last_name);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarSubject(subject unSubject)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into subject values(@name_subject)";
            comando.Parameters.AddWithValue("@name_subject", unSubject.Name_subject);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarMatter(matter unaMatter)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into matter values(@name_matter, @name_subject)";
            comando.Parameters.AddWithValue("@name_matter", unaMatter.Name_matter);
            comando.Parameters.AddWithValue("@name_subject", unaMatter.Name_subject);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarTeacher(teacher unTeacher)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into teacher values(@person_id, @name_working_day, @matter_id)";
            comando.Parameters.AddWithValue("@person_id", unTeacher.Person_id);
            comando.Parameters.AddWithValue("@name_working_day", unTeacher.Name_working_day);
            comando.Parameters.AddWithValue("@matter_id", unTeacher.Matter_id);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarCourse(course unCourse)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into course values(@number_course, @number_year, @number_cycle, @teacher_id)";
            comando.Parameters.AddWithValue("@number_course", unCourse.Number_course);
            comando.Parameters.AddWithValue("@number_year", unCourse.Number_year);
            comando.Parameters.AddWithValue("@number_cycle", unCourse.Number_cycle);
            comando.Parameters.AddWithValue("@teacher_id", unCourse.Teacher_id);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarCoordinator(coordinator unCoordinator)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into coordinator values(@person_id, @number_cycle)";
            comando.Parameters.AddWithValue("@number_course", unCoordinator.Number_cycle);
            comando.Parameters.AddWithValue("@number_year", unCoordinator.Person_id);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public bool agregarSecretary(secretary unSecretary)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into secretary values(@person_id, @name_working_day)";
            comando.Parameters.AddWithValue("@person_id", unSecretary.Person_id);
            comando.Parameters.AddWithValue("@name_working_day", unSecretary.Name_working_day);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }
        public bool agregarStudent(student unStudent)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into student values(@person_id, @birth_date, @birth_place, @course_id )";
            comando.Parameters.AddWithValue("@person_id", unStudent.Person_id);
            comando.Parameters.AddWithValue("@Birth_date", unStudent.Birth_date);
            comando.Parameters.AddWithValue("@Birth_place", unStudent.Birth_place);
            comando.Parameters.AddWithValue("@Course_id", unStudent.Course_id);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;

        }
    }
}
