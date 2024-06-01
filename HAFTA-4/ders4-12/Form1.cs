using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders4_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oku_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:\\Users\\Osdijum\\Desktop\\123.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {

                        Console.WriteLine(line);
                        listBox1.Items.Add(line);

                    }
                }
            }
            catch (Exception a)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(a.Message);
            }
        }

        private void varmı_button_Click(object sender, EventArgs e)
        {
            string metin2 = textBox1.Text;
            bool flag = false;

            foreach (string test in listBox1.Items)
            {
                //string[] words = test.Split(' ');

                if (test.Contains(metin2))
                {
                    //label1.Text = "VAR";
                    flag = true;

                }
            }
            if (flag == true)
            {
                label1.Text = "VAR";
            }
            else
            {
                label1.Text = "YOK";
            }


        }

        private void ch_button_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                /*using (StreamReader sr = new StreamReader("oku.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.

                    while ((line = sr.ReadLine()) != null)
                    {

                        Console.WriteLine(line);
                        listBox1.Items.Add(line);

                    }
                }*/
                using (FileStream fr = File.OpenRead("123.txt"))
                {
                    while (fr.Position < fr.Length)
                    {
                        listBox1.Items.Add((char)fr.ReadByte());
                    }
                }
            }
            catch (Exception a)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(a.Message);
            }


        }

        private void ch_oku_hoca_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var fs = new FileStream("123.txt", FileMode.Open);
            
            for ( int i = 0; i < fs.Length; i++ )
            {
                listBox1.Items.Add((char)(fs.ReadByte()));
            }
            fs.Close();
        }
    }
}
