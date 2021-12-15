using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgUser : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            user unUser = new user();
            unUser.Login = TextBox1.Text;
            unUser.Password = TextBox2.Text;
            unUser.Institutional_email = TextBox3.Text;
            unUser.Image = TextBox4.Text;
            bool agregado = objGestionDatos.agregarUser(unUser);
            if (agregado)
            {
                Label1.Text = "Usuario Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            user_rol unRolUser = new user_rol();
            unRolUser.Name_rol = DropDownList1.Text;
            bool agregado = objGestionDatos.agregarRolUser(unRolUser);
            if (agregado)
            {
                Label1.Text = "Rol Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            person unaPerson = new person();
            unaPerson.Document_number = int.Parse(TextBox5.Text);
            unaPerson.Type_document_id = int.Parse(DropDownList2.Text);
            unaPerson.First_name = TextBox6.Text;
            unaPerson.Second_name = TextBox7.Text;
            unaPerson.First_last_name = TextBox8.Text;
            unaPerson.Second_last_name = TextBox9.Text;
            bool agregado = objGestionDatos.agregarPerson(unaPerson);
            if (agregado)
            {
                Label1.Text = "Persona Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}