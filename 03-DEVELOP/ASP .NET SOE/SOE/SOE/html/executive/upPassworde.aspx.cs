using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class upPassworde : System.Web.UI.Page
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
            string usuariologueado = Session["usuariologueado"].ToString();
            user unUser = new user();
            unUser.Login = usuariologueado;
            unUser.Password = TextBox1.Text;
            bool agregado = objGestionDatos.updatePass(unUser);
            if (agregado)
            {
                Label1.Text = "Contraseña cambiada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}