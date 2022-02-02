using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class CoPerson : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string document_number = TextBox9.Text;
            person unaPersona = objGestionDatos.consultarPerson(document_number);
            if (unaPersona != null)
            {
                TextBox1.Text = unaPersona.Id.ToString();
                TextBox2.Text = unaPersona.Document_number.ToString();
                TextBox3.Text = unaPersona.Type_document_id.ToString();
                TextBox4.Text = unaPersona.First_name;
                TextBox5.Text = unaPersona.Second_name;
                TextBox6.Text = unaPersona.First_last_name;
                TextBox7.Text = unaPersona.Second_last_name;
                TextBox8.Text = unaPersona.User_id.ToString();
            }
            else
            {
                TextBox10.Text = "No existe persona con ese numero de identificacion";
            }
        }
    }
}