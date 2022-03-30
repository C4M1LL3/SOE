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
            comando.CommandText = "insert into coordinator (person_id, number_cycle) values((select id from person where document_number=@document_number),@number_cycle)";
            comando.Parameters.AddWithValue("@document_number", unCoordinator.Person_id);
            comando.Parameters.AddWithValue("@number_cycle", unCoordinator.Number_cycle);
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
            comando.Parameters.AddWithValue("@number_mother", unaMother.Number_mother);
            comando.Parameters.AddWithValue("@address_mother", unaMother.Address_mother);
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

        public bool agregarEnrollmentt(enrollmentt unEnrollmentt)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into enrollment values(@student_id, @id_eps, @address, @home_number, @state, @father_id, @mother_id, @tutor_id)";
            comando.Parameters.AddWithValue("@student_id", unEnrollmentt.Student_id);
            comando.Parameters.AddWithValue("@id_eps", unEnrollmentt.Eps_id);
            comando.Parameters.AddWithValue("@address", unEnrollmentt.Address);
            comando.Parameters.AddWithValue("@home_number", unEnrollmentt.Home_number);
            comando.Parameters.AddWithValue("@state", unEnrollmentt.State);
            comando.Parameters.AddWithValue("@father_id", unEnrollmentt.Father_id);
            comando.Parameters.AddWithValue("@mother_id", unEnrollmentt.Mother_id);
            comando.Parameters.AddWithValue("@tutor_id", unEnrollmentt.Tutor_id);
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

        public bool agregarNotaTrim(final_quarterly_grade unNoteTrim)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into final_quarterly_grade values (@student_id, @matter_id,@number_quarter, @seventy_percentage, @twenty_percentage, @ten_percentage, @final_grade)";
            comando.Parameters.AddWithValue("@student_id", unNoteTrim.Student_id);
            comando.Parameters.AddWithValue("@matter_id", unNoteTrim.Matter_id);
            comando.Parameters.AddWithValue("@number_quarter", unNoteTrim.Number_quarter);
            comando.Parameters.AddWithValue("@seventy_percentage", unNoteTrim.Seventy_porcentage);
            comando.Parameters.AddWithValue("@twenty_percentage", unNoteTrim.Twenty_porcentage);
            comando.Parameters.AddWithValue("@ten_percentage", unNoteTrim.Ten_porcentage);
            comando.Parameters.AddWithValue("@final_grade", unNoteTrim.Final_grade);
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

        public bool agregarNotaAnual(annual_final_grade unNoteAnnual)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into annual_final_grade values (@final_quarterly_grade_id, @annual_final_grade";
            comando.Parameters.AddWithValue("@final_quarterly_grade_id", unNoteAnnual.Final_quarterly_grade_id);
            comando.Parameters.AddWithValue("@annual_final_grade", unNoteAnnual.Annual_final_gradee);
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

        public bool agregarTimetable(timetablee unTimetable)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into timetable values(@archive_timetable, @course_id)";
            comando.Parameters.AddWithValue("@archive_timetable", unTimetable.Archive_timetable);
            comando.Parameters.AddWithValue("@course_id", unTimetable.Course_id);
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

        public bool agregarStudentHistory(student_historyy unStudentHistory)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into student_history values((select s.id from student s inner join person p on p.id = s.person_id where p.document_number = @document_number))";
            comando.Parameters.AddWithValue("@document_number", unStudentHistory.Student_id);
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

        public bool agregarStudentHistoryAnnotation(student_history_annotation unStudentHistoryAnnotation)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into student_history_annotation values((select sh.id from student_history sh inner join student s on s.id = sh.student_id inner join person p on p.id = s.person_id where p.document_number = @document_number ), (select id from annotation where id = (select max(id) from annotation)))";
            comando.Parameters.AddWithValue("@document_number", unStudentHistoryAnnotation.Student_history_id);
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

        public bool agregarAnnotation(annotation unAnnotation)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into annotation values (@notation, @notation_date)";
            comando.Parameters.AddWithValue("@notation", unAnnotation.Notation);
            comando.Parameters.AddWithValue("@notation_date", unAnnotation.Notation_date);
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

        public bool agregarNews(news unNews)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into news values(@id_user, @text, @image)";
            comando.Parameters.AddWithValue("@id_user", unNews.Id_user);
            comando.Parameters.AddWithValue("@text", unNews.Text);
            comando.Parameters.AddWithValue("@image", unNews.Image);
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
            comando.CommandText = "select c.number_course, c.number_year, c.number_cycle from course c inner join student s on s.course_id = c.id inner join person p on p.id = s.person_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                course unCourse = new course();
                unCourse.Number_course = registro.GetInt32(0);
                unCourse.Number_year = registro.GetInt32(1);
                unCourse.Number_cycle = registro.GetInt32(2);
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

        public person ConsultarTeacherSt(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select p.first_name, p.first_last_name, p.second_name, p.second_last_name from course c inner join teacher t on t.id = c.teacher_id inner join person p on p.id = t.person_id where t.id=(select t.id from teacher t inner join course c on c.teacher_id = t.id inner join student s on s.course_id = c.id inner join person ps on ps.id = s.person_id where ps.document_number = @document_number)";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                person unPersonn = new person();
                unPersonn.First_name = registro.GetString(0);
                unPersonn.First_last_name = registro.GetString(1);
                unPersonn.Second_name = registro.GetString(2);
                unPersonn.Second_last_name = registro.GetString(3);
                registro.Close();
                return unPersonn;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public person ConsultarPersonC(int number_course)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select p.first_name, p.first_last_name, p.second_name, p.second_last_name from course c inner join teacher t on t.id= c.teacher_id inner join person p on p.id = t.person_id  where number_course = @number_course";
            comando.Parameters.AddWithValue("@number_course", number_course);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                person unPerson = new person();
                unPerson.First_name = registro.GetString(0);
                unPerson.First_last_name = registro.GetString(1);
                unPerson.Second_name = registro.GetString(2);
                unPerson.Second_last_name = registro.GetString(3);
                registro.Close(); 
                return unPerson;
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
            comando.CommandText = "select t.id, t.address_tutor, t.number_tutor, t.person_id from tutor t inner join person p on p.id = t.person_id where p.document_number = @document_number";
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

        public matter ConsultarMatter(string matter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from matter where name_matter=@name_matter";
            comando.Parameters.AddWithValue("@name_matter", matter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                matter unMatter = new matter();
                unMatter.Id = registro.GetInt32(0);
                unMatter.Name_matter = registro.GetString(1);
                unMatter.Name_subject = registro.GetString(2);
                registro.Close();
                return unMatter;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public enrollmentt ConsultarEnrollment(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select e.address, e.home_number, e.state from enrollment e inner join student s on s.id = e.student_id inner join person p on p.id = s.person_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enrollmentt unEnrollmentt = new enrollmentt();
                unEnrollmentt.Address = registro.GetString(0);
                unEnrollmentt.Home_number = registro.GetInt32(1);
                unEnrollmentt.State = registro.GetInt32(2);
                registro.Close();
                return unEnrollmentt;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public eps ConsultarEps(int document_number)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select ep.name_eps from eps ep inner join enrollment e on e.id_eps = ep.id inner join student s on s.id = e.student_id inner join person p on p.id = s.person_id where p.document_number=@document_number";
            comando.Parameters.AddWithValue("@document_number", document_number);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                eps unaEps = new eps();
                unaEps.Name_eps = registro.GetString(0);
                registro.Close();
                return unaEps;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public final_quarterly_grade ConsultarFinal_quarterly_grade(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select f.id, f.number_quarter, f.seventy_percentage, f.twenty_percentage, f.ten_percentage, f.final_grade from final_quarterly_grade f inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                final_quarterly_grade unFinal_quarterly_grade = new final_quarterly_grade();
                unFinal_quarterly_grade.Id = registro.GetInt32(0);
                unFinal_quarterly_grade.Number_quarter = registro.GetInt32(1);
                unFinal_quarterly_grade.Seventy_porcentage = registro.GetInt32(2);
                unFinal_quarterly_grade.Twenty_porcentage = registro.GetInt32(3);
                unFinal_quarterly_grade.Ten_porcentage = registro.GetInt32(4);
                unFinal_quarterly_grade.Final_grade = registro.GetInt32(5);
                registro.Close();
                return unFinal_quarterly_grade;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public person ConsultarFinal_quarterly_grade_person(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select p.document_number, p.first_name, p.first_last_name, p.second_name, p.second_last_name from final_quarterly_grade f inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                person unPerson = new person();
                unPerson.Document_number = registro.GetInt32(0);
                unPerson.First_name = registro.GetString(1);
                unPerson.First_last_name = registro.GetString(2);
                unPerson.Second_name = registro.GetString(3);
                unPerson.Second_last_name = registro.GetString(4);
                registro.Close();
                return unPerson;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public matter ConsultarFinal_quarterly_grade_matter(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select m.name_matter from final_quarterly_grade f inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                matter unaMatter = new matter();
                unaMatter.Name_matter = registro.GetString(0);
                registro.Close();
                return unaMatter;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public annual_final_grade ConsultarAnnual_final_grade(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select a.id, a.annual_final_grade from annual_final_grade a inner join final_quarterly_grade f on a.final_quarterly_grade_id = f.id inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                annual_final_grade unAnnual_final_grade = new annual_final_grade();
                unAnnual_final_grade.Id = registro.GetInt32(0);
                unAnnual_final_grade.Annual_final_gradee = registro.GetInt32(1);
                registro.Close();
                return unAnnual_final_grade;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public person ConsultarAnnual_final_grade_person(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select p.document_number, p.first_name, p.first_last_name, p.second_name, p.second_last_name from annual_final_grade a inner join final_quarterly_grade f on f.id = a.final_quarterly_grade_id inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                person unPerson = new person();
                unPerson.Document_number = registro.GetInt32(0);
                unPerson.First_name = registro.GetString(1);
                unPerson.First_last_name = registro.GetString(2);
                unPerson.Second_name = registro.GetString(3);
                unPerson.Second_last_name = registro.GetString(4);
                registro.Close();
                return unPerson;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public matter ConsultarAnnual_final_grade_matter(int document_number, string name_matter, int number_quarter)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select m.name_matter from annual_final_grade a inner join final_quarterly_grade f on f.id = a.final_quarterly_grade_id inner join student s on s.id = f.student_id inner join matter m on m.id = f.matter_id inner join quarter q on q.number_quarter = f.number_quarter inner join person p on p.id = s.person_id where p.document_number=@document_number and m.name_matter=@name_matter and q.number_quarter=@number_quarter";
            comando.Parameters.AddWithValue("@document_number", document_number);
            comando.Parameters.AddWithValue("@name_matter", name_matter);
            comando.Parameters.AddWithValue("@number_quarter", number_quarter);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                matter unaMatter = new matter();
                unaMatter.Name_matter = registro.GetString(0);
                registro.Close();
                return unaMatter;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

        public timetablee ConsultarTimetable(int course)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select t.archive_timetable from timetable t inner join course c on c.id = t.course_id where c.number_course=@number_course";
            comando.Parameters.AddWithValue("@number_course", course);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                timetablee unTimetable = new timetablee();
                unTimetable.Archive_timetable = registro.GetString(0);
                registro.Close();
                return unTimetable;
            }
            else
            {
                registro.Close();
                return null;
            }

        }

    }
}
