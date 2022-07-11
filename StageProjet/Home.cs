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
    public partial class Home : Form
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

        public Home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }


        //Methodes
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                //Button
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnUtilisateurs.Height;
            panelNav.Top = btnUtilisateurs.Top;
            panelNav.Left = btnUtilisateurs.Left;
            btnUtilisateurs.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUtilisateurs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnStat.Height;
            panelNav.Top = btnStat.Top;
            btnStat.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStat.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalend_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnCalend.Height;
            panelNav.Top = btnCalend.Top;
            btnCalend.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCalend.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnContact.Height;
            panelNav.Top = btnContact.Top;
            btnContact.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnUtilisateurs_Leave(object sender, EventArgs e)
        {
            btnUtilisateurs.BackColor = Color.FromArgb(24, 30, 54);
            btnUtilisateurs.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnStat_Leave(object sender, EventArgs e)
        {
            btnStat.BackColor = Color.FromArgb(24, 30, 54);
            btnStat.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnCalend_Leave(object sender, EventArgs e)
        {
            btnCalend.BackColor = Color.FromArgb(24, 30, 54);
            btnCalend.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(24, 30, 54);
            btnContact.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}
