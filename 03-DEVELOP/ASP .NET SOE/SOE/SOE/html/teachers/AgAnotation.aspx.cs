using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows;
using datos;

namespace SOE.html.teachers
{
    public partial class AgAnotation : System.Web.UI.Page
    {
        GestionarDatos objGestionDatos = new GestionarDatos();
        public SqlConnection conexion;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.conexion = datos.conexion.getconexion();
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
            annotation unAnnotation = new annotation();
            unAnnotation.Notation = TextBox1.Text;
            unAnnotation.Notation_date = Convert.ToDateTime(TextBox2.Text);
            bool agregado = objGestionDatos.agregarAnnotation(unAnnotation);
            if (agregado)
            {
                Label1.Text = "Anotación agregada con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            student_history_annotation unStudentHistoryAnnotation = new student_history_annotation();
            unStudentHistoryAnnotation.Student_history_id = int.Parse(TextBox3.Text);
            bool agregado = objGestionDatos.agregarStudentHistoryAnnotation(unStudentHistoryAnnotation);
            if (agregado)
            {
                Label1.Text = "Anotación Agregado con exito";
            }
            else
            {
                Label1.Text = objGestionDatos.error;
            }
        }
    }
}