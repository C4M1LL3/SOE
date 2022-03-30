using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgStudentHistory : System.Web.UI.Page
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
            student_historyy unStudentHistory = new student_historyy();
            unStudentHistory.Student_id = int.Parse(TextBox1.Text);
            bool agregado = objGestionDatos.agregarStudentHistory(unStudentHistory);
            if (agregado)
            {
                Label1.Text = "Observador Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}