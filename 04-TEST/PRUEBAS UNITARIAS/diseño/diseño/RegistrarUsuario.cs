using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diseño
{
    public partial class RegistrarUsuario : Form
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

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Index Ix = new Index();
            Ix.Show();

            this.Hide();
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

        private void textCorrInst_Enter(object sender, EventArgs e)
        {
            if (textCorrInst.Text == "Correo institucional")
            {
                textCorrInst.Text = "";
            }
        }

        private void textCorrInst_Leave(object sender, EventArgs e)
        {
            if (textCorrInst.Text == "")
            {
                textCorrInst.Text = "Numero de documento";
            }
        }

        private void textPassw_Enter(object sender, EventArgs e)
        {
            if (textPassw.Text == "Contraseña")
            {
                textPassw.Text = "";
                textPassw.UseSystemPasswordChar = true;
            }
        }

        private void textPassw_Leave(object sender, EventArgs e)
        {
            if (textPassw.Text == "")
            {
                textPassw.Text = "Contraseña";
                textPassw.UseSystemPasswordChar = false;
            }
        }

        private void textConfPassw_Enter(object sender, EventArgs e)
        {
            if (textConfPassw.Text == "Confirmar Contraseña")
            {
                textConfPassw.Text = "";
                textConfPassw.UseSystemPasswordChar = true;
            }
        }

        private void textConfPassw_Leave(object sender, EventArgs e)
        {
            if (textConfPassw.Text == "")
            {
                textConfPassw.Text = "Confirmar Contraseña";
                textConfPassw.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textPassw.Text == textConfPassw.Text)
            {
                if (RegistrarUsuarioDAL.RegistrarUsuario(textDocNumb.Text, textPassw.Text, textCorrInst.Text) > 0)
                {
                    MessageBox.Show("Usuario creado con exito");

                    RegistrarPersona Rp = new RegistrarPersona();
                    Rp.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error en el registro de usuario");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textDocNumb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
