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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtindisi1.Text = Settings.Default["individual1"].ToString();
            txtindisi1.Text = Settings.Default["individual2"].ToString();
            txtindisi1.Text = Settings.Default["individual3"].ToString();
            txtindisi1.Text = Settings.Default["individual4"].ToString();

            txtindism11.Text = Settings.Default["indidata1"].ToString();
            txtindism12.Text = Settings.Default["indidata2"].ToString();
            txtindism21.Text = Settings.Default["indidata3"].ToString();
            txtindism22.Text = Settings.Default["indidata4"].ToString();

            txtindism31.Text = Settings.Default["indidata5"].ToString();
            txtindism32.Text = Settings.Default["indidata6"].ToString();
            txtindism41.Text = Settings.Default["indidata7"].ToString();
            txtindism42.Text = Settings.Default["indidata8"].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings.Default["individual1"] = txtindisi1.Text;
            Settings.Default["individual2"]=  txtindisi2.Text;
            Settings.Default["individual3"] = txtindisi3.Text;
            Settings.Default["individual4"] = txtindisi4.Text;

            Settings.Default["indidata1"] = txtindism11.Text;
            Settings.Default["indidata2"] = txtindism12.Text;
            Settings.Default["indidata3"] = txtindism21.Text;
            Settings.Default["indidata4"] = txtindism22.Text;

            Settings.Default["indidata5"] = txtindism31.Text;
            Settings.Default["indicate6"] = txtindism32.Text;
            Settings.Default["indicate7"] = txtindism41.Text;
            Settings.Default["indicate8"] = txtindism42.Text;

            Settings.Default.Save();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtindism11.Text = "";
      
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtindism12.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtindism21.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtindism22.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtindism31.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtindism32.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtindism41.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            txtindism42.Text = "";
        }
    }
}
