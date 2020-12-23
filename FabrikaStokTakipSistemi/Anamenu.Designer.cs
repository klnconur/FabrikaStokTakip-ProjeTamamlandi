namespace FabrikaStokTakipSistemi
{
    partial class Anamenu
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
            this.stok = new System.Windows.Forms.Button();
            this.urun = new System.Windows.Forms.Button();
            this.islemkaydi = new System.Windows.Forms.Button();
            this.personelislemleri = new System.Windows.Forms.Button();
            this.kasa = new System.Windows.Forms.Button();
            this.otomatiksiparis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stok
            // 
            this.stok.Enabled = false;
            this.stok.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok.Location = new System.Drawing.Point(12, 35);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(155, 120);
            this.stok.TabIndex = 0;
            this.stok.Text = "Stok Giriş/Çıkış Listele";
            this.stok.UseVisualStyleBackColor = true;
            this.stok.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun
            // 
            this.urun.Enabled = false;
            this.urun.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun.Location = new System.Drawing.Point(173, 35);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(155, 120);
            this.urun.TabIndex = 0;
            this.urun.Text = "Ürün Ekle/Düzenle Listele";
            this.urun.UseVisualStyleBackColor = true;
            this.urun.Click += new System.EventHandler(this.urun_Click);
            // 
            // islemkaydi
            // 
            this.islemkaydi.Enabled = false;
            this.islemkaydi.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.islemkaydi.Location = new System.Drawing.Point(12, 192);
            this.islemkaydi.Name = "islemkaydi";
            this.islemkaydi.Size = new System.Drawing.Size(155, 120);
            this.islemkaydi.TabIndex = 0;
            this.islemkaydi.Text = "İşlem Kaydı";
            this.islemkaydi.UseVisualStyleBackColor = true;
            this.islemkaydi.Click += new System.EventHandler(this.islemkaydi_Click);
            // 
            // personelislemleri
            // 
            this.personelislemleri.Enabled = false;
            this.personelislemleri.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelislemleri.Location = new System.Drawing.Point(173, 192);
            this.personelislemleri.Name = "personelislemleri";
            this.personelislemleri.Size = new System.Drawing.Size(155, 120);
            this.personelislemleri.TabIndex = 0;
            this.personelislemleri.Text = "Personel İşlemleri";
            this.personelislemleri.UseVisualStyleBackColor = true;
            this.personelislemleri.Click += new System.EventHandler(this.personelislemleri_Click);
            // 
            // kasa
            // 
            this.kasa.Enabled = false;
            this.kasa.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasa.Location = new System.Drawing.Point(334, 192);
            this.kasa.Name = "kasa";
            this.kasa.Size = new System.Drawing.Size(155, 120);
            this.kasa.TabIndex = 0;
            this.kasa.Text = "Kasa";
            this.kasa.UseVisualStyleBackColor = true;
            this.kasa.Click += new System.EventHandler(this.kasa_Click);
            // 
            // otomatiksiparis
            // 
            this.otomatiksiparis.Enabled = false;
            this.otomatiksiparis.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otomatiksiparis.Location = new System.Drawing.Point(334, 35);
            this.otomatiksiparis.Name = "otomatiksiparis";
            this.otomatiksiparis.Size = new System.Drawing.Size(155, 120);
            this.otomatiksiparis.TabIndex = 0;
            this.otomatiksiparis.Text = "Otomatik Sipariş Sistemi";
            this.otomatiksiparis.UseVisualStyleBackColor = true;
            this.otomatiksiparis.Click += new System.EventHandler(this.otomatiksiparis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "----Sadece Yönetici---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "---Personel İşlemleri---";
            // 
            // Anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otomatiksiparis);
            this.Controls.Add(this.kasa);
            this.Controls.Add(this.personelislemleri);
            this.Controls.Add(this.islemkaydi);
            this.Controls.Add(this.urun);
            this.Controls.Add(this.stok);
            this.Name = "Anamenu";
            this.Text = "Fabrika Stok Takip Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anamenu_FormClosing);
            this.Load += new System.EventHandler(this.Anamenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stok;
        private System.Windows.Forms.Button urun;
        private System.Windows.Forms.Button islemkaydi;
        private System.Windows.Forms.Button personelislemleri;
        private System.Windows.Forms.Button kasa;
        private System.Windows.Forms.Button otomatiksiparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}