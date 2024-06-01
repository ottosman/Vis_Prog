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

namespace ders4
{
    public partial class Form1 : Form
    {
        //StreamReader sr = new StreamReader("dosya.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader("ders4-need.txt");
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();

            listBox1.Items.Clear();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("ders4-need.txt"))
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
    }
}
