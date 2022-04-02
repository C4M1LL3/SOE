using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgMother : System.Web.UI.Page
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
            mother unaMother = new mother();
            unaMother.Person_id = int.Parse(TextBox1.Text);
            unaMother.Number_mother = int.Parse(TextBox2.Text);
            unaMother.Address_mother = TextBox3.Text;
            bool agregado = objGestionDatos.agregarMother(unaMother);
            if (agregado)
            {
                Label1.Text = "madre Agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}