using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StageProjet
{
    public partial class Inscription : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(

           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );

        public Inscription()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnPageConnexion_Click(object sender, EventArgs e)
        {
            Connexion h = new Connexion();
            h.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtRePassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRePassword.UseSystemPasswordChar = true;
            }
                
        }
    }
}
