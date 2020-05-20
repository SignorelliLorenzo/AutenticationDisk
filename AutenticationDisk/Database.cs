using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using funz;
using Web_Scrapping;

namespace AutenticationDisk
{
    public partial class scheda_database : Form
    {
        public scheda_database()
        {
            InitializeComponent();
        }

        public static serie[] test = new serie[100];
        int num = default(int);
        public static int variable = default(int);
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            int x = default(int);
            string cod = default(string);

            cod = textBox1.Text;
            x = funz.funzioni.elimina(test, ref num, cod);
            if (x > 0)
            {
                MessageBox.Show("Hai eliminato " + x + " serie");
            }
            textBox1.Visible = false;
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int k = default;
            k=listView1.SelectedIndices.Count;
            if(k!=0)
            {
                label2.Visible = true;
                add.Visible = true;
                decrease.Visible = true;
                button6.Visible = true;
                variable= funzioni.Cerca(test, num, listView1.SelectedItems[0].SubItems[0].Text);
            }

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //int k = e.Column;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = default(int);
            listView1.Items.Clear();
            while (x < num)
            {
                var row = new string[] { test[x].nome, test[x].uscita.ToString(), test[x].episodi.ToString(), test[x].epvisti.ToString(), test[x].trama, test[x].immage };
                var listrow = new ListViewItem(row);
                listView1.Items.Add(listrow);
                x = x + 1;
            }
            if (comboBox1.Text == "Ordina per nome (crescente)")
                funz.funzioni.ordinac(test, num);
            if (comboBox1.Text == "Ordina per nome (decrescente)")
                funz.funzioni.ordinad(test, num);
            if (comboBox1.Text == "Ordina per episodi (crescente)")
                funz.funzioni.ordinacep(test, num);
            if (comboBox1.Text == "Ordina per episodi (decrescente)")
                funz.funzioni.ordinadep(test, num);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Form1.currentuser + @"\" + DateTime.Now.ToString();
        


            funz.funzioni.salva(test, num, path);
            MessageBox.Show("Hai salvato le modifiche");




          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                return;
            }
            int k = default(int);
            string ns = default(string);
            ns = textBox2.Text;
            bool check = true;
            serie z = default(serie);
            z.nome = ns;

            z.uscita = Reserch.Data(ns, check);
            if (z.uscita == -1)
            {
                MessageBox.Show("Errore Serie non trovata probabilmente il nome inserito è scorretto");
                return;
            }
            check = int.TryParse(Reserch.Episodi(ns, check), out z.episodi);
            if (!check)
            {
                MessageBox.Show("Errore Serie non trovata probabilmente il nome inserito è scorretto");
                return;
            }

            z.immage = Reserch.Immagine(ns, check);
            if(z.immage== "Immagine non trovata,probabilmente il titolo inserito è sbagliato")
            {
                MessageBox.Show("Errore Serie non trovata probabilmente il nome inserito è scorretto");
                return;
            }
            try
            {
                z.trama = Reserch.Trama(ns);
                
            }
            catch
            {
                MessageBox.Show("Errore Serie non trovata probabilmente il nome inserito è scorretto");
                return;
            }
            int x = 0;
            while (x < num)
            {
                if (z.nome == test[x].nome)
                {
                    MessageBox.Show("Serie già inserita");
                    return;
                }
                x++;
            }
            test[num] = z;
            num++;


            var row = new string[] { z.nome, z.uscita.ToString(), z.episodi.ToString(), z.epvisti.ToString()};
            var listrow = new ListViewItem(row);
            listView1.Items.Add(listrow);

        }

        private void btncerca_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int pos = default(int);

            //if (String.IsNullOrEmpty(textBox3.Text))
            //    return;

            //pos = funz.funzioni.Cerca(test, num, textBox3.Text);
            //if (pos < 0)
            //{
            //    MessageBox.Show("Prodotto non trovato.");
            //    return;
            //}

            //modnome.Text = test[pos].nome;
            //modep.Text = test[pos].episodi.ToString();
            //modep.Text = test[pos].epvisti.ToString();
            //modepv.Text = test[pos].uscita.ToString();



            //return;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int pos = default(int);
            //string codicecercato = default(string);
            //codicecercato = listView2.SelectedItems[0].SubItems[0].Text;

            //pos = funz.funzioni.Cerca(test, num, codicecercato);

            //if (pos < 0)
            //{
            //    MessageBox.Show("Serie non trovata");
            //    return;
            //}

            //modnome.Text = test[pos].nome;
            //modep.Text = test[pos].episodi.ToString();
            //modepv.Text = test[pos].epvisti.ToString();
            //moduscita.Text = test[pos].uscita.ToString();


        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            INFO inf = new INFO();
            inf.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(test[variable].epvisti== test[variable].episodi)
            {
                MessageBox.Show("Limite raggiunto");
                return;
            }
            test[variable].epvisti = test[variable].epvisti + 1;
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            if (test[variable].epvisti == 0)
            {
                MessageBox.Show("Non puoi diminuire gli episodi visti");
                return;
            }
            test[variable].epvisti = test[variable].epvisti - 1;
        }
    }
}
