using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guru.Properties;

namespace Guru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2021");
                if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Application Expired .. Contact Developer For An Update");
            }
        
            else
           {
                Form2 qw = new Form2();
                qw.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings.Default["home1"] = richTextBox2.Text;
            Settings.Default["home2"] = richTextBox1.Text;
            Settings.Default["teacher"] = textBox1.Text;
    
            Settings.Default.Save();
        }
        
        private void button3_Click(object sender, EventArgs e)
      {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2021");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Application Expired .. Contact Developer For An Update");
            }
            else
            {
                Form3 jk = new Form3();
                jk.Show();
            }
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = Settings.Default["home1"].ToString();
            richTextBox1.Text = Settings.Default["home2"].ToString();
            textBox1.Text = Settings.Default["teacher"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2021");
            if (dt1.Date > dt2.Date)
            {
               MessageBox.Show("Application Expired .. Contact Developer For An Update");
            }
            else
            {
                Form4 kl = new Form4();
               kl.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2021");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Application Expired .. Contact Developer For An Update");
            }

            else
           { Form5 kk = new Form5();
               kk.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 ll = new Form6();
            ll.Show();
        }
    }
}
