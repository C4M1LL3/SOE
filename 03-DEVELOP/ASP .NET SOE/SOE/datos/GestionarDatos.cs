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

        public bool agregarFather(father unFather)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into father values(@person_id, @number_father, @address_father)";
            comando.Parameters.AddWithValue("@person_id", unFather.Person_id);
            comando.Parameters.AddWithValue("@number_father", unFather.Number_father);
            comando.Parameters.AddWithValue("@address_father", unFather.Address_father);
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

        public bool agregarMother(mother unaMother)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into mother values(@person_id, @number_mother, @address_mother)";
            comando.Parameters.AddWithValue("@person_id", unaMother.Person_id);
            comando.Parameters.AddWithValue("@number_father", unaMother.Number_mother);
            comando.Parameters.AddWithValue("@address_father", unaMother.Address_mother);
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

        public bool agregarTutor(tutor unTutor)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into tutor values(@person_id, @number_tutor, @address_tutor)";
            comando.Parameters.AddWithValue("@person_id", unTutor.Person_id);
            comando.Parameters.AddWithValue("@number_tutor", unTutor.Number_tutor);
            comando.Parameters.AddWithValue("@address_tutor", unTutor.Address_tutor);
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

        public person consultarPerson(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from person where document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                person unaPersona = new person();
                unaPersona.Id = registro.GetInt32(0);
                unaPersona.Document_number = registro.GetInt32(1);
                unaPersona.Type_document_id = registro.GetInt32(2);
                unaPersona.First_name = registro.GetString(3);
                unaPersona.Second_name = registro.GetString(4);
                unaPersona.First_last_name = registro.GetString(5);
                unaPersona.Second_last_name = registro.GetString(6);
                unaPersona.User_id = registro.GetInt32(7);
                registro.Close();
                return unaPersona;
            }
            else
            {
                registro.Close();
                return null;
            }
        }

        public user ConsultarUser(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select su.id, su.login, su.password, su.institutional_email, su.image from system_userr su inner join person p on su.id = p.user_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                user unUser = new user();
                unUser.Id = registro.GetInt32(0);
                unUser.Login = registro.GetString(1);
                unUser.Password = registro.GetString(2);
                unUser.Institutional_email = registro.GetString(3);
                unUser.Image = registro.GetString(4);
                registro.Close();
                return unUser;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public user_rol ConsultarUserRol(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from person p inner join system_userr su on su.id = p.user_id inner join rol_user ru on ru.user_id = su.id inner join rol r on r.name_rol = ru.name_rol where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                user_rol unRolUser = new user_rol();
                unRolUser.Id = registro.GetInt32(0);
                unRolUser.Name_rol = registro.GetString(1);
                registro.Close();
                return unRolUser;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public type_document ConsultarTypeDocument(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select td.id, td.abbreviation, td.document_name, td.document_status from person p inner join type_document td on td.id = p.type_document_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                type_document unTypeDocument = new type_document();
                unTypeDocument.Id = registro.GetInt32(0);
                unTypeDocument.Abbrevation = registro.GetString(1);
                unTypeDocument.Document_name = registro.GetString(2);
                unTypeDocument.Document_status = registro.GetString(3);
                registro.Close();
                return unTypeDocument;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public course ConsultarCourse(int number_course)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from course where number_course = @number_course";
            comando.Parameters.AddWithValue("@number_course", number_course);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                course unCourse = new course();
                unCourse.Id = registro.GetInt32(0);
                unCourse.Number_course = registro.GetInt32(1);
                unCourse.Number_cycle = registro.GetInt32(2);
                unCourse.Number_year = registro.GetInt32(3);
                unCourse.Teacher_id = registro.GetInt32(4);
                registro.Close();
                return unCourse;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public course ConsultarCourseS(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select c.number_course from course c inner join student s on s.course_id = c.id inner join person p on p.id = s.person_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                course unCourse = new course();
                unCourse.Number_course = registro.GetInt32(0);
                registro.Close();
                return unCourse;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public matter ConsultarMatter(int name_matter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from matter where name_matter = @name_matter";
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                matter unMatter = new matter();
                unMatter.Id = registro.GetInt32(0);
                unMatter.Name_matter = registro.GetString(1);
                unMatter.Name_subject = registro.GetString(3);
                registro.Close();
                return unMatter;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public matter ConsultarMatterT(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select m.name_matter from matter m inner join teacher t on t.matter_id = m.id inner join person p on p.id = t.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                matter unMatter = new matter();
                unMatter.Name_matter = registro.GetString(0);
                registro.Close();
                return unMatter;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public student ConsultarStudent(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select s.id, s.person_id, s.course_id, s.birth_date, s.birth_place from student s inner join person p on p.id = s.person_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                student unStudent = new student();
                unStudent.Id = registro.GetInt32(0);
                unStudent.Person_id = registro.GetInt32(1);
                unStudent.Course_id = registro.GetInt32(2);
                unStudent.Birth_date = registro.GetDateTime(3);
                unStudent.Birth_place = registro.GetString(4);
                registro.Close();
                return unStudent;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public teacher ConsultarTeacher(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select t.id, t.matter_id, t.name_working_day, t.person_id from teacher t inner join person p on p.id = t.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                teacher unTeacher = new teacher();
                unTeacher.Id = registro.GetInt32(0);
                unTeacher.Matter_id = registro.GetInt32(1);
                unTeacher.Name_working_day = registro.GetString(2);
                unTeacher.Person_id = registro.GetInt32(0);
                registro.Close();
                return unTeacher;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public coordinator ConsultarCoordinator(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select c.id, c.number_cycle, c.person_id from coordinator c inner join person p on p.id = c.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                coordinator unCoordinator = new coordinator();
                unCoordinator.Id = registro.GetInt32(0);
                unCoordinator.Number_cycle = registro.GetInt32(1);
                unCoordinator.Person_id = registro.GetInt32(2);
                registro.Close();
                return unCoordinator;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public secretary ConsultarSecretary(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select s.id, s.name_working_day, s.person_id from secretary s inner join person p on p.id = s.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                secretary unSecretary = new secretary();
                unSecretary.Id = registro.GetInt32(0);
                unSecretary.Name_working_day = registro.GetString(1);
                unSecretary.Person_id = registro.GetInt32(2);
                registro.Close();
                return unSecretary;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public father ConsultarFather(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select f.id, f.address_father, f.number_father, f.person_id from father f inner join person p on p.id = f.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                father unFather= new father();
                unFather.Id = registro.GetInt32(0);
                unFather.Address_father = registro.GetString(1);
                unFather.Number_father = registro.GetInt32(2);
                unFather.Person_id = registro.GetInt32(2);
                registro.Close();
                return unFather;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public mother ConsultarMother(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select m.id, m.address_mother, m.number_mother, m.person_id from mother m inner join person p on p.id = m.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                mother unaMother = new mother();
                unaMother.Id = registro.GetInt32(0);
                unaMother.Address_mother = registro.GetString(1);
                unaMother.Number_mother = registro.GetInt32(2);
                unaMother.Person_id = registro.GetInt32(2);
                registro.Close();
                return unaMother;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public tutor ConsultarTutor(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select t.id, t.address_tutor, t.number_tutor, t.person_id from tutor t inner join person p on p.id = f.person_id where p.document_number = @document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                tutor unTutor = new tutor();
                unTutor.Id = registro.GetInt32(0);
                unTutor.Address_tutor = registro.GetString(1);
                unTutor.Number_tutor = registro.GetInt32(2);
                unTutor.Person_id = registro.GetInt32(2);
                registro.Close();
                return unTutor;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

    }
}
