using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diseño
{
    public partial class ConsultarUsuarios : Form
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
        public ConsultarUsuarios()
        {
            InitializeComponent();
            TextND.BackColor = Color.FromArgb(245, Color.FromArgb(0, 0, 0));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PaginaPrincipal Pp = new PaginaPrincipal();
            Pp.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelSideMenu.Visible == true)
            {
                PanelSideMenu.Visible = false;
            }

            else PanelSideMenu.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios Cu = new ConsultarUsuarios();
            Cu.Show();

            this.Hide();
        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btrBuscar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = RegistrarPersonaDAL.BuscarPersona(textDocNumb.Text);

        }

        private void txbNoDocumento_TextChanged(object sender, EventArgs e)
        {

        }





        private void textDocNumb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDocNumb_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void textDocNumb_Enter(object sender, EventArgs e)
        {
            if (textDocNumb.Text == "Numero de Documento")
            {
                textDocNumb.Text = "";
            }
        }

        private void textDocNumb_Leave(object sender, EventArgs e)
        {
            if (textDocNumb.Text == "")
            {
                textDocNumb.Text = "Numero de Documento";

            }
        }
    }
}
