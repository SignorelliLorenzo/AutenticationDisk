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
using MySql.Data.MySqlClient;
using Hashing;

namespace AutenticationDisk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string user1 = BoxUserR.Text;
            string pass1 = BoxPassR.Text;
            string pass2 = BoxPass2R.Text;
            string supersecretpass = "X6!GZ9Pz}N9&8oECRZCYqrM,XXM2+ZwcYgkHIW";
            if (pass1.Length < 8)
            {
                MessageBox.Show("La password deve essere almeno lunga 8 caratteri");
                return;
            }
            int x = 0;
            char[] temp = new char[pass1.Length];
            int ct = 0;
            temp = pass1.ToCharArray();
            while (x < pass1.Length)
            {

                if (temp[x].GetHashCode() <= 48 && temp[x].GetHashCode() >= 57 && ct > 0)
                {
                    ct++;
                }
                if (temp[x].GetHashCode() <= 90 && temp[x].GetHashCode() >= 65 && ct > 0)
                {
                    ct++;
                }
                if (temp[x].GetHashCode() <= 122 && temp[x].GetHashCode() >= 97 && ct > 0)
                {
                    ct++;
                }
                x++;
            }
            if (ct != 3)
            {
                MessageBox.Show("La password deve contenere un carattere maiuscolo uno minuscolo e un numero");
                return;
            }
            try
            {
                var conn = new MySqlConnection($"Server=85.10.205.173;port=3306;Uid=ad_pass;Pwd={supersecretpass};Database=passfolder1;Connection Timeout=30;old guids=true;");
                conn.Open();



                string tempo1 = "C:\\App\\" + user1 + ".txt";
                bool alreadyregistered = false;
                
                if (pass1 == pass2)
                {
                    var cmd = new MySqlCommand("select * from Tabelle", conn);
                    MySqlDataReader dr = default;
                    dr = cmd.ExecuteReader();
                    while(dr.Read()==true)
                    {
                        if(user1==dr["Utente"]as string)
                        {
                            alreadyregistered = true;
                        }
                    }
                    dr.Close();
                    dr.Dispose();
                    cmd.Dispose();
                    if (alreadyregistered == true)
                    {
                        //Registrazione non valida
                        MessageBox.Show("Non è possibile registrarsi con questo nome utente");
                    }
                    else
                    {
                        if (user1 != "" && pass1 != "" && pass2 != "")
                        {
                            string pass=Secure.GetHashString(pass1);
                            var passfolder = new MySqlCommand("INSERT INTO Tabelle (Utente,Password) VALUES(@a,@b)", conn);
                            
                            passfolder.Parameters.AddWithValue("@a", user1);
                            passfolder.Parameters.AddWithValue("@b", pass);
                            int nr = passfolder.ExecuteNonQuery();
                            passfolder.Dispose();
                            if (nr == 0)
                            {
                                MessageBox.Show("Registrazione fallita");
                            }
                            else
                            {
                                MessageBox.Show("Registrazione completata");
                            }

                            BoxUserR.Text = "";
                            BoxPassR.Text = "";
                            BoxPass2R.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("RIEMPIRE I CAMPI RICHIESTI");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Le password non sono uguali");
                    BoxPassR.Text = "";
                    BoxPass2R.Text = "";
                }

                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Registrazione fallita");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 pagin = new Form1();
            pagin.Show();
            this.Hide();
        }

        private void BoxEmailR_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
