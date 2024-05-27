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


    public partial class frmInfoVacinalGeral3 : Form
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
        public frmInfoVacinalGeral3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInfoVacinalGeral2 VoltarfrmInfoVacinal2 = new FrmInfoVacinalGeral2();
            VoltarfrmInfoVacinal2.Show();
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            this.Close();
            var fivg4 = new frmInfoVacinalGeral4();
            fivg4.Show();
        }

        private void frmInfoVacinalGeral3_Load(object sender, EventArgs e)
        {
            btnBack3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack3.Width, btnBack3.Height, 30, 30));
            btnNext3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext3.Width, btnNext3.Height, 30, 30));
        }
        private void btnBack3_MouseHover(object sender, EventArgs e)
        {
            btnBack3.BackColor = Color.MidnightBlue;
        }

        private void btnBack3_MouseLeave(object sender, EventArgs e)
        {
            btnBack3.BackColor = Color.RoyalBlue;
        }

        private void btnNext3_MouseHover(object sender, EventArgs e)
        {
            btnNext3.BackColor = Color.MidnightBlue;
        }

        private void btnNext3_MouseLeave(object sender, EventArgs e)
        {
            btnNext3.BackColor = Color.RoyalBlue;
        }
    }
}
