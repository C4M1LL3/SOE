using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class CoEnrollmentt : System.Web.UI.Page
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
            int document_number = int.Parse(TextBox9.Text);
            person unPerson = objGestionDatos.consultarPerson(document_number);
            user unUser = objGestionDatos.ConsultarUser(document_number);
            type_document unTypeDocument = objGestionDatos.ConsultarTypeDocument(document_number);
            student unStudent = objGestionDatos.ConsultarStudent(document_number);
            course unCourse = objGestionDatos.ConsultarCourseS(document_number);
            eps unaEps = objGestionDatos.ConsultarEps(document_number);
            enrollmentt unEnrolmentt = objGestionDatos.ConsultarEnrollment(document_number);
            person unPersonf = objGestionDatos.ConsultarFatherSt(document_number);
            person unPersonm = objGestionDatos.ConsultarMotherSt(document_number);
            person unPersont = objGestionDatos.ConsultarTutorSt(document_number);
            type_document unTypedocumentF = objGestionDatos.ConsultarFatherTdSt(document_number);
            type_document unTypedocumentM = objGestionDatos.ConsultarMotherTdSt(document_number);
            type_document unTypedocumentT = objGestionDatos.ConsultarTutorTdSt(document_number);
            father unFatherF = objGestionDatos.ConsultarFatherFSt(document_number);
            mother unaMotherM = objGestionDatos.ConsultarMotherMSt(document_number);
            tutor unTutorT = objGestionDatos.ConsultarTutorTSt(document_number);
            if (unPerson != null && unUser != null && unTypeDocument != null && unStudent != null && unCourse != null && unaEps != null && unEnrolmentt != null)
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
                Label19.Text = unaEps.Name_eps;
                Label20.Text = unEnrolmentt.Address;
                Label21.Text = unEnrolmentt.Home_number.ToString();
                if (unEnrolmentt.State != 0 )
                {
                    Label22.Text = "Activo";
                    Label22.CssClass = "enrollment__camp--green";
                }
                else
                {
                    Label22.Text = "Inactivo";
                    Label22.CssClass = "enrollment__camp--red";
                }
                Label24.Text = unPersonf.First_name;
                Label25.Text = unPersonf.Second_name;
                Label26.Text = unPersonf.First_last_name;
                Label27.Text = unPersonf.Second_last_name;
                Label28.Text = unTypedocumentF.Abbrevation;
                Label29.Text = unPersonf.Document_number.ToString();
                Label30.Text = unFatherF.Number_father.ToString();
                Label31.Text = unFatherF.Address_father;

                Label33.Text = unPersonm.First_name;
                Label34.Text = unPersonm.Second_name;
                Label35.Text = unPersonm.First_last_name;
                Label36.Text = unPersonm.Second_last_name;
                Label37.Text = unTypedocumentM.Abbrevation;
                Label38.Text = unPersonm.Document_number.ToString();
                Label39.Text = unaMotherM.Number_mother.ToString();
                Label40.Text = unaMotherM.Address_mother;

                Label42.Text = unPersont.First_name;
                Label43.Text = unPersont.Second_name;
                Label44.Text = unPersont.First_last_name;
                Label45.Text = unPersont.Second_last_name;
                Label46.Text = unTypedocumentT.Abbrevation;
                Label47.Text = unPersont.Document_number.ToString();
                Label48.Text = unTutorT.Number_tutor.ToString();
                Label49.Text = unTutorT.Address_tutor;
            }
            else
            {
                Label14.Text = "No existe este estudiante";
            }
        }
    }
}