using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgMatter : System.Web.UI.Page
    {

        GestionarDatos objGestionDatos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            matter unaMatter = new matter();
            unaMatter.Name_matter = TextBox1.Text;
            unaMatter.Name_subject = TextBox2.Text;
            bool agregado = objGestionDatos.agregarMatter(unaMatter);
            if (agregado)
            {
                Label1.Text = "Materia Agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}