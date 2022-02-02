using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgFather : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            father unFather = new father();
            unFather.Person_id = int.Parse(TextBox1.Text);
            unFather.Number_father = int.Parse(TextBox2.Text);
            unFather.Address_father = TextBox3.Text;
            bool agregado = objGestionDatos.agregarFather(unFather);
            if (agregado)
            {
                Label1.Text = "Padre Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}