using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Web_Scrapping
{
    class Reserch
    {
        public static string Immagine(string titolo)
        {
            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "_");
            indirizzo = indirizzo.Replace("'", "%27");
            indirizzo = indirizzo.Replace(":", "%3A");
            indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}";
            string immagine = default;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img[@src]"))
            {
                HtmlAttribute att = link.Attributes["src"];
                if (att.Value.Contains("#"))
                {
                    string[] substring = att.Value.Split('#');

                    immagine = substring[0];

                }
                else
                {
                    immagine = att.Value;
                }
                break;
            }

            return immagine;
        }

        public static int Data(string titolo)
        {
            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "_");
            indirizzo = indirizzo.Replace("'", "%27");
            indirizzo = indirizzo.Replace(":", "%3A");
            indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}";
            
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

            int data = default;
           

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@title]"))
            {
                HtmlAttribute att = link.Attributes["title"];
                if (att.Value.Contains("#"))
                {
                    string[] substring = att.Value.Split('#');



                }
                else
                {

                    try
                    {
                        data = int.Parse(att.Value);
                        break;
                    }
                    catch
                    {

                    }
                }

            }

            return data;
        }

        public static string Episodi(string titolo)
        {
            string episodi = default;

            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "_");
            indirizzo = indirizzo.Replace("'", "%27");
            indirizzo = indirizzo.Replace(":", "%3A");
            indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}";
            string immagine = default;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

            var list = doc.DocumentNode.SelectSingleNode("//table[@class='sinottico']")
             .Descendants("tr")
             .Select(x => new
             {
                 Val1 = x.SelectSingleNode("td[@class='']")?.InnerText,

             })
             .Where(x => x.Val1 != null)
             .ToList();

            episodi = list[6].ToString();
            episodi = episodi.Substring(9, 3);
            episodi = episodi.Trim();

            return episodi;
        }
    }
}
