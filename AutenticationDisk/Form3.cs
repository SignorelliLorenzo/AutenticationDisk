using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutenticationDisk
{
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();
        }

        private void INFO_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("http:"+scheda_database.test[scheda_database.variable].immage);
            label1.Text = scheda_database.test[scheda_database.variable].trama;
        }

        private void INFO_Leave(object sender, EventArgs e)
        {
            scheda_database pagin = new scheda_database();
            pagin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            scheda_database dbopen = new scheda_database();
            dbopen.Show();
        }
    }
}
