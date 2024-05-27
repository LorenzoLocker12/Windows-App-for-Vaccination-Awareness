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


    public partial class frmInfoVacinalGeral4 : Form
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
        public frmInfoVacinalGeral4()
        {
            InitializeComponent();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInfoVacinalGeral3 VoltarfrmInfoVacinal3 = new frmInfoVacinalGeral3();
            VoltarfrmInfoVacinal3.Show();
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            this.Close();
            var fivg5 = new frmInfoVacinalGeral5();
            fivg5.Show();
        }

        private void frmInfoVacinalGeral4_Load(object sender, EventArgs e)
        {
            btnBack4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack4.Width, btnBack4.Height, 30, 30));
            btnNext4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext4.Width, btnNext4.Height, 30, 30));
        }
        private void btnBack4_MouseHover(object sender, EventArgs e)
        {
            btnBack4.BackColor = Color.MidnightBlue;
        }

        private void btnBack4_MouseLeave(object sender, EventArgs e)
        {
            btnBack4.BackColor = Color.RoyalBlue;
        }

        private void btnNext4_MouseHover(object sender, EventArgs e)
        {
            btnNext4.BackColor = Color.MidnightBlue;
        }

        private void btnNext4_MouseLeave(object sender, EventArgs e)
        {
            btnNext4.BackColor = Color.RoyalBlue;
        }
    }
}
