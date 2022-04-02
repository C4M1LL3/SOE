using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgCoordinator : System.Web.UI.Page
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
            coordinator unCoordinator = new coordinator();
            unCoordinator.Person_id = int.Parse(TextBox1.Text);
            unCoordinator.Number_cycle = int.Parse(TextBox2.Text);
            bool agregado = objGestionDatos.agregarCoordinator(unCoordinator);
            if (agregado)
            {
                Label1.Text = "Coordinador Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}