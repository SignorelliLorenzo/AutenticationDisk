using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace funz
{
    
    public class funzioni
    {
        public struct serie
    {
        public string nome;
        public string trama;
        public int episodi;
        public int epvisti;
        public DateTime uscita;
        public string immage;

        }
        public static int Cerca(serie[] el, int n, string cod)
        {
            int x = default(int);
            while (x < n)
            {
                if (string.Compare(cod, el[x].nome) == 0)
                {
                    return x;
                }
                x++;
            }
            return -1;
        }
        public static void ordinac(serie[] elep, int n)
        {
            int x = 0;
            int y = 0;
            serie k = default(serie);
            while (n > x)
            {
                y = x + 1;
                while (n > y)
                {
                    if (string.Compare(elep[x].nome, elep[y].nome) > 0)
                    {
                        k = elep[x];
                        elep[x] = elep[y];
                        elep[y] = k;
                    }
                    y++;
                }
                x++;
            }
        }
            public static void ordinad(serie[] elep, int n)
            {
                int x = 0;
                int y = 0;
                serie k = default(serie);
                while (n > x)
                {
                    y = x + 1;
                    while (n > y)
                    {
                        if (string.Compare(elep[x].nome, elep[y].nome) < 0)
                        {
                            k = elep[x];
                            elep[x] = elep[y];
                            elep[y] = k;
                        }
                        y++;
                    }
                    x++;
                }
            }
        public static int elimina(serie[] elep, ref int n, string cod)
        {
            int x = default(int);

            int y = 0;
            x = 0;
            while (x < n)
            {
                if (string.Compare(elep[x].nome, cod) == 0)
                {

                    elep[x] = elep[n - 1];
                    n = n - 1;
                    y++;
                }
                x++;
            }
            return y;
        }
        public static void salva(serie[] elep, int n, string p)
        {
            int x = 0;
       

                StreamWriter miofile;
                miofile = new StreamWriter(p);
                while (x < n)
                {
                    miofile.WriteLine(elep[x].nome);
                    miofile.WriteLine(elep[x].trama);
                    miofile.WriteLine(elep[x].episodi);
                    miofile.WriteLine(elep[x].epvisti);
                    miofile.WriteLine(elep[x].uscita);
                    miofile.WriteLine(elep[x].immage);
                    x++;
                }
                miofile.Close();
           
        }
        public static bool Carica(serie[] el, ref int n, string p)
        {
            if (!File.Exists(p))
            {
                return false;
            }
            StreamReader miofile = default(StreamReader);
            miofile = new StreamReader(p);
            serie k = default(serie);
            n = 0;
            while (miofile.EndOfStream == false)
            {
                k.nome = miofile.ReadLine();
                k.trama = miofile.ReadLine();
                k.episodi = int.Parse(miofile.ReadLine());
                k.epvisti = int.Parse(miofile.ReadLine());
                k.uscita = DateTime.Parse(miofile.ReadLine());
                k.immage = miofile.ReadLine();

                el[n] = k;
                n++;
            }
            miofile.Close();
            return true;



        }
        //public static decimal Media(serie[] el, int n)
        //{
        //    int x = 0;
        //    decimal a = 0;
        //    decimal b = 0;
        //    decimal tot= 0;
        //    while (x < n)
        //    {
               
        //        b = b + el[x].prezzo;              
        //        x++;
        //    }
        //    tot = b;
        //    if (n != 0)
        //    {
        //        tot = tot / n;
        //    }
        //    return tot;

        //}
    }
}
