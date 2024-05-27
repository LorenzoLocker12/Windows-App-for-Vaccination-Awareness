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
    public partial class frmInfoCrmNaoGestante3 : Form
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
        public frmInfoCrmNaoGestante3()
        {
            InitializeComponent();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmicng4 = new frmInfoCrmNaoGestante4();
            frmicng4.Show();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmicng2 = new frmInfoCrmNaoGestante2();
            frmicng2.Show();
        }

        private void frmInfoCrmNaoGestante3_Load(object sender, EventArgs e)
        {
            btnBack2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack2.Width, btnBack2.Height, 30, 30));
            btnNext2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext2.Width, btnNext2.Height, 30, 30));
        }
        private void btnBack2_MouseHover(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.MidnightBlue;
        }

        private void btnBack2_MouseLeave(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.RoyalBlue;
        }

        private void btnNext2_MouseHover(object sender, EventArgs e)
        {
            btnNext2.BackColor = Color.MidnightBlue;
        }

        private void btnNext2_MouseLeave(object sender, EventArgs e)
        {
            btnNext2.BackColor = Color.RoyalBlue;
        }
    }
}
