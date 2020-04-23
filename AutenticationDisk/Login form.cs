using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Hashing;
using MySql.Data.MySqlClient;


namespace AutenticationDisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Database pagin = new Database();
            //pagin.Show();
            //this.Hide();
            if (string.IsNullOrEmpty(BoxName.Text) == true || string.IsNullOrEmpty(BoxPass.Text) == true)
            {
                return;
            }
            string user1 = BoxName.Text;
            string pass1 = BoxPass.Text;
            string supersecretpass = "X6!GZ9Pz}N9&8oECRZCYqrM,XXM2+ZwcYgkHIW";
            try
            {
                var conn = new MySqlConnection($"Server=85.10.205.173;port=3306;Uid=ad_pass;Pwd={supersecretpass};Database=passfolder1;Connection Timeout=30;old guids=true;");
                conn.Open();
                var cmd = new MySqlCommand("select * from Tabelle", conn);
                MySqlDataReader dr = default;
                dr = cmd.ExecuteReader();
                bool userfound = false;
                string pass = default;
                while (dr.Read() == true)
                {
                    if (user1 == dr["Utente"] as string)
                    {
                        userfound = true;
                        pass = dr["Password"] as string;
                        break;
                    }
                }
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
                if (userfound == false)
                {
                    MessageBox.Show("Utente non trovato");
                    

                }
                else
                {


                    if (Secure.GetHashString(pass1).Equals(pass))
                    {
                        MessageBox.Show("Login Eseguito");
                        scheda_database pagin = new scheda_database();
                        pagin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password non riconosciuta");

                    }
                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Login Fallito");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 pagin = new Form2();
            pagin.Show();
            this.Hide();
        }
    }
}
