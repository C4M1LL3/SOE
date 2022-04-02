using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgEnrollmentt : System.Web.UI.Page
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
            enrollmentt unEnrollmentt = new enrollmentt();
            unEnrollmentt.Student_id = int.Parse(TextBox1.Text);
            unEnrollmentt.Eps_id = int.Parse(TextBox2.Text);
            unEnrollmentt.Address = TextBox3.Text;
            unEnrollmentt.Home_number = int.Parse(TextBox4.Text);
            unEnrollmentt.State = int.Parse(DropDownList1.Text);
            unEnrollmentt.Father_id = int.Parse(TextBox5.Text);
            unEnrollmentt.Mother_id = int.Parse(TextBox6.Text);
            unEnrollmentt.Tutor_id = int.Parse(TextBox7.Text);
            bool agregado = objGestionDatos.agregarEnrollmentt(unEnrollmentt);
            if (agregado)
            {
                Label5.Text = "Matricula Agregada con exito";
            }
            else
            {
                Label5.Text = objGestionDatos.error;
            }
        }

    }
}