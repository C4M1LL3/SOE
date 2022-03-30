using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;


namespace SOE.html.executive
{
    public partial class CoCourse : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

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
            int number_course = int.Parse(TextBox9.Text);
            person unPerson = objGestionDatos.ConsultarPersonC(number_course);
            course unCourse = objGestionDatos.ConsultarCourse(number_course);

            if (unPerson != null && unCourse != null)
            {
                Label6.Text = unCourse.Number_course.ToString();
                Label9.Text = unCourse.Number_year.ToString();
                Label8.Text = unCourse.Id.ToString();
                Label7.Text = unCourse.Number_cycle.ToString();
                Label10.Text = unPerson.First_name;
                Label12.Text = unPerson.First_last_name;
                Label11.Text = unPerson.Second_name;
                Label13.Text = unPerson.Second_last_name;
            }
            else
            {
                Label14.Text = "No existe este curso";
            }
        }
    }
}