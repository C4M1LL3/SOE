using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class homee : System.Web.UI.Page
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
            news unNews = new news();
            unNews.Id_user = int.Parse(TextBox2.Text);
            unNews.Text = TextBox3.Text;
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/newsU/" + FileUpload1.FileName));
                string imgpath = "~/newsU/" + str.ToString();
                Label9.Text = "archivo subido con exito";
                unNews.Image = imgpath;
            }
            else
            {
                Label9.Text = "archivo no subido, seleccione un archivo porfavor";
            }
            bool agregado = objGestionDatos.agregarNews(unNews);
            if (agregado)
            {
                Label9.Text = "Publicación Agregado con exito";
            }
            else
            {
                Label9.Text = objGestionDatos.error;
            }
        }
    }
}