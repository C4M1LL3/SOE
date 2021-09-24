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
        public ConsultarUsuarios()
        {
            InitializeComponent();
            panelConsult.BackColor = Color.FromArgb(245, Color.FromArgb(0, 0, 0));
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
    }
}
