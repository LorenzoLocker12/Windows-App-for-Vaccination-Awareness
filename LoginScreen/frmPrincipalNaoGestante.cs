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
    public partial class frmPrincipalNaoGestante : Form
    {
        public frmPrincipalNaoGestante()
        {
            InitializeComponent();
        }

        private void btnVoltarNaoGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 VoltarNaoGestantePainelDeInformação = new Form1();
            VoltarNaoGestantePainelDeInformação.Show();
        }

        private void btnSairNaoGestante_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Você tem certeza que deseja fechar o aplicativo?", "Fechar o Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInfoNaoGestante_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmivg1 = new frmInfoVacinalGeral1();
            frmivg1.Show();
        }

        private void btnQuizNaoGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            var fpng = new frmQuizNaoGestante();
            fpng.Show();

        }

        private void btnCreditosNaoGestante_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmcr = new frmCréditosTrabalho();
            frmcr.Show();
        }
        private void btnInfoNaoGestante_MouseHover(object sender, EventArgs e)
        {
            btnInfoNaoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnInfoNaoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnInfoNaoGestante.BackColor = Color.RoyalBlue;
        }
        private void btnCreditosNaoGestante_MouseHover(object sender, EventArgs e)
        {
            btnCreditosNaoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnCreditosNaoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnCreditosNaoGestante.BackColor = Color.RoyalBlue;
        }
        private void btnQuizNaoGestante_MouseHover(object sender, EventArgs e)
        {
            btnQuizNaoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnQuizNaoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnQuizNaoGestante.BackColor = Color.RoyalBlue;
        }
        private void btnSairNaoGestante_MouseHover(object sender, EventArgs e)
        {
            btnSairNaoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnSairNaoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnSairNaoGestante.BackColor = Color.RoyalBlue;
        }
        private void btnVoltarNaoGestante_MouseHover(object sender, EventArgs e)
        {
            btnVoltarNaoGestante.BackColor = Color.MidnightBlue;
        }

        private void btnVoltarNaoGestante_MouseLeave(object sender, EventArgs e)
        {
            btnVoltarNaoGestante.BackColor = Color.RoyalBlue;
        }

        private void btnInfoNaoGestante_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipalNaoGestante_Load(object sender, EventArgs e)
        {

        }
    }
}
