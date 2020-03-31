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


namespace AutenticationDisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pass;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string user1 = BoxName.Text;
            string pass1 = BoxPass.Text;
            string tempo1 = "C:\\App\\" + user1 + ".txt";
            if (File.Exists(tempo1))
            {
                pass = File.ReadAllText(tempo1);

                if (pass1.Equals(pass))
                {
                    MessageBox.Show("Login Eseguito");
                    //.... pagin = new ....();
                    //pagin.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Password non riconosciuta");

                }
            }
            else
            {
                MessageBox.Show("Nome utente o password non riconosciuti");
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
