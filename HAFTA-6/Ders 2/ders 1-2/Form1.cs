using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ders_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih1 = dateTimePicker1.Value.Date;
            DateTime tarih2 = dateTimePicker2.Value.Date;

            DateTime kullanıcı = Convert.ToDateTime(textBox1.Text);
            if (kullanıcı < tarih1)

            {
                label1.Text = "1. Tarihten önce bir tarih";
            }
            else if (kullanıcı == tarih1)
            {
                label1.Text = "1. Tarihe Eşittir";
            }
            else if (kullanıcı > tarih1 && kullanıcı < tarih2)
            {
                label1.Text = "İki tarih arasındadır.";
            }
            else if (tarih2 == kullanıcı)
            {
                label1.Text = "2. Tarihe Eşittir";
            }
            else if (kullanıcı > tarih2)
            {
                label1.Text = "2. tarihten sonra bir tarih";
            }
        }
    }
}
