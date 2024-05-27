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
    public partial class frmInfoVacinalGeral1 : Form
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
        public frmInfoVacinalGeral1()
        {
            InitializeComponent();
        }
        

        private void btnBack1_Click(object sender, EventArgs e)
        {
            if (GlobalVariablesClass.vOne.Equals("SIM"))
            {
                this.Close();
                frmPrincipalGestante VoltarGestantePainelDeGestante = new frmPrincipalGestante();
                VoltarGestantePainelDeGestante.Show();
            }
            else
            {
                this.Close();
                frmPrincipalNaoGestante VoltarGestantePainelDeNaoGestante = new frmPrincipalNaoGestante();
                VoltarGestantePainelDeNaoGestante.Show();
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            this.Close();
            var fivg2 = new FrmInfoVacinalGeral2();
            fivg2.Show();
        }

        private void frmInfoVacinalGeral1_Load(object sender, EventArgs e)
        {
            btnBack1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack1.Width, btnBack1.Height, 30, 30));
            btnNext1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext1.Width, btnNext1.Height, 30, 30));
        }
        private void btnBack1_MouseHover(object sender, EventArgs e)
        {
            btnBack1.BackColor = Color.MidnightBlue;
        }

        private void btnBack1_MouseLeave(object sender, EventArgs e)
        {
            btnBack1.BackColor = Color.RoyalBlue;
        }

        private void btnNext1_MouseHover(object sender, EventArgs e)
        {
            btnNext1.BackColor = Color.MidnightBlue;
        }

        private void btnNext1_MouseLeave(object sender, EventArgs e)
        {
            btnNext1.BackColor = Color.RoyalBlue;
        }
    }
}
