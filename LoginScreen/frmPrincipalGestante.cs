using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class frmPrincipalGestante : Form
    {
        public frmPrincipalGestante()
        {
            InitializeComponent();
        }

        private void btnVoltarGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 VoltarGestantePainelDeInformação= new Form1();
            VoltarGestantePainelDeInformação.Show(); 
        }

        private void btnSairGestante_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Você tem certeza que deseja fechar o aplicativo?", "Fechar o Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInfoGestante_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmivg1 = new frmInfoVacinalGeral1();
            frmivg1.Show();
        }

        private void btnQuizGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmqg = new frmQuizGestante();
            frmqg.Show();
        }

        private void btnCreditosGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmcr = new frmCréditosTrabalho();
            frmcr.Show();
        }
        private void btnInfoGestante_MouseHover(object sender, EventArgs e)
        {
            btnInfoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnInfoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnInfoGestante.BackColor = Color.RoyalBlue;
        }
        private void btnCreditosGestante_MouseHover(object sender, EventArgs e)
        {
            btnCreditosGestante.BackColor = Color.MidnightBlue;
        }

        private void btnCreditosGestante_MouseLeave(object sender, EventArgs e)
        {
            btnCreditosGestante.BackColor = Color.RoyalBlue;
        }
        private void btnQuizGestante_MouseHover(object sender, EventArgs e)
        {
            btnQuizGestante.BackColor = Color.MidnightBlue;
        }

        private void btnQuizGestante_MouseLeave(object sender, EventArgs e)
        {
            btnQuizGestante.BackColor = Color.RoyalBlue;
        }
        private void btnSairGestante_MouseHover(object sender, EventArgs e)
        {
            btnSairGestante.BackColor = Color.MidnightBlue;
        }

        private void btnSairGestante_MouseLeave(object sender, EventArgs e)
        {
            btnSairGestante.BackColor = Color.RoyalBlue;
        }
        private void btnVoltarGestante_MouseHover(object sender, EventArgs e)
        {
            btnVoltarGestante.BackColor = Color.MidnightBlue;
        }

        private void btnVoltarGestante_MouseLeave(object sender, EventArgs e)
        {
            btnVoltarGestante.BackColor = Color.RoyalBlue;
        }

    }
}
