﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;
using System.Data;
using System.Data.SqlClient;

namespace SOE.html.executive
{
    public partial class homee : System.Web.UI.Page
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

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select top 10 n.id, p.first_name, n.text from news n inner join system_userr su on su.id = n.id_user inner join person p on p.user_id = su.id order by n.id desc", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                GridView1.DataSource = dtbl;
                GridView1.DataBind();
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
            string usuariologueado = Session["usuariologueado"].ToString();
            news unNews = new news();
            unNews.Id_user = int.Parse(usuariologueado);
            unNews.Text = TextBox3.Text;
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