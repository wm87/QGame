using QGameData;
using System;
using System.Collections.Generic;

namespace QGameController
{
    public class QGame
    {
        public static int actQCard = -1;

        public List<QCard> Spielstapel { get; set; }

        public User User { get; set; }

        public QCard AktuelleQCard { get; set; }

        public delegate void QuestionAskedEventHandler(object sender, QGameEventArgs e);
        public event QuestionAskedEventHandler QuestionAsked;

        protected virtual void OnQuestionAsked(QGameEventArgs e)
        {
            QuestionAsked?.Invoke(this, e);
        }

        public delegate void UserAnswerEventHandler(object sender, QUserEventArgs e);
        public event UserAnswerEventHandler UserAnswered;

        protected virtual void OnUserAnswered(QUserEventArgs e)
        {
            UserAnswered?.Invoke(this, e);
        }

        public QGame(int amount, string url)
        {
            Spielstapel = QDataLink.GetQCards(amount, url);
            User = new User("", amount);
        }

        public void UserAnswer(string answer)
        {
            AktuelleQCard = Spielstapel[actQCard];

            if (AktuelleQCard.CorrectAnswer == answer)
                User.ListUserAnswer[actQCard] = new Antwort(AktuelleQCard.Question, answer, true, AktuelleQCard.CorrectAnswer);
            else
                User.ListUserAnswer[actQCard] = new Antwort(AktuelleQCard.Question, answer, false, AktuelleQCard.CorrectAnswer);

            QUserEventArgs qUserEventArgs = new QUserEventArgs(AktuelleQCard, User, actQCard);
            OnUserAnswered(qUserEventArgs);
        }

        public void PrevQuestion()
        {
            --actQCard;

            if (actQCard <= 0) actQCard = 0;

            AktuelleQCard = Spielstapel[actQCard];
            // TODO : Prüfung
            QGameEventArgs qGameEventArgs = new QGameEventArgs(AktuelleQCard, actQCard);
            OnQuestionAsked(qGameEventArgs);
        }

        public void NextQuestion()
        {
            actQCard++;
            if (actQCard >= Spielstapel.Count) actQCard = Spielstapel.Count - 1;

            AktuelleQCard = Spielstapel[actQCard];
            // TODO : Prüfung
            QGameEventArgs qGameEventArgs = new QGameEventArgs(AktuelleQCard, actQCard);
            OnQuestionAsked(qGameEventArgs);
        }

        public void WriteHighscore(string name)
        {
            User.Name = name;
            QHighscore.SetHighscore(User);
        }
    }

    public class QGameEventArgs : EventArgs
    {
        public QGameEventArgs(QCard aktuelleQCard, int actQCard)
        {
            AktuelleQCard = aktuelleQCard;
            ActQCard = actQCard;
        }

        public QCard AktuelleQCard { get; set; }
        public int ActQCard { get; set; }
    }

    public class QUserEventArgs : EventArgs
    {
        public QUserEventArgs(QCard aktuelleQCard, User user, int actQCard)
        {
            AktuelleQCard = aktuelleQCard;
            AktuellerUser = user;
            ActQCard = actQCard;
        }

        public QCard AktuelleQCard { get; set; }
        public User AktuellerUser { get; set; }
        public int ActQCard { get; set; }
    }
}
