using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class InicioSesion : Form
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
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            if ( textDocNumb.Text == "")
            {
                textDocNumb.Text = "Numero de documento";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Index Ix = new Index();
            Ix.Show();

            this.Hide();
        }

        private void textDocNumb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (RegistrarUsuarioDAL.AutenticarUsu(textDocNumb.Text, textPassw.Text) > 0)
            {
                this.Hide();

                PaginaPrincipal PP = new PaginaPrincipal();
                PP.ShowDialog();

                this.Hide();
            }
            else

                MessageBox.Show("Verifique sus datos");
        }
    }
}
