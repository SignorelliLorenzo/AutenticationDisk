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

namespace AutenticationDisk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string pass;
        private void button1_Click(object sender, EventArgs e)
        {
            string user1 = BoxUserR.Text;
            string pass1 = BoxPassR.Text;
            string pass2 = BoxPass2R.Text;
            string supersecretpass = "X6!GZ9Pz}N9&8oECRZCYqrM,XXM2+ZwcYgkHIW";
            var conn = new MySqlConnection($"Server=85.10.205.173;port=3306;Uid=ad_pass;Pwd={supersecretpass};Database=passfolder1;Connection Timeout=30;old guids=true;");

            string tempo1 = "C:\\App\\" + user1 + ".txt";
            if (pass1 == pass2)
            {
                if (File.Exists(tempo1))
                {
                    //Registrazione non valida
                    MessageBox.Show("Non è possibile registrarsi con questo nome utente");
                }
                else
                {
                    if (user1 != "" && pass != "")
                    {

                        File.WriteAllText(tempo1, pass1);
                        MessageBox.Show("Registrazione completata");
                        BoxUserR.Text = "";
                        BoxPassR.Text = "";
                        BoxPass2R.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Non è possibile registrarsi");
                    }

                }

            }
            else
            {
                MessageBox.Show("Nome utente o password sono errati");
                BoxPassR.Text = "";
                BoxPass2R.Text = "";
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
    }
}
