using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach( Control c in this.Controls)
            {
                if( c is ComboBox )
                {
                    (c as ComboBox).Items.Clear();
                    (c as ComboBox).Items.Add("Textbox");
                    (c as ComboBox).Items.Add("Button");
                    (c as ComboBox).Items.Add("Listbox");
                    (c as ComboBox).Items.Add("Label");
                    
                }
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            int counter = 0;
            string renokango2012 = "";

            foreach ( Control ikinciel in this.Controls)
            {
                if( ikinciel is ComboBox )
                {
                    renokango2012 = (ikinciel as ComboBox).Text;
                }
            }


            foreach (Control item0 in this.Controls)
            {
                if( item0 is GroupBox)
                {
                    foreach (Control item2 in item0.Controls)
                    {
                        if (( item2 is TextBox) && (renokango2012 == "Textbox"))
                        {
                            counter++;
                            label7.Text = counter.ToString();
                        }
                        else if ((item2 is Button) && (renokango2012 == "Button"))
                        {
                            counter++;
                            label7.Text = counter.ToString();
                        }
                        else if ((item2 is ListBox) && (renokango2012 == "Listbox"))
                        {
                            counter++;
                            label7.Text = counter.ToString();
                        }
                        else if ((item2 is Label) && (renokango2012 == "Label"))
                        {
                            counter++;
                            label7.Text = counter.ToString();
                        }
                    }

                }
            }

        }
    }
}
