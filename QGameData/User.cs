namespace QGameData
{
    public class User
    {
        public Antwort[] ListUserAnswer { get; set; }

        static int cntuser = default;

        public string Name { get; set; }

        public int ID { get; }

        private User()
        {
            ID = ++cntuser;
        }

        public User(string name, int amount) : this()
        {
            Name = name;
            ListUserAnswer = new Antwort[amount];
        }

        public string Ergebnis()
        {
            int cntRichtige = default;
            int cntFalsche = default;

            for (int i = 0; i < ListUserAnswer.Length; i++)
            {
                if (ListUserAnswer[i].IsRightAnswere) cntRichtige++;
                else cntFalsche++;
            }

            return $"Du hast {cntRichtige} Richtige und {cntFalsche} Falsche Antworten";
        }
    }

    public class Antwort
    {
        public Antwort(string question, string userAntwort, bool isRightAnswere, string correctAnswer)
        {
            this.Question = question;
            this.UserAntwort = userAntwort;
            this.IsRightAnswere = isRightAnswere;
            this.CorrectAnswer = correctAnswer;
        }

        public string Question { get; set; }
        public string UserAntwort { get; set; }
        public bool IsRightAnswere { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
