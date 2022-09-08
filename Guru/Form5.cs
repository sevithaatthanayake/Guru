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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtlast1.Text = Settings.Default["last1"].ToString();
            txtlast2.Text = Settings.Default["last2"].ToString();
            txtlast3.Text = Settings.Default["last3"].ToString();
            txtlast4.Text = Settings.Default["last4"].ToString();
            txtlast5.Text = Settings.Default["last5"].ToString();

            txtlasts1.Text = Settings.Default["lasts1"].ToString();
            txtlasts2.Text = Settings.Default["lasts2"].ToString();
            txtlasts3.Text = Settings.Default["lasts3"].ToString();
            txtlasts4.Text = Settings.Default["lasts4"].ToString();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["last1"]= txtlast1.Text;
            Settings.Default["last2"] = txtlast2.Text;
            Settings.Default["last3"] = txtlast3.Text;
            Settings.Default["last4"] = txtlast4.Text;
            Settings.Default["last5"] = txtlast5.Text;

            Settings.Default["lasts1"] = txtlasts1.Text;
            Settings.Default["lasts2"] = txtlasts2.Text;
            Settings.Default["lasts3"] = txtlasts3.Text;
            Settings.Default["lasts4"] = txtlasts4.Text;

            Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlast4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtlast5.Text = "";
        }
    }
}
