using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diseño
{
    public partial class PaginaPrincipal : Form
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

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelSideMenu.Visible == true)
            {
                PanelSideMenu.Visible = false;
            }

            else PanelSideMenu.Visible = true;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios Cu = new ConsultarUsuarios();
            Cu.Show();

            this.Hide();
        }
    }
}
