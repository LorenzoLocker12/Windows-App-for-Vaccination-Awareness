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
    public partial class frmQuizGestante : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int porcentagem;
        int totalQuestions;


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



        public frmQuizGestante()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {

                porcentagem = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Acabou o Quiz!" + Environment.NewLine +
                    "Você respondeu " + score + " questões corretas!" + Environment.NewLine +
                    "Sua porcentagem total de acertos foi de: " + porcentagem + "%" + Environment.NewLine +
                    "Clique OK para jogar denovo!","Respostas", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Em caso de gravidez, quais são as vacinas CONTRAINDICADAS?";

                    button3.Text = "Triplice viral, HPV, Varíola e Dengue.";
                    button1.Text = "Dengue, HPV, Hepatite B e Influenza";
                    button4.Text = "Febre Amarela, Triplice Viral, Dengue e Hepatite A e B";
                    button2.Text = "Nenhuma alternativa.";

                    correctAnswer = 3;

                    break;
                case 2:

                    lblQuestion.Text = "Em caso de gravidez, quais são as vacinas RECOMENDADAS EM SITUAÇÕES ESPECIAIS?";

                    button3.Text = "Dengue, Influenza(gripe) e Febre Amarela";
                    button1.Text = "Hepatite A e B, Pneumocócias e Febre Amarela";
                    button4.Text = "HPV, Dengue e Febre Amarela";
                    button2.Text = "Nenhuma alternativa.";

                    correctAnswer = 1;
                    
                    break;
                case 3:

                    lblQuestion.Text = "Em caso de gravidez, quais são as vacinas RECOMENDADAS?";

                    button3.Text = "Hepatite Z e Influenza (gripe)";
                    button1.Text = "Hepatite A e Influenza (gripe)";
                    button4.Text = "Hepatite (A e B) e Influenza (gripe)";
                    button2.Text = "Hepatite B e Influenza (gripe)";

                    correctAnswer = 2;

                    break;
                case 4:

                    lblQuestion.Text = "Quantas doses uma gestante deve tomar da vacina contra Influenza (gripe)?";

                    button3.Text = "2 por semestre";
                    button1.Text = "3 por ano";
                    button4.Text = "1 por ano";
                    button2.Text = "1 por semestre";

                    correctAnswer = 4;

                    break;

                case 5:

                    lblQuestion.Text = "A vacinação é necessaria pois?";

                    button3.Text = "Tomar vacinas é a melhor maneira de se proteger de uma variedade de doenças.";
                    button1.Text = "Não é necessária";
                    button4.Text = "Enriquecerá empresas farmacêuticas";
                    button2.Text = "Cura as doenças imediatamente após tomar";

                    correctAnswer = 3;

                    break;

                case 6:

                    lblQuestion.Text = "A vacina de Hepatite B, em gestantes deve ser dosada de que forma?";

                    button3.Text = "Duas doses, no esquema 0-6 meses";
                    button1.Text = "1 dose anual";
                    button4.Text = "Três doses, no esquema 0-1-6 meses";
                    button2.Text = "Duas doses anuais";

                    correctAnswer = 4;

                    break;

                case 7:

                    lblQuestion.Text = "Mas essas doenças não estão presentes na minha comunidade, por que eu ainda preciso vacinar? Assinale a afirmativa correta em relação a sentença apresentada.";

                    button3.Text = "Só é necessário vacinar crianças e idosos";
                    button1.Text = "Não é necessário se vacinar caso a doença tenha sido erradicada em sua cidade";
                    button4.Text = "Pois embora a doença tenha sido eliminada em sua área, ela ainda pode existir em outras";
                    button2.Text = "Nenhuma alternativa";

                    correctAnswer = 4;
                    
                    break;

                case 8:

                    lblQuestion.Text = "Uma vacina pode fazer um bebê adoecer? Assinale a afirmativa correta."; 

                    button3.Text = "Nenhuma Alternativa";
                    button1.Text = "As vacinas podem gerar autismo em bebês";
                    button4.Text = "O certo é esperar o bebê fazer 3 anos";
                    button2.Text = "As vacinas são extremamente seguras e podem no máximo causar febre e dor no local da aplicação";

                    correctAnswer = 2;
                    
                    break;




            }



        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmpg = new frmPrincipalGestante();
            frmpg.Show();
        }

        private void btnBack2_MouseHover(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.MidnightBlue;
        }

        private void btnBack2_MouseLeave(object sender, EventArgs e)
        {
            btnBack2.BackColor = Color.RoyalBlue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MidnightBlue;
                
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.RoyalBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.MidnightBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor= Color.RoyalBlue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.MidnightBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.MidnightBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.RoyalBlue;
        }

        private void frmQuizGestante_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            btnBack2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack2.Width, btnBack2.Height, 30, 30));
        }
    }
}
  

