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
        public static string Immagine(string titolo, bool check)
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
            try
            {
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
                check = true;
                return immagine;
            }
            catch
            {
                try
                {
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
                    check = true;
                    return immagine;
                }
                catch
                {
                    check = false;
                    string problema = "Immagine non trovata,probabilmente il titolo inserito è sbagliato";
                    return problema;
                }
               
            }
        }

        public static int Data(string titolo, bool check)
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

            try
            {
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
                check = true;
                return data;
            }
            catch
            {
                try
                {

                    indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}_(serie_televisiva)";
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
                    check = true;
                    return data;
                }
                catch
                {
                    check = false;
                    int x = -1;
                    return x;
                }

            }
        }

        public static string Episodi(string titolo, bool check)
        {
            string episodi = default;

            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "_");
            indirizzo = indirizzo.Replace("'", "%27");
            indirizzo = indirizzo.Replace(":", "%3A");
            indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}";

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

            try
            {
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

                check = true;
                return episodi;
            }
            catch
            {
                indirizzo = $"{indirizzo}_(serie_televisiva)";
                episodi = Episodi2(indirizzo);
                if (episodi == "N episodi non trovati, probabilmente il titolo inserito è sbagliato")
                {
                    check = false;
                    return episodi;
                }
                check = true;
                return episodi;
            }
        }
        public static string Episodi2(string indirizzo)
        {
            string episodi = default;





            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);



            try
            {

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
            catch
            {
                string problema = "N episodi non trovati,probabilmente il titolo inserito è sbagliato";
                return problema;
            }


        }


        public static string Trama(string titolo)
        {

            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "-");
            indirizzo = indirizzo.ToLower();

            indirizzo = $"https://www.nientepopcorn.it/serie-tv/{indirizzo}";
            string trama = default;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

            var list = doc.DocumentNode.SelectSingleNode("//p[@class='trama']").InnerText;


            trama = list;
            trama = trama.Trim();
            trama = trama.ToLower();
            int lung = trama.Length;
            var autore = doc.DocumentNode.SelectSingleNode("//a[@title='Autore trama']").InnerText;
            autore = autore.Trim();
            int lung2 = autore.Length;

            trama = trama.Remove(lung - 24 - lung2, 24 + lung2);
            return trama;



        }



    }

}

