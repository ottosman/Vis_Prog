using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


            foreach (Control item0 in this.Controls)
            {
                if (item0 is ComboBox)
                {
                    (item0 as ComboBox).Items.Clear();
                    (item0 as ComboBox).Items.Add("+");
                    (item0 as ComboBox).Items.Add("-");
                    (item0 as ComboBox).Items.Add("*");
                    (item0 as ComboBox).Items.Add("/");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1 = 0;
            int say2 = 0;
            int tot1 = 0;
            string ids = "";
            Control Gbox1 = ((Button)sender).Parent;

            
          

            ////////////////////////////////////////////////////////////

            foreach(Control item1 in this.Controls)
            {
                if (item1 is GroupBox)
                {
                    foreach (Control item2 in item1.Controls)
                    {
                        if ((item2 is TextBox) && (item2.Parent == Gbox1) && (item2.TabIndex == 21))
                        {
                            say1 = Convert.ToInt32((item2 as TextBox).Text);
                            Console.WriteLine(say1);
                        }
                        else if ((item2 is TextBox) && (item2.Parent == Gbox1) && (item2.TabIndex == 31))
                        {
                            say2 = Convert.ToInt32((item2 as TextBox).Text);
                            Console.WriteLine(say2);
                        }
                    }
                   

                }
            }

            ///////////////////
            foreach (Control item4 in this.Controls)
            {
                if (item4 is ComboBox)
                {
                    ids = (item4 as ComboBox).Text;
                    if (ids == "+")
                    {
                        tot1 = say1 + say2;


                    }else if (ids == "-")
                    {
                        tot1 = say1 - say2;

                    }
                    else if (ids == "*")
                    {
                        tot1 = say1 * say2;

                    }
                    else if (ids == "/")
                    {
                        tot1 = say1 / say2;

                    }




                }

                ///////////////////////
                foreach(Control item5 in this.Controls)
                {
                    if ( item5 is GroupBox)
                    {
                        foreach(Control item6 in item5.Controls) 
                        {
                            if(item6 is Label)
                            {
                                (item6 as Label).Text = Convert.ToString(tot1);
                            }
                        }
                        
                    }
                }
            }


        }
    }
}
