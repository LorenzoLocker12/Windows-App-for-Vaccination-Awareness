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
    public partial class frmInfoVacinalGeral5 : Form
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
        public frmInfoVacinalGeral5()
        {
            InitializeComponent();
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInfoVacinalGeral4 VoltarfrmInfoVacinal4 = new frmInfoVacinalGeral4();
            VoltarfrmInfoVacinal4.Show();
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            if (GlobalVariablesClass.vOne.Equals("SIM"))
            {
                this.Close();
                var frmicg1 = new frmInfoCrmGestante1();
                frmicg1.Show();
            }
            else
            {
                this.Close();
                var frmicng1 = new frmInfoCrmNaoGestante1();
                frmicng1.Show();
            }
        }

        private void frmInfoVacinalGeral5_Load(object sender, EventArgs e)
        {
            btnBack5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack5.Width, btnBack5.Height, 30, 30));
            btnNext5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext5.Width, btnNext5.Height, 30, 30));
        }
        private void btnBack5_MouseHover(object sender, EventArgs e)
        {
            btnBack5.BackColor = Color.MidnightBlue;
        }

        private void btnBack5_MouseLeave(object sender, EventArgs e)
        {
            btnBack5.BackColor = Color.RoyalBlue;
        }

        private void btnNext5_MouseHover(object sender, EventArgs e)
        {
            btnNext5.BackColor = Color.MidnightBlue;
        }

        private void btnNext5_MouseLeave(object sender, EventArgs e)
        {
            btnNext5.BackColor = Color.RoyalBlue;
        }
    }
}
