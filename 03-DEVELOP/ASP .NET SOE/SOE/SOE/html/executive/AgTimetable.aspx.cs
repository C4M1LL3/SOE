using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using datos;

namespace SOE.html.executive
{
    public partial class AgTimetable : System.Web.UI.Page
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
            timetablee unTimetable = new timetablee();
            string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/timetableU/" + FileUpload1.FileName));
                string imgpath = "~/timetableU/" + str.ToString();
                Label1.Text = "archivo subido con exito";
                unTimetable.Archive_timetable = imgpath;
            }
            else
            {
                Label1.Text = "archivo no subido, seleccione un archivo porfavor";
            }
            unTimetable.Course_id = int.Parse(TextBox1.Text);

            bool agregado = objGestionDatos.agregarTimetable(unTimetable);
            if (agregado)
            {
                Label1.Text = "Horario Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}