using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;
using System.Data;
using System.Data.SqlClient;

namespace SOE.html.teachers
{
    public partial class CoStudentHistory : System.Web.UI.Page
    {
        GestionarDatos objGestionDatos = new GestionarDatos();
        string connectionString = @"Data Source=LAPTOP-H4OQ11HQ; Initial catalog = SOE; Integrated Security = True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                int document_number = int.Parse(usuariologueado);
                person unaPersona = objGestionDatos.consultarPerson(document_number);
                if (unaPersona != null)
                {
                    Label1.Text = unaPersona.First_name;
                    Label2.Text = unaPersona.Second_name;
                    Label3.Text = unaPersona.First_last_name;
                    Label4.Text = unaPersona.Second_last_name;
                }

                user unUser = objGestionDatos.ConsultarUser(document_number);
                if (unUser != null)
                {
                    Label5.Text = unUser.Institutional_email;
                    Image1.ImageUrl = unUser.Image;
                    Image2.ImageUrl = unUser.Image;
                }

                else
                {
                }
            }

            else
            {
                Response.Redirect("../../index.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("usuariologueado");
            Response.Redirect("../../index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GsUsuarioe.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int document_number = int.Parse(TextBox9.Text);
            person unPerson = objGestionDatos.consultarPerson(document_number);
            user unUser = objGestionDatos.ConsultarUser(document_number);
            type_document unTypeDocument = objGestionDatos.ConsultarTypeDocument(document_number);
            student unStudent = objGestionDatos.ConsultarStudent(document_number);
            course unCourse = objGestionDatos.ConsultarCourseS(document_number);
            person unPersonn = objGestionDatos.ConsultarTeacherSt(document_number);
            if (unPerson != null && unUser != null && unTypeDocument != null && unStudent != null && unCourse != null && unPersonn != null)
            {
                Image4.ImageUrl = unUser.Image;
                Label6.Text = unPerson.First_name;
                Label7.Text = unPerson.Second_name;
                Label8.Text = unPerson.First_last_name;
                Label9.Text = unPerson.Second_last_name;
                Label10.Text = unTypeDocument.Abbrevation;
                Label11.Text = unPerson.Document_number.ToString();
                Label12.Text = unStudent.Birth_date.ToString();
                Label13.Text = unStudent.Birth_place;
                Label15.Text = unCourse.Number_course.ToString();
                Label16.Text = unCourse.Number_year.ToString();
                Label17.Text = unCourse.Number_cycle.ToString();
                Label19.Text = unPersonn.First_name;
                Label20.Text = unPersonn.First_last_name;
                Label21.Text = unPersonn.Second_name;
                Label22.Text = unPersonn.Second_last_name;

            }
            else
            {
                Label14.Text = "No existe este estudiante";
            }

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select a.id, a.notation_date, a.notation from annotation a inner join student_history_annotation sta on sta.annotation_id = a.id inner join student_history st on st.id =sta.student_history_id inner join student s on s.id = st.student_id inner join person p on p.id = s.person_id where p.document_number = @document_number", sqlcon);
                sqlda.SelectCommand.Parameters.AddWithValue("@document_number", TextBox9.Text);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                GridView1.DataSource = dtbl;
                GridView1.DataBind();
            }

        }
    }
}