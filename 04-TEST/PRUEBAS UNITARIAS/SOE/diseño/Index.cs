using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diseño
{
    public partial class Index : Form
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

public Index()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(245, Color.FromArgb(0,0,0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(245, Color.FromArgb(0, 0, 0));

            RegistrarUsuario Ru = new RegistrarUsuario();
            Ru.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            button2.BackColor = Color.FromArgb(245, Color.FromArgb(0, 0, 0));

            InicioSesion Is = new InicioSesion();
            Is.Show();

            this.Hide();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
