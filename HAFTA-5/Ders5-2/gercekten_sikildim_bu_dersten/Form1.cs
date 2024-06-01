using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gercekten_sikildim_bu_dersten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr2 = new StreamReader("123.txt");
            string satir1;
            string ad = "";
            string no = "";
            while((satir1 = sr2.ReadLine()) != null)
            {
                no = satir1.Substring(0, 11);
                ad = satir1.Substring(12);
                listBox1.Items.Add(ad + " "+ no);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr3 = new StreamReader("sinav.txt");
            string satir2;
            string ad = "";
            string vize = "";
            string final = "";
            while ((satir2 = sr3.ReadLine()) != null)
            {
                ad = satir2.Substring(6);
                final = satir2.Substring(3, 2);
                vize = satir2.Substring(0,2);
                int viz =Convert.ToInt32(final);
                int fin =Convert.ToInt32(vize);

                listBox2.Items.Add((viz+fin)/2 + " " + ad);
            }

        }
    }
}
