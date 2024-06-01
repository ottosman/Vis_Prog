using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nevşehir");
            comboBox1.Items.Add("Konya");
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ürgüp");
                listBox1.Items.Add("Avanos");
                listBox1.Items.Add("Göreme");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Meram");
                listBox1.Items.Add("Karatay");
                listBox1.Items.Add("Selçuk");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Keçiören");
                listBox1.Items.Add("Mamak");
                listBox1.Items.Add("Kızılay");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Fatih");
                listBox1.Items.Add("Bakırköy");
                listBox1.Items.Add("Beyoğlu");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "NEVŞEHİR") { 
                comboBox1.SelectedIndex = 0;
            }
            else if (textBox1.Text == "KONYA")
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (textBox1.Text == "ANKARA")
            {
                comboBox1.SelectedIndex = 2;
            }
            else if (textBox1.Text == "İSTANBUL")
            {
                comboBox1.SelectedIndex = 3;
            }

            //comboBox1.SelectedIndex = Convert.ToInt32(textBox1.Text);
        }
    }
}
