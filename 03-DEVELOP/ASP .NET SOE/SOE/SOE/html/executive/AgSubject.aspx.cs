using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgSubject : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            subject unSubject = new subject();
            unSubject.Name_subject = TextBox1.Text;
            bool agregado = objGestionDatos.agregarSubject(unSubject);
            if (agregado)
            {
                Label1.Text = "Área Agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}