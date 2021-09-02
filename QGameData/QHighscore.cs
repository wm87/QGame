using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QGameData
{
    public class QHighscore
    {
        public static void SetHighscore(User user)
        {
            int cntRight = default;

            foreach (Antwort item in user.ListUserAnswer)
                if (item.IsRightAnswere) cntRight++;

            double score = (cntRight / (double)user.ListUserAnswer.Length) * 100;

            Highscore highscore = new Highscore(DateTime.Now, user.Name, score);

            List<Highscore> listNewHighscore = new List<Highscore>();
            string fileName = "D:\\highscore.json";

            if (!File.Exists(fileName))
            {
                listNewHighscore.Add(highscore);
                string jsonString = JsonConvert.SerializeObject(listNewHighscore);
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                string res = File.ReadAllText(fileName);
                listNewHighscore = JsonConvert.DeserializeObject<List<Highscore>>(res);
                listNewHighscore.Add(highscore);
                listNewHighscore.Sort();
                if (listNewHighscore.Count > 10) listNewHighscore.RemoveRange(10, listNewHighscore.Count - 10);
                string jsonString = JsonConvert.SerializeObject(listNewHighscore);
                File.WriteAllText(fileName, jsonString);
            }
        }

        public class Highscore : IComparable
        {
            public Highscore(DateTime date, string name, double score)
            {
                Date = date;
                Name = name;
                Score = score;
            }

            public DateTime Date { get; set; }
            public string Name { get; set; }
            public double Score { get; set; }

            public int CompareTo(object obj)
            {
                Highscore highscore = obj as Highscore;

                if (highscore == null) return 1;

                return highscore.Score.CompareTo(this.Score);
            }
        }
    }
}