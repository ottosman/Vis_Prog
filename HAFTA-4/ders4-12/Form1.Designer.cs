namespace ders4_12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.oku_button = new System.Windows.Forms.Button();
            this.varmı_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ch_button = new System.Windows.Forms.Button();
            this.ch_oku_hoca_button = new System.Windows.Forms.Button();
            this.ch_kac_tane_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(229, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 290);
            this.listBox1.TabIndex = 0;
            // 
            // oku_button
            // 
            this.oku_button.Location = new System.Drawing.Point(27, 80);
            this.oku_button.Name = "oku_button";
            this.oku_button.Size = new System.Drawing.Size(75, 23);
            this.oku_button.TabIndex = 1;
            this.oku_button.Text = "oku";
            this.oku_button.UseVisualStyleBackColor = true;
            this.oku_button.Click += new System.EventHandler(this.oku_button_Click);
            // 
            // varmı_button
            // 
            this.varmı_button.Location = new System.Drawing.Point(27, 175);
            this.varmı_button.Name = "varmı_button";
            this.varmı_button.Size = new System.Drawing.Size(75, 23);
            this.varmı_button.TabIndex = 2;
            this.varmı_button.Text = "var mı?";
            this.varmı_button.UseVisualStyleBackColor = true;
            this.varmı_button.Click += new System.EventHandler(this.varmı_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ch_button
            // 
            this.ch_button.Location = new System.Drawing.Point(130, 38);
            this.ch_button.Name = "ch_button";
            this.ch_button.Size = new System.Drawing.Size(93, 23);
            this.ch_button.TabIndex = 5;
            this.ch_button.Text = "ch_oku";
            this.ch_button.UseVisualStyleBackColor = true;
            this.ch_button.Click += new System.EventHandler(this.ch_button_Click);
            // 
            // ch_oku_hoca_button
            // 
            this.ch_oku_hoca_button.Location = new System.Drawing.Point(130, 80);
            this.ch_oku_hoca_button.Name = "ch_oku_hoca_button";
            this.ch_oku_hoca_button.Size = new System.Drawing.Size(93, 23);
            this.ch_oku_hoca_button.TabIndex = 6;
            this.ch_oku_hoca_button.Text = "ch_oku_hoca";
            this.ch_oku_hoca_button.UseVisualStyleBackColor = true;
            this.ch_oku_hoca_button.Click += new System.EventHandler(this.ch_oku_hoca_button_Click);
            // 
            // ch_kac_tane_button
            // 
            this.ch_kac_tane_button.Location = new System.Drawing.Point(688, 257);
            this.ch_kac_tane_button.Name = "ch_kac_tane_button";
            this.ch_kac_tane_button.Size = new System.Drawing.Size(75, 23);
            this.ch_kac_tane_button.TabIndex = 7;
            this.ch_kac_tane_button.Text = "ch_kac_tane";
            this.ch_kac_tane_button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ch_kac_tane_button);
            this.Controls.Add(this.ch_oku_hoca_button);
            this.Controls.Add(this.ch_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varmı_button);
            this.Controls.Add(this.oku_button);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button oku_button;
        private System.Windows.Forms.Button varmı_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ch_button;
        private System.Windows.Forms.Button ch_oku_hoca_button;
        private System.Windows.Forms.Button ch_kac_tane_button;
        private System.Windows.Forms.TextBox textBox2;
    }
}

