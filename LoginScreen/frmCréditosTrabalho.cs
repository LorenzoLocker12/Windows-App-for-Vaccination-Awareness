using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class frmCréditosTrabalho : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,
int nTopRect,
int nRightRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse
);

        public frmCréditosTrabalho()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (GlobalVariablesClass.vOne.Equals("SIM"))
            {
                this.Close();
                var frmicg1 = new frmPrincipalGestante();
                frmicg1.Show();
            }
            else
            {
                this.Close();
                var frmicng1 = new frmPrincipalNaoGestante();
                frmicng1.Show();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sbim.org.br/calendarios-de-vacinacao");
        }

        private void btnBack2_MouseHover(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.MidnightBlue;
        }

        private void btnBack2_MouseLeave(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.RoyalBlue;
        }

        private void frmCréditosTrabalho_Load(object sender, EventArgs e)
        {
            btnBack2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack2.Width, btnBack2.Height, 30, 30));
        }
    }
}
