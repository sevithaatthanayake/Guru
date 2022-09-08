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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtg1s1.Text = Settings.Default["group1s1"].ToString();
            txtg1s2.Text = Settings.Default["group1s2"].ToString();
            txtg1s3.Text = Settings.Default["group1s3"].ToString();
            txtg1s4.Text = Settings.Default["group1s4"].ToString();

            txtg1sm1.Text = Settings.Default["group11"].ToString();
            txtg1sm2.Text = Settings.Default["group12"].ToString();
            txtg1sm3.Text = Settings.Default["group13"].ToString();
            txtg1sm4.Text = Settings.Default["group14"].ToString();

            txtg1sm5.Text = Settings.Default["group15"].ToString();
            txtg1sm6.Text = Settings.Default["group16"].ToString();
            txtg1sm7.Text = Settings.Default["group17"].ToString();
            txtg1sm8.Text = Settings.Default["group18"].ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings.Default["group1s1"] = txtg1s1.Text;
            Settings.Default["group1s2"] = txtg1s2.Text;
            Settings.Default["group1s3"] = txtg1s3.Text;
            Settings.Default["group1s4"] = txtg1s4.Text;

            Settings.Default["group11"] = txtg1sm1.Text;
            Settings.Default["group12"] = txtg1sm2.Text;
            Settings.Default["group13"] = txtg1sm3.Text;
            Settings.Default["group14"] = txtg1sm4.Text;

            Settings.Default["group15"] = txtg1sm5.Text;
            Settings.Default["group16"] = txtg1sm6.Text;
            Settings.Default["group17"] = txtg1sm7.Text;
            Settings.Default["group18"] = txtg1sm8.Text;

            Settings.Default.Save();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtg1sm1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtg1sm2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtg1sm3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtg1sm4.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtg1sm5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtg1sm6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtg1sm7.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtg1sm8.Text = "";
        }
    }
}
