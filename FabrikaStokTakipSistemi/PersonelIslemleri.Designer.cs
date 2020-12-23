namespace FabrikaStokTakipSistemi
{
    partial class PersonelIslemleri
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
            this.personelTablo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TC_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ad_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Soyad_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sifre_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Telefon_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Adres_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adres2_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tel2_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sifre2_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.soyad2_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tct2_tb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ad2_tb = new System.Windows.Forms.TextBox();
            this.unvancb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // personelTablo
            // 
            this.personelTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personelTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelTablo.Location = new System.Drawing.Point(12, 41);
            this.personelTablo.Name = "personelTablo";
            this.personelTablo.Size = new System.Drawing.Size(535, 315);
            this.personelTablo.TabIndex = 0;
            this.personelTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelTablo_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel TC";
            // 
            // TC_tb
            // 
            this.TC_tb.Enabled = false;
            this.TC_tb.Location = new System.Drawing.Point(20, 44);
            this.TC_tb.Name = "TC_tb";
            this.TC_tb.Size = new System.Drawing.Size(100, 20);
            this.TC_tb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad";
            // 
            // Ad_tb
            // 
            this.Ad_tb.Location = new System.Drawing.Point(20, 89);
            this.Ad_tb.Name = "Ad_tb";
            this.Ad_tb.Size = new System.Drawing.Size(100, 20);
            this.Ad_tb.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Adres_tb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Telefon_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Sifre_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Soyad_tb);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TC_tb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Ad_tb);
            this.groupBox1.Location = new System.Drawing.Point(556, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 353);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgisi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad";
            // 
            // Soyad_tb
            // 
            this.Soyad_tb.Location = new System.Drawing.Point(21, 128);
            this.Soyad_tb.Name = "Soyad_tb";
            this.Soyad_tb.Size = new System.Drawing.Size(100, 20);
            this.Soyad_tb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre";
            // 
            // Sifre_tb
            // 
            this.Sifre_tb.Location = new System.Drawing.Point(20, 170);
            this.Sifre_tb.Name = "Sifre_tb";
            this.Sifre_tb.Size = new System.Drawing.Size(100, 20);
            this.Sifre_tb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon";
            // 
            // Telefon_tb
            // 
            this.Telefon_tb.Location = new System.Drawing.Point(18, 214);
            this.Telefon_tb.Name = "Telefon_tb";
            this.Telefon_tb.Size = new System.Drawing.Size(100, 20);
            this.Telefon_tb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adres";
            // 
            // Adres_tb
            // 
            this.Adres_tb.Location = new System.Drawing.Point(21, 259);
            this.Adres_tb.Name = "Adres_tb";
            this.Adres_tb.Size = new System.Drawing.Size(100, 20);
            this.Adres_tb.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.unvancb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.adres2_tb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tel2_tb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sifre2_tb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.soyad2_tb);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tct2_tb);
            this.groupBox2.Controls.Add(this.ad2_tb);
            this.groupBox2.Location = new System.Drawing.Point(17, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 131);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgisi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Adres";
            // 
            // adres2_tb
            // 
            this.adres2_tb.Location = new System.Drawing.Point(240, 84);
            this.adres2_tb.Name = "adres2_tb";
            this.adres2_tb.Size = new System.Drawing.Size(100, 20);
            this.adres2_tb.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Telefon";
            // 
            // tel2_tb
            // 
            this.tel2_tb.Location = new System.Drawing.Point(237, 39);
            this.tel2_tb.Name = "tel2_tb";
            this.tel2_tb.Size = new System.Drawing.Size(100, 20);
            this.tel2_tb.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Şifre";
            // 
            // sifre2_tb
            // 
            this.sifre2_tb.Location = new System.Drawing.Point(20, 84);
            this.sifre2_tb.Name = "sifre2_tb";
            this.sifre2_tb.Size = new System.Drawing.Size(100, 20);
            this.sifre2_tb.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Soyad";
            // 
            // soyad2_tb
            // 
            this.soyad2_tb.Location = new System.Drawing.Point(129, 84);
            this.soyad2_tb.Name = "soyad2_tb";
            this.soyad2_tb.Size = new System.Drawing.Size(100, 20);
            this.soyad2_tb.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "TC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ad";
            // 
            // tct2_tb
            // 
            this.tct2_tb.Location = new System.Drawing.Point(20, 44);
            this.tct2_tb.Name = "tct2_tb";
            this.tct2_tb.Size = new System.Drawing.Size(100, 20);
            this.tct2_tb.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "Kayıt Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ad2_tb
            // 
            this.ad2_tb.Location = new System.Drawing.Point(126, 44);
            this.ad2_tb.Name = "ad2_tb";
            this.ad2_tb.Size = new System.Drawing.Size(100, 20);
            this.ad2_tb.TabIndex = 6;
            // 
            // unvancb
            // 
            this.unvancb.FormattingEnabled = true;
            this.unvancb.Items.AddRange(new object[] {
            "Personel",
            "Yonetici"});
            this.unvancb.Location = new System.Drawing.Point(347, 38);
            this.unvancb.Name = "unvancb";
            this.unvancb.Size = new System.Drawing.Size(121, 21);
            this.unvancb.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(344, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ünvan";
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.personelTablo);
            this.Name = "PersonelIslemleri";
            this.Text = "PersonelIslemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelTablo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personelTablo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TC_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ad_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Adres_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Telefon_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sifre_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Soyad_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox unvancb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adres2_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tel2_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sifre2_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox soyad2_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tct2_tb;
        private System.Windows.Forms.TextBox ad2_tb;
    }
}