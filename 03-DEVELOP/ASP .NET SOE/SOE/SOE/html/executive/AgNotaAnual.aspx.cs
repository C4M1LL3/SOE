using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgNotaAnual : System.Web.UI.Page
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
            annual_final_grade unNoteAnnual = new annual_final_grade();
            unNoteAnnual.Final_quarterly_grade_id = int.Parse(TextBox1.Text);
            unNoteAnnual.Annual_final_gradee = int.Parse(TextBox2.Text);
            bool agregado = objGestionDatos.agregarNotaAnual(unNoteAnnual);
            if (agregado)
            {
                Label1.Text = "Nota anual agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}