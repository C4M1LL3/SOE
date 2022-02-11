using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{

    public partial class CoStudent : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                int document_number = int.Parse(usuariologueado);
                person unaPersona = objGestionDatos.consultarPerson(document_number);
                user unUser = objGestionDatos.ConsultarUser(document_number);
                if (unaPersona != null && unUser != null)
                {
                    Label1.Text = unaPersona.First_name;
                    Label2.Text = unaPersona.Second_name;
                    Label3.Text = unaPersona.First_last_name;
                    Label4.Text = unaPersona.Second_last_name;
                    Label5.Text = unUser.Institutional_email;
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
            int document_number = int.Parse(TextBox9.Text);
            person unaPersona = objGestionDatos.consultarPerson(document_number);
            type_document unTypeDocument = objGestionDatos.ConsultarTypeDocument(document_number);
            student unStudent = objGestionDatos.ConsultarStudent(document_number);
            course unCourse = objGestionDatos.ConsultarCourseS(document_number);
            if (unaPersona != null && unCourse != null)
            {
                Label12.Text = unStudent.Id.ToString();
                Label10.Text = unaPersona.Document_number.ToString();
                Label6.Text = unaPersona.First_name;
                Label7.Text = unaPersona.Second_name;
                Label8.Text = unaPersona.First_last_name;
                Label9.Text = unaPersona.Second_last_name;
                Label13.Text = unTypeDocument.Abbrevation;
                Label11.Text = unStudent.Birth_date.ToString();
                Label15.Text = unStudent.Birth_place;
                Label16.Text = unCourse.Number_course.ToString();
            }
            else
            {
                Label14.Text = "No existe persona con ese numero de identificacion";
            }
        }

    }
}