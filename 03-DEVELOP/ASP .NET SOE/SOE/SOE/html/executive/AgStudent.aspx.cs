using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgStudent : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            student unStudent = new student();
            unStudent.Person_id = int.Parse(TextBox1.Text);
            unStudent.Birth_date = Convert.ToDateTime(TextBox2.Text);
            unStudent.Birth_place = TextBox3.Text;
            unStudent.Course_id = int.Parse(TextBox4.Text);
            bool agregado = objGestionDatos.agregarStudent(unStudent);
            if (agregado)
            {
                Label1.Text = "Estudiante Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}