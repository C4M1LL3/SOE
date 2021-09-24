using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diseño
{
    public partial class RegistrarPersona : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public RegistrarPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarUsuario Ru = new RegistrarUsuario();
            Ru.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.document_number = textDocNumb.Text;
            persona.type_document_id = textDocType.Text;
            persona.first_name = textFirstName.Text;
            persona.second_name = textSecondName.Text;
            persona.first_last_name = textFirstLastName.Text;
            persona.second_last_name = textSecondLastName.Text;

            int resultado = RegistrarPersonaDAL.AgregarP(persona);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados con exito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Index Ix = new Index();
                Ix.Show();

                this.Hide();
            
        }
            else
            {
                MessageBox.Show("No se pudo hacer el registro", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textDocNumb_Enter(object sender, EventArgs e)
        {
            if (textDocNumb.Text == "Numero de documento")
            {
                textDocNumb.Text = "";
            }
        }

        private void textDocNumb_Leave(object sender, EventArgs e)
        {
            if (textDocNumb.Text == "")
            {
                textDocNumb.Text = "Numero de documento";
            }
        }

        private void textDocType_Leave(object sender, EventArgs e)
        {
            if (textDocType.Text == "")
            {
                textDocType.Text = "Tipo de documento";
            }
        }

        private void textFirstName_Enter(object sender, EventArgs e)
        {
            if (textFirstName.Text == "Primer Nombre")
            {
                textFirstName.Text = "";
            }
        }

        private void textFirstName_Leave(object sender, EventArgs e)
        {
            if (textFirstName.Text == "")
            {
                textFirstName.Text = "Primer Nombre";
            }
        }

        private void textSecondName_Enter(object sender, EventArgs e)
        {
            if (textSecondName.Text == "Segundo Nombre")
            {
                textSecondName.Text = "";
            }
        }

        private void textSecondName_Leave(object sender, EventArgs e)
        {
            if (textSecondName.Text == "")
            {
                textSecondName.Text = "Segundo Nombre";
            }
        }

        private void textFirstLastName_Enter(object sender, EventArgs e)
        {
            if (textFirstLastName.Text == "Primer Apellido")
            {
                textFirstLastName.Text = "";
            }
        }

        private void textFirstLastName_Leave(object sender, EventArgs e)
        {
            if (textFirstLastName.Text == "")
            {
                textFirstLastName.Text = "Primer Apellido";
            }
        }

        private void textSecondLastName_Enter(object sender, EventArgs e)
        {
            if (textSecondLastName.Text == "Segundo Apellido")
            {
                textSecondLastName.Text = "";
            }
        }

        private void textSecondLastName_Leave(object sender, EventArgs e)
        {
            if (textSecondLastName.Text == "")
            {
                textSecondLastName.Text = "Segundo Apellido";
            }
        }

        private void textDocType_Enter_1(object sender, EventArgs e)
        {
            if (textDocType.Text == "Tipo de documento")
            {
                textDocType.Text = "";
            }
        }
    }
}
