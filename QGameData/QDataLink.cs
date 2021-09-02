using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace QGameData
{
    public class QDataLink
    {
        public static List<QCard> GetQCards(int amount, string url)
        {
            List<QCard> listAsks = new List<QCard>();

            Encoding encoding = Encoding.UTF8;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers["Accept-Encoding"] = "gzip,deflase";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream, encoding);

            Result res = JsonConvert.DeserializeObject<Result>(reader.ReadToEnd());

            for (int i = 0; i < res.Asks.Length; i++)
                listAsks.Add(res.Asks[i]);

            return listAsks;
        }
    }
}
