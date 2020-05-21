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
            if (titolo == "Narcos")
            {
                indirizzo = "https://upload.wikimedia.org/wikipedia/it/thumb/3/30/Narcos.png/390px-Narcos.png";
                return indirizzo;
            }
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "_");
            indirizzo = indirizzo.Replace("'", "%27");
            indirizzo = indirizzo.Replace(":", "%3A");
            indirizzo = $"https://it.wikipedia.org/wiki/{indirizzo}";

            string immagine = default;
            int x = default;
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
                if (!(immagine == "https://it.wikipedia.org/wiki/{indirizzo}"))
                {

                    foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img[@src]"))
                    {
                        HtmlAttribute att = link.Attributes["src"];
                        if (att.Value.Contains("#"))
                        {
                            string[] substring = att.Value.Split('#');

                            immagine = substring[0];
                            x++;
                        }
                        else
                        {
                            immagine = att.Value;
                        }

                        if (x == 0)
                        {
                            break;
                        }
                    }

                }

                if (indirizzo == "https://it.wikipedia.org/wiki/Stranger_Things")
                {
                    immagine = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Stranger_Things_logo.png/390px-Stranger_Things_logo.png";
                    return immagine;
                }
                if (immagine == "//upload.wikimedia.org/wikipedia/commons/thumb/4/46/Disambigua_compass.svg/35px-Disambigua_compass.svg.png")
                {
                    throw new Exception();
                }
                if (immagine == "//upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Nota_disambigua.svg/27px-Nota_disambigua.svg.png")
                {
                    throw new Exception();
                }
                check = true;
                return immagine;
            }
            catch
            {
                indirizzo = $"{indirizzo}_(serie_televisiva)";
                immagine = Immagine2(indirizzo);
                check = false;
                return immagine;



            }
        }

        public static string Immagine2(string indirizzo)
        {

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

                return immagine;
            }
            catch
            {


                string problema = "Immagine non trovata,probabilmente il titolo inserito è sbagliato";
                return problema;


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

                if (data == 0)

                {
                    indirizzo = $"{indirizzo}_(serie_televisiva)";
                    data = Data2(indirizzo);
                }
                check = true;
                return data;
            }
            catch
            {

                indirizzo = $"{indirizzo}_(serie_televisiva)";
                data = Data2(indirizzo);



                check = true;

                return data;




            }
        }
        public static int Data2(string indirizzo)
        {

            int data = default;


            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);

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

                return data;
            }
            catch
            {


                int x = -1;
                return x;


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
            try{
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
            catch
            {

               trama = Trama2(titolo);
                return trama;
            }


        }
         
        public static string Trama2(string titolo)
        {
        
            bool c = false;
            string indirizzo = default;
            indirizzo = titolo.Trim();
            indirizzo = indirizzo.Replace(" ", "");
            indirizzo = indirizzo.ToLower();
            int data = Data(titolo, c);
            indirizzo = $"https://www.mymovies.it/film/{data}/{indirizzo}/";
            
           
            string trama = default;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc;
            doc = web.Load(indirizzo);
 
            try
            {
                var list = doc.DocumentNode.SelectSingleNode("//p[@class='corpo']").InnerText;
                trama = list;
                trama = trama.Trim();
                trama = trama.ToLower();
                
            }
            catch
            {
                
                indirizzo = titolo.Trim();
                indirizzo = indirizzo.Replace(" ", "");
                indirizzo = indirizzo.ToLower();
               
                indirizzo = $"https://www.mymovies.it/netflix/{indirizzo}/";
                
                doc = web.Load(indirizzo);
                var list = doc.DocumentNode.SelectSingleNode("//p[@class='corpo']").InnerText;
                trama = list;
                trama = trama.Trim();
                trama = trama.ToLower();

            }


          
         
            return trama;
        
        
        }


    }

}

