using QGameController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Windows.Forms;

namespace QGameGUI
{
    public partial class Quiz : System.Windows.Forms.Form
    {
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();

        int amount = 10;

        QGame qGame;

        public Quiz()
        {
            InitializeComponent();

            qGame = new QGame(amount, txtURL.Text);
            qGame.QuestionAsked += Question;
            qGame.UserAnswered += Answer;

            btnHighscore.Enabled = false;
        }

        private void Answer(object sender, QUserEventArgs e)
        {
            if (e.AktuellerUser.ListUserAnswer[e.ActQCard].IsRightAnswere == false)
                txtLoesung.Text = "Richtig wäre " + e.AktuelleQCard.CorrectAnswer;
            else
                txtLoesung.Text = "Antwort ist richtig";

            if (e.ActQCard == amount - 1)
            {
                txtRichtig.Text = "Fragen richtig beantwortet:\n";
                txtFalsch.Text = "Fragen falsch beantwortet:\n";

                txtResult.Text = e.AktuellerUser.Ergebnis();

                for (int i = 0; i < e.AktuellerUser.ListUserAnswer.Length; i++)
                {
                    if (e.AktuellerUser.ListUserAnswer[i].IsRightAnswere == true)
                        txtRichtig.Text += $"{i + 1} \n";
                    else
                        txtFalsch.Text += $"{i + 1} => {e.AktuellerUser.ListUserAnswer[i].CorrectAnswer}\n";
                }

                btnHighscore.Enabled = true;
            }
            else
            {
                btnNext.Enabled = true;
                btnHighscore.Enabled = false;
            }

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
        }

        private void Question(object sender, QGameEventArgs e)
        {
            txtCat.Text = e.AktuelleQCard.Category;
            txtDifficulty.Text = e.AktuelleQCard.Difficulty;
            txtFrage.Text = HttpUtility.HtmlDecode(e.AktuelleQCard.Question);
            lblFrage.Text = $"Frage {e.ActQCard}";

            List<string> antwortenlist = new List<string>(4);
            foreach (string item in e.AktuelleQCard.IncorrectAnswers)
                antwortenlist.Add(HttpUtility.HtmlDecode(item));

            antwortenlist.Add(HttpUtility.HtmlDecode(e.AktuelleQCard.CorrectAnswer));
            antwortenlist.Sort();

            pnlAnwortAuswahl.Controls.Clear();

            if (e.AktuelleQCard.Type == "multiple")
            {
                btn1 = new Button();
                btn1.Text = antwortenlist[0];
                btn1.Click += btnCheckAnswer;
                btn1.Size = new Size(190, 23);

                btn2 = new Button();
                btn2.Text = antwortenlist[1];
                btn2.Click += btnCheckAnswer;
                btn2.Size = new Size(190, 23);

                btn3 = new Button();
                btn3.Text = antwortenlist[2];
                btn3.Click += btnCheckAnswer;
                btn3.Size = new Size(190, 23);

                btn4 = new Button();
                btn4.Text = antwortenlist[3];
                btn4.Click += btnCheckAnswer;
                btn4.Size = new Size(190, 23);

                btn1.Location = new Point(3, 3);
                btn2.Location = new Point(3, 32);
                btn3.Location = new Point(200, 3);
                btn4.Location = new Point(200, 32);

                pnlAnwortAuswahl.Controls.Add(btn1);
                pnlAnwortAuswahl.Controls.Add(btn2);
                pnlAnwortAuswahl.Controls.Add(btn3);
                pnlAnwortAuswahl.Controls.Add(btn4);
            }
        }

        private void btnCheckAnswer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (qGame.AktuelleQCard.CorrectAnswer == btn.Text) btn.BackColor = Color.LimeGreen;
            else btn.BackColor = Color.Coral;

            qGame.UserAnswer(btn.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnHighscore.Enabled = false;
            txtLoesung.Text = "";
            txtRichtig.Text = "";
            txtFalsch.Text = "";

            qGame.PrevQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtLoesung.Text = "";

            qGame.NextQuestion();

            btnNext.Enabled = false;
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            qGame.WriteHighscore(txtUser.Text);
        }
    }
}
