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
            string immagine = default;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load("https://it.wikipedia.org/wiki/Breaking_Bad#Episodi");

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

                }
                break;
            }

            return immagine;
        }
    }
}
