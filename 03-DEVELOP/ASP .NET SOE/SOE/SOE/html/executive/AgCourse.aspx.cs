using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgCourse : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            course unCourse = new course();
            unCourse.Number_course = int.Parse(TextBox1.Text);
            unCourse.Number_year = int.Parse(DropDownList1.Text);
            unCourse.Number_cycle = int.Parse(DropDownList2.Text);
            unCourse.Teacher_id = int.Parse(TextBox2.Text);
            bool agregado = objGestionDatos.agregarCourse(unCourse);
            if (agregado)
            {
                Label1.Text = "Curso Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}