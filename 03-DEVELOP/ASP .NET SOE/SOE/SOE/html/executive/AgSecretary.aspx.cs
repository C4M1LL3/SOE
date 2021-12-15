using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;


namespace SOE.html.executive
{
    public partial class AgSecretary : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            secretary unSecretary = new secretary();
            unSecretary.Person_id = int.Parse(TextBox1.Text);
            unSecretary.Name_working_day = DropDownList1.Text;
            bool agregado = objGestionDatos.agregarSecretary(unSecretary);
            if (agregado)
            {
                Label1.Text = "Secretario Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}