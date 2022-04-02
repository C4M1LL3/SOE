using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.teachers
{
    public partial class AgNotaTrim : System.Web.UI.Page
    {
        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
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
            final_quarterly_grade unNoteTrim = new final_quarterly_grade();
            unNoteTrim.Student_id = int.Parse(TextBox1.Text);
            unNoteTrim.Matter_id = int.Parse(TextBox2.Text);
            unNoteTrim.Number_quarter = int.Parse(DropDownList1.Text);
            unNoteTrim.Seventy_porcentage = int.Parse(TextBox3.Text);
            unNoteTrim.Twenty_porcentage = int.Parse(TextBox4.Text);
            unNoteTrim.Ten_porcentage = int.Parse(TextBox5.Text);
            unNoteTrim.Final_grade = int.Parse(TextBox6.Text);

            bool agregado = objGestionDatos.agregarNotaTrim(unNoteTrim);
            if (agregado)
            {
                Label1.Text = "Nota trimestral Agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}