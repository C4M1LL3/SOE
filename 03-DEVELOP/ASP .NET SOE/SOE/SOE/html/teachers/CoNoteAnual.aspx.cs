using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.teachers
{
    public partial class CoNoteAnual : System.Web.UI.Page
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
            int number_quarter = 1;
            int document_number = int.Parse(TextBox9.Text);
            string name_matter = TextBox1.Text;
            person unaPersona = objGestionDatos.ConsultarAnnual_final_grade_person(document_number, name_matter, number_quarter);
            matter unaMatter = objGestionDatos.ConsultarAnnual_final_grade_matter(document_number, name_matter, number_quarter);
            annual_final_grade unAnnual_final_grade = objGestionDatos.ConsultarAnnual_final_grade(document_number, name_matter, number_quarter);

            if (unaPersona != null && unaMatter != null && unAnnual_final_grade != null)
            {
                Label12.Text = unAnnual_final_grade.Id.ToString();
                Label13.Text = unaPersona.Document_number.ToString();
                Label6.Text = unaPersona.First_name;
                Label7.Text = unaPersona.Second_name;
                Label8.Text = unaPersona.First_last_name;
                Label9.Text = unaPersona.Second_last_name;
                Label18.Text = unaMatter.Name_matter;
                Label17.Text = unAnnual_final_grade.Annual_final_gradee.ToString();
            }
            else
            {
                Label14.Text = "No existe persona con ese numero de identificacion";
            }
        }
    }
}