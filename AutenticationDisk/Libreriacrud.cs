using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticationDisk
{
    public struct Serie
	{
    public string Nome;
    public string immage;
    public int episodi;
    public string trama;
    public int epvisti;
}
   
    class Libreriacrud
{






    public void ordinacr(Serie elep, int n)

    {
        int x = default(int);
        int y = default(int);
            Serie k = default(Serie);

            while (y < n)
        {
                x = y + 1;

                while (x < n)
            {
                if (string.Compare(elep[x].nome, elep[y].nome) < 0)
                {
                    k = elep[y]

                        elep[y] = elep[x]

                        elep[x] = k

                    }
                x++;
            }
            y++;
        }

    }

    public void ordinadc(Prodotti elep, int n)

    {
        int x = default(int);
        int y = default(int);
        Prodotti k = default(Prodotti)

            while (y < n)
        {
            x = y + 1

                while (x < n)
            {
                if (string.Compare(elep[x].codice, elep[y].codice) > 0)
                {
                    k = elep[y]

                        elep[y] = elep[x]

                        elep[x] = k

                    }
                x++;
            }
            y++;
        }

    }

    public bool elimina(Prodotti elep, ref int n, cod)
    {
        int x = default(int);
        while (x < n)
        {
            if (string.Compare(elep[x].codice, cod) == 0)
            {
                elep[x] = elep[n--];
                n--;
                return true;
            }
            x++;
        }
        return false;

    }
    public int cerca(Prodotti elep, int n, cod)
    {
        int x = default(int);
        while (x < n)
        {
            if (string.Compare(elep[x].codice, cod) == 0)
            {

                return x;
            }
            x++;
        }
        return -1




        }
    public static bool Carica(prog[] el, ref int n, string p)
    {
        if (!File.Exists(p))
        {
            return false;
        }
        StreamReader miofile = default(StreamReader);
        miofile = new StreamReader(p);
        prog k = default(prog);
        n = 0;
        while (miofile.EndOfStream == false)
        {
            k.nome = miofile.ReadLine();
            k.codice = miofile.ReadLine();

            k.prezzo = decimal.Parse(miofile.ReadLine());
            k.quantità = int.Parse(miofile.ReadLine());

            el[n] = k;
            n++;
        }
        miofile.Close();
        return true;



    }
    public static void salva(prog[] elep, int n, string p)
    {
        int x = 0;


        StreamWriter miofile;
        miofile = new StreamWriter(p);
        while (x < n)
        {
            miofile.WriteLine(elep[x].nome);
            miofile.WriteLine(elep[x].codice);
            miofile.WriteLine(elep[x].prezzo);
            miofile.WriteLine(elep[x].quantità);
            x++;
        }
        miofile.Close();

    }


}
}
    

