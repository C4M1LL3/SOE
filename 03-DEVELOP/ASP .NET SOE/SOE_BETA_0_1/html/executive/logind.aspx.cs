﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SOE_BETA_0_1.html.executive
{
    public partial class logind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string patron = "patron";
        string directive = "directivo";

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conn = new SqlConnection(conectar);
            SqlCommand comand = new SqlCommand("Validarz2", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            comand.Connection.Open();
            comand.Parameters.Add("@login", SqlDbType.VarChar, 100).Value = TextBox1.Text;
            comand.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = TextBox2.Text;
            comand.Parameters.Add("@patron", SqlDbType.VarChar, 50).Value = patron;
            comand.Parameters.Add("@name_rol", SqlDbType.VarChar, 100).Value = directive;
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                Session["usuariologueado"] = TextBox1.Text;
                Response.Redirect("indexd.aspx");
            }
            else
            {
                Label1.Text = "Datos registrados incorrectos";
            }
            comand.Connection.Close();
        }
    }
}