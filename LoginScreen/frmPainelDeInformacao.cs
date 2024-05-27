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

namespace LoginScreen
{
    public partial class Form1 : Form
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

            public Form1()
            {
                InitializeComponent();
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        




        private void btnNext_Click(object sender, EventArgs e)
        {
            GlobalVariablesClass.vOne = cmbGestante_Required.Text;
            

                if (txtUserName_Required.Text == "")
                {
                    MessageBox.Show("O campo NOME é obrigatório! ", "-=ERRO=-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName_Required.Focus();
                    return;

                }
            if(cmbGestante_Required.Text == "")
            {
                MessageBox.Show("O campo GESTANTE é obrigatório! " ,"-=ERRO=-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGestante_Required.Focus();
                return;
            }

            while ((cmbGestante_Required.Text.ToUpper() != "SIM") && (cmbGestante_Required.Text.ToUpper() != "NÃO") && (cmbGestante_Required.Text.ToUpper() != "NAO"))
            {
                MessageBox.Show("O campo GESTANTE necessita possuir a resposta SIM ou NÃO! ", "-=ERRO=-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGestante_Required.Focus();
                return;
            }

                if ((cmbGestante_Required.Text.Equals("SIM") || cmbGestante_Required.Text.Equals("sim")))
                {
                    var frmpg = new frmPrincipalGestante();

                    frmpg.Show();
                    frmpg.Visible = true;
                    this.Hide();
                }
                else
                {
                    var frmpng = new frmPrincipalNaoGestante();

                    frmpng.Show();
                    frmpng.Visible = true;
                    this.Hide();
                }
            
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Você tem certeza que deseja fechar o aplicativo?", "Fechar o Aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNext.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNext.Width, btnNext.Height, 30, 30)); 
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.MidnightBlue;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.RoyalBlue;
        }
    }


}
