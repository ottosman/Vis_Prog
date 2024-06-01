using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace GorselProgramlama1
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        Queue kuyruk = new Queue();
        int sayacKuyruk = 0;
        Stack yigin = new Stack();
        int sayacYigin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nevþehir");
            comboBox1.Items.Add("Konya");
            comboBox1.Items.Add("Ýstanbul");
            comboBox1.Items.Add("Aðrý");

            comboBox2.Items.Add("Toplama");
            comboBox2.Items.Add("Çýkarma");
            comboBox2.Items.Add("Çarpma");
            comboBox2.Items.Add("Bölme");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(sayac);
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public void ListeleKuyruk()
        {
            listBox2.Items.Clear();
            foreach (int item in kuyruk)
            {
                listBox2.Items.Add(item);

            }
        }

        public void ListeleYigin()
        {
            listBox3.Items.Clear();
            foreach (int item in yigin)
            {
                listBox3.Items.Add(item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayacKuyruk++;
            kuyruk.Enqueue(sayacKuyruk);
            ListeleKuyruk();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = kuyruk.Dequeue();
            ListeleKuyruk();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayacYigin++;
            yigin.Push(sayacYigin);
            ListeleYigin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var a = yigin.Pop();
            ListeleYigin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Control Gbox1 = ((Button)sender).Parent;
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;

                    foreach (Control control2 in groupBox.Controls)
                    {
                        if (control2 is TextBox && control2.Parent == Gbox1 && control2.TabIndex % 2 == 0)
                        {
                            // TextBox textBox = (TextBox)control2;
                            // textBox.Clear();
                            (control2 as TextBox).Clear();
                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Ürgüp");
                listBox4.Items.Add("Avanos");
                listBox4.Items.Add("Göreme");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Meram");
                listBox4.Items.Add("Karatay");
                listBox4.Items.Add("Selçuk");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Bakýrköy");
                listBox4.Items.Add("Kadýköy");
                listBox4.Items.Add("Pendik");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Doðubeyazýt");
                listBox4.Items.Add("Diyadin");
                listBox4.Items.Add("Patnos");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //// HOCANIN YAPTIÐI
            //comboBox1.SelectedIndex = Convert.ToInt32(textBox4.Text);

            // BENÝM YAPTIÐIM
            string metin = textBox4.Text;
            if (metin == "Nevþehir")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (metin == "Konya")
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (metin == "Ýstanbul")
            {
                comboBox1.SelectedIndex = 2;
            }
            else if (metin == "Aðrý")
            {
                comboBox1.SelectedIndex = 3;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox5.Text);
            double sayi2 = Convert.ToDouble(textBox6.Text);
            double sonuc = 0;

            if (comboBox2.SelectedIndex == 0)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                if (sayi2 == 0)
                {
                    MessageBox.Show("Sayý sýfýra bölünemez!");
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
            }

            label1.Text = sonuc.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("book1.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read:");
                MessageBox.Show(e.Message);
            }*/

            StreamReader st = new StreamReader("book1.txt");
            string satir;

            while ((satir = st.ReadLine()) != null)
            {
                listBox5.Items.Add(satir);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string kelime = Convert.ToString(textBox7.Text);
            bool varmi = false;

            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                if (listBox5.Items[i].ToString().Contains(kelime))
                {
                    varmi = true;
                    break;
                }
            }

            if (varmi)
            {
                label2.Text = "Var";
            }
            else
            {
                label2.Text = "Yok";
            }

            /*listBox5.Items.Clear();
            int kontrol = 0;

            StreamReader st = new StreamReader("book1.txt");
            string satir;

            while ((satir = st.ReadLine()) != null)
            {
                listBox5.Items.Add(satir);
                if (satir.Contains(textBox7.Text))
                {
                    kontrol = 1;
                }
            }

            if(kontrol == 1)
            {
                label2.Text = "Var";
            }
            else
            {
                label2.Text = "Yok";
            }*/
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*StreamReader st = new StreamReader("book1.txt");
            string satir;

            while ((satir = st.ReadLine()) != null)
            {
                foreach(char karakter in satir)
                {
                    listBox5.Items.Add(karakter);
                }
            }*/

            // BENÝM
            FileStream fs = new FileStream("book1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            int karakter;

            while ((karakter = sw.Read()) != -1)
            {
                listBox5.Items.Add((char)karakter);
            }

            fs.Close();
            sw.Close();

            //HOCANIN
            /*var fs = new FileStream("book1.txt", FileMode.Open);

            for (int i = 0; i < fs.Length; i++)
            {
                listBox5.Items.Add((char)fs.ReadByte());
                fs.Close();
            }*/

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("book1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            int karakter;
            int karakterSayisi = 0;

            while ((karakter = sw.Read()) != -1)
            {
                listBox5.Items.Add((char)karakter);
                karakterSayisi++;
            }

            MessageBox.Show("Karakter sayýsý: " + karakterSayisi);

            fs.Close();
            sw.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            StreamReader st = new StreamReader("book1.txt");
            string satir;
            string alinanIsým = Convert.ToString(textBox8.Text.Trim());

            while ((satir = st.ReadLine()) != null)
            {
                satir = satir.Trim();
                string isim = satir.Substring(0, alinanIsým.Length).Trim();

                if(isim.Equals(alinanIsým))
                {
                    string numara = satir.Substring(alinanIsým.Length).Trim();
                    MessageBox.Show(numara);
                    break;
                }
            }
            st.Close();
        }
    }
}
