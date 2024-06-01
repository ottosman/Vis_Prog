using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace ders2_2
{
    public partial class Form1 : Form
    {
        int counter = 0; 
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control Gbox1 = ((Button)sender).Parent;
            temizle(Gbox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Control Gbox1 = ((Button)sender).Parent;
            temizle_cift(Gbox1);
        }

        void temizle(Control Gbox1)
        {

            foreach(Control item in this.Controls)
            {
                if(item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if ((item2 is TextBox) && (item2.Parent == Gbox1) && (item2.TabIndex % 2 != 0)) //Tab indeksi tek olanları temizle
                         {
                            
                            (item2 as TextBox).Clear();

                            
                         }

                        
                    }

                }

            }
        }
        void temizle_cift(Control Gbox1)
        {

            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if ((item2 is TextBox) && (item2.Parent == Gbox1) && (item2.TabIndex % 2 == 0)) //Tab indeksi ÇİFT olanları temizle
                        {

                            (item2 as TextBox).Clear();


                        }


                    }

                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Control Gbox3 = ((Button)sender).Parent;
            
            
            foreach(Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach( Control item2 in item.Controls)
                    {
                        if ((item2 is TextBox) && (item2.Parent == Gbox3) && ((item2 as TextBox).Text.Length > 0))
                        {
                            (item2 as TextBox).Clear();
                            counter++;

                            foreach(Control item3 in item.Controls)
                            {
                                if ((item3 is Label) && (item3.Parent == Gbox3) )
                                {
                                    
                                    (item3 as Label).Text = counter.ToString();
                                    
                                }
                                
                            }
                            
                        }
                    }


                }
            }

        }
    }
}
