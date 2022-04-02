using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgTutor : System.Web.UI.Page
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
            tutor unTutor = new tutor();
            unTutor.Person_id = int.Parse(TextBox1.Text);
            unTutor.Number_tutor = int.Parse(TextBox2.Text);
            unTutor.Address_tutor = TextBox3.Text;
            bool agregado = objGestionDatos.agregarTutor(unTutor);
            if (agregado)
            {
                Label1.Text = "tutor agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}