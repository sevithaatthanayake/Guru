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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtsi1.Text = Settings.Default["private1"].ToString();
            txtsi2.Text = Settings.Default["private2"].ToString();
         
            txtsi4.Text = Settings.Default["private4"].ToString();
            txtsi5.Text = Settings.Default["private5"].ToString();
 

            txtsm11.Text = Settings.Default["data1"].ToString();
            txtsm12.Text = Settings.Default["data2"].ToString();
            txtsm21.Text = Settings.Default["data3"].ToString();
            txtsm22.Text = Settings.Default["data4"].ToString();
         
            txtsm41.Text = Settings.Default["data7"].ToString();
            txtsm42.Text = Settings.Default["data8"].ToString();
            txtsm51.Text = Settings.Default["data9"].ToString();
            txtsm52.Text = Settings.Default["data10"].ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtsm12.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsm11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["private1"] = txtsi1.Text;
            Settings.Default["private2"] = txtsi2.Text;
         
            Settings.Default["private4"] = txtsi4.Text;
            Settings.Default["private5"] = txtsi5.Text;
         
            Settings.Default["data1"] = txtsm11.Text;
            Settings.Default["data2"] = txtsm12.Text;
            Settings.Default["data3"] = txtsm21.Text;
            Settings.Default["data4"] = txtsm22.Text;
        
            Settings.Default["data7"] = txtsm41.Text;
            Settings.Default["data8"] = txtsm42.Text;
            Settings.Default["data9"] = txtsm51.Text;
            Settings.Default["data10"] = txtsm52.Text;


            Settings.Default.Save();

            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtsm21.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtsm22.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtsm41.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtsm42.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtsm51.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtsm52.Text = "";
        }
    }
}
