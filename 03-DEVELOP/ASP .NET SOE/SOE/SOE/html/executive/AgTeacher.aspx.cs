using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgTeacher : System.Web.UI.Page
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
            teacher unTeacher = new teacher();
            unTeacher.Person_id = int.Parse(TextBox1.Text);
            unTeacher.Name_working_day = DropDownList1.Text;
            unTeacher.Matter_id = int.Parse(TextBox3.Text);
            bool agregado = objGestionDatos.agregarTeacher(unTeacher);
            if (agregado)
            {
                Label1.Text = "Profesor Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}