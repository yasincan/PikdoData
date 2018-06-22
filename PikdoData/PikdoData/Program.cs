using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using System.Text;
using System.Threading.Tasks;

namespace PikdoData
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------PikdoData---------------
            Uri url = new Uri("https://piknu.com/u/rterdogan/following");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            var basliklar = dokuman.DocumentNode.SelectNodes("//a [@class='name']");

            int i = 1;
            StreamWriter Write = new StreamWriter("D:\\following.txt");
            foreach (var baslik in basliklar)
            {
                Write.WriteLine(baslik.InnerText);
            }
            Write.Close();
            Console.WriteLine("Ok!");
            //------------------------------------------------------
            //StreamReader Read = new StreamReader("D:\\c.txt");
            //Console.ReadKey();
        }
    }
}
