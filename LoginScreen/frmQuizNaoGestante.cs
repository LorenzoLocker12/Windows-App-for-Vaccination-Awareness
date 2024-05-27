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
    public partial class frmQuizNaoGestante : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
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


        public frmQuizNaoGestante()
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

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Acabou o Quiz!" + Environment.NewLine +
                    "Você respondeu " + score + " questões corretas!" + Environment.NewLine +
                    "Sua porcentagem total de acertos foi de: " + percentage + "%" + Environment.NewLine +
                    "Clique OK para jogar denovo!", "Respostas", MessageBoxButtons.OK, MessageBoxIcon.Information
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

                    lblQuestion.Text = "A vacina de dengue é CONTRAINDICADA para: ";

                    button3.Text = "Adultos nutrizes, gestantes e imunodeprimidos";
                    button1.Text = "Adultos nutrizes, gestantes e atletas";
                    button4.Text = "Gestantes, profissionais da saúde e atletas";
                    button2.Text = "Atletas, adultos soronegativos e adultos com 26 anos completos";

                    correctAnswer = 3;
                    break;
                case 2:

                    lblQuestion.Text = "A vacina de HPV, em adultos, deve ser dosada: ";

                    button3.Text = "1 anualmente";
                    button1.Text = "Três doses: 0-1 a 2-6 meses";
                    button4.Text = "2 anualmente";
                    button2.Text = "Nenhuma alternativa.";

                    correctAnswer = 1;

                    break;
                case 3:

                    lblQuestion.Text = "A Vacinação funciona como uma cura imediata?";

                    button3.Text = "Não, ela prepara o organismo para combater o virus de maneira mais rápida e eficaz ";
                    button1.Text = "Não, ela cura o individuo após 3 dias.";
                    button4.Text = "Sim, logo após tomar a vacina o enfermo será curado imediatamente";
                    button2.Text = "Nenhuma alternativa";

                    correctAnswer = 3;

                    break;
                case 4:

                    lblQuestion.Text = "Considere a seguinte afirmação: (Um adulto saúdavel não precisa tomar nenhuma vacina). Ela está: ";

                    button3.Text = "Correta, pois como ele é saudável a chance de contrair doenças é nula";
                    button4.Text = "Incorreta, pois mesmo sendo um adulto saúdavel o mesmo ainda é sucetível a doenças";
                    button1.Text = "Correta, pois vacinas servem apenas para se curar de doenças já adquiridas";
                    button2.Text = "Incorreta, pois ele precisa tomar apenas a vacina de HPV, e não todas necessárias";

                    correctAnswer = 4;

                    break;

                case 5:

                    lblQuestion.Text = "A vacinação é necessária pois?";

                    button3.Text = "Tomar vacinas é a melhor maneira de se proteger de uma variedade de doenças.";
                    button1.Text = "Não é necessária";
                    button4.Text = "Enriquecerá empresas farmacêuticas";
                    button2.Text = "Cura de doenças imediatamente após tomar";

                    correctAnswer = 3;

                    break;

                case 6:

                    lblQuestion.Text = "Todas as vacinas são obrigatórias?";

                    button4.Text = "Não, porém um adulto vacinado possui uma expectativa de vida maior do que um não vacinado";
                    button1.Text = "Sim, o governo obriga.";
                    button3.Text = "Sim, é obrigatório apenas para idosos";
                    button2.Text = "Sim, é obrigatório apenas para idosos e gestantes";

                    correctAnswer = 4;

                    break;

                case 7:

                    lblQuestion.Text = "Mas essas doenças não estão presentes na minha comunidade. Por que eu ainda preciso vacinar? Assinale a afirmativa correta em relação a sentença apresentada.";

                    button3.Text = "Só é necessário vacinar crianças e idosos";
                    button1.Text = "Não é necessário se vacinar caso a doença tenha sido erradicada em sua cidade";
                    button4.Text = "Pois embora a doença tenha sido eliminada em sua área, ela ainda pode existir em outras";
                    button2.Text = "Nenhuma alternativa";

                    correctAnswer = 4;

                    break;

                case 8:

                    lblQuestion.Text = "Uma vacina pode fazer uma pessoa adoecer? Assinale a afirmativa correta.";

                    button3.Text = "Nenhuma Alternativa";
                    button1.Text = "As vacinas podem gerar autismo";
                    button4.Text = "As vacinas podem fazer alguém morrer, mesmo não sendo alérgico a nenhum componente.";
                    button2.Text = "As vacinas são extremamente seguras e podem no máximo causar febre e dor no local da aplicação";

                    correctAnswer = 2;

                    break;




            }



        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmpng = new frmPrincipalNaoGestante();
            frmpng.Show();


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
            button1.BackColor = Color.RoyalBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.MidnightBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.RoyalBlue;
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

        private void frmQuizNaoGestante_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            btnBack2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack2.Width, btnBack2.Height, 30, 30));
        }
    }
}
