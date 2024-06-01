using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime zaman1 = dateTimePicker1.Value;
            //label1.Text = zaman1.ToString();
            label1.Text = dateTimePicker1.Value.ToString(); //ikinci versiyon
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            DateTime ilkzaman = dateTimePicker2.Value;
            DateTime sonzaman = dateTimePicker3.Value;

            TimeSpan zaman_saplagi = (sonzaman - ilkzaman);
            label2.Text = ((int)zaman_saplagi.TotalDays).ToString();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime first = dateTimePicker4.Value;
            DateTime second = dateTimePicker5.Value;

            //DateTime fazlasayi = Convert.ToDateTime(textBox1.Text);
            int artansayi = Convert.ToInt32(textBox1.Text);

            DateTime yenitarih = second.AddDays(artansayi);
            
            dateTimePicker5.Text = yenitarih.ToString();
            label3.Text = yenitarih.ToString();

        }
    }
}
