using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_sonrasi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekrana_getir_1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "col1";
            dataGridView1.Columns[1].Name = "col2";
            dataGridView1.Columns[1].Name = "col3";

            dataGridView1.Rows.Add("Umut", "Yusa", "Osman");
            dataGridView1.Rows.Add("12", "21", "93");
            dataGridView1.Rows.Add("4", "53", "66");
            dataGridView1.Rows.Add("44", "85", "26");

            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void indeks_not_Click(object sender, EventArgs e)
        {
            //BURAYA 1,2,3 DEĞERLERİ HARİCİNDE YAZAMAN PAŞAM

            int which_row = Convert.ToInt32(textBox1.Text); 
            int birinci = Convert.ToInt32(dataGridView1.Rows[which_row].Cells[0].Value);
            int ikinci = Convert.ToInt32(dataGridView1.Rows[which_row].Cells[1].Value);
            int ucuncu = Convert.ToInt32(dataGridView1.Rows[which_row].Cells[2].Value);

            label2.Text = Convert.ToString(birinci + ikinci + ucuncu);
        }

        DataTable tbl = new DataTable();

        private void ekrana_getir_2_Click(object sender, EventArgs e)
        {
            tbl.Columns.Add("Ders", typeof(string));
            tbl.Columns.Add("Vize", typeof(int));
            tbl.Columns.Add("Final", typeof(int));
            tbl.Columns.Add("Ortalama", typeof(double));

            tbl.Rows.Add("Mikro", "56", "56");
            tbl.Rows.Add("Görsel", "50", "60");
            tbl.Rows.Add("Yazilim", "70", "80");
            tbl.Rows.Add("Web", "40", "65");
            tbl.Rows.Add("Ayrık", "65", "60");
            tbl.Rows.Add("Otomata", "75", "70");

            dataGridView2.DataSource = tbl;

            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void ekle_Click(object sender, EventArgs e)
        {   if(textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                tbl.Rows.Add(textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), 0.0 );
                dataGridView2.DataSource= tbl;
            }
            
            else
            {
                MessageBox.Show("PASAM TEXTBOX BOS");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }

            else
            {
                MessageBox.Show("SATIR SEC PASAM");
            }

            dataGridView2.DataSource = tbl;
        }

        private void ortalama_Click(object sender, EventArgs e)
        { /*
           //BURASI NORMAL ÇÖZÜM 

            if (dataGridView2.SelectedRows.Count > 0) 
            {
                int average_row = dataGridView2.SelectedRows[0].Index;
                int vize = Convert.ToInt32(tbl.Rows[average_row][1]);
                int final = Convert.ToInt32(tbl.Rows[average_row][2]);
                
                double ort = Convert.ToDouble(vize) * 0.4 + Convert.ToDouble(final) * 0.6;
                tbl.Rows[average_row][3] = ort;
            }

            dataGridView2.DataSource = tbl;
            */

            //foreach ile yazmaya çalışacağım inşallah (kendrick > drake)

            Control gbox1 = ((Button)sender).Parent;
            foreach( Control item1 in this.Controls)
            {
                if ( item1 is GroupBox)
                {
                    foreach( Control item2 in item1.Controls)
                    {
                        if ((item2 is DataGridView) && (item2.Parent == gbox1))
                        {
                            int avgrow = (item2 as DataGridView).SelectedRows[0].Index;
                            int vize = Convert.ToInt32(tbl.Rows[avgrow][1]);
                            int final = Convert.ToInt32(tbl.Rows[avgrow][2]);

                            double ort = Convert.ToDouble(vize) * 0.4 + Convert.ToDouble(final) * 0.6;
                            tbl.Rows[avgrow][3] = ort;
                        }
                    }
                }
            }

            dataGridView2.DataSource = tbl;

        }

        private void tot_ort_Click(object sender, EventArgs e)
        {
            int satirs = dataGridView2.RowCount;
            int vize2 = 0;
            int final2 = 0;

            for (int i = 0; i < satirs - 1; i++)
            {
                vize2 = Convert.ToInt32(tbl.Rows[i][1]);
                final2 = Convert.ToInt32(tbl.Rows[i][2]);

                tbl.Rows[i][3] = Convert.ToDouble(vize2) * 0.4 + Convert.ToDouble(final2) * 0.6;
            }

            dataGridView2.DataSource= tbl;
        }

        private void sırala_Click(object sender, EventArgs e)
        {
            tbl = sortet(tbl, "Ortalama", "DESC");
            dataGridView2.DataSource = tbl;
        }

        public static DataTable sortet( DataTable dt, string sutun, string yon)
        {
            dt.DefaultView.Sort = sutun + " " + yon;
            dt = dt.DefaultView.ToTable();
            return dt;
        }



        //FORM GECİS  
        //02/06/2024 RMA 2 - 0 BVB
        //ANCELOTTI ARDAYI OYNATMADI
        // CARVAJAL VE VİNİŞYUS GOL ATTI
        // KROOS MUTLU, REUS ÜZGÜN
        // BU NOTTAN FAYDALANDIYSAN PERŞEMBE GÜNÜ İÇİN HAKKIMDA HAYIRLI DUA ET (LAZIM)
        
        private void form_gec_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.sehir = form_gecis_textbox.Text;


            Form1 frm1 = new Form1();
            frm2.frm1 = this;

            this.Hide();
            frm2.Show();
        }
    }
}
