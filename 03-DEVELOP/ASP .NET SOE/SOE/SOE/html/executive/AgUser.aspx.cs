using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows;
using datos;

namespace SOE.html.executive
{
    public partial class AgUser : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();
        public SqlConnection conexion;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.conexion = datos.conexion.getconexion();
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
            }

            else
            {
                Response.Redirect("../../index.aspx");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            user unUser = new user();
            unUser.Login = TextBox1.Text;
            unUser.Password = TextBox2.Text;
            unUser.Institutional_email = TextBox3.Text;
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/ImagesU/" + FileUpload1.FileName));
                string imgpath = "~/ImagesU/" + str.ToString();
                Label1.Text = "archivo subido con exito";
                unUser.Image = imgpath;
            }
            else
            {
                Label1.Text = "archivo no subido, seleccione un archivo porfavor";
            }
            bool agregado = objGestionDatos.agregarUser(unUser);
            if (agregado)
            {
                Label1.Text = "Usuario Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            user_rol unRolUser = new user_rol();
            unRolUser.Name_rol = DropDownList1.Text;
            bool agregado = objGestionDatos.agregarRolUser(unRolUser);
            if (agregado)
            {
                Label1.Text = "Rol Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            person unaPerson = new person();
            unaPerson.Document_number = int.Parse(TextBox5.Text);
            unaPerson.Type_document_id = int.Parse(DropDownList2.Text);
            unaPerson.First_name = TextBox6.Text;
            unaPerson.Second_name = TextBox7.Text;
            unaPerson.First_last_name = TextBox8.Text;
            unaPerson.Second_last_name = TextBox9.Text;
            bool agregado = objGestionDatos.agregarPerson(unaPerson);
            if (agregado)
            {
                Label1.Text = "Persona Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

    }
}