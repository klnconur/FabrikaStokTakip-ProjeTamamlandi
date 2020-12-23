namespace FabrikaStokTakipSistemi
{
    partial class OtomatikSiparis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stokMiktari = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunCb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stokMiktari);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(37, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Giriş/Çıkış";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // urunCb
            // 
            this.urunCb.FormattingEnabled = true;
            this.urunCb.Location = new System.Drawing.Point(107, 24);
            this.urunCb.Name = "urunCb";
            this.urunCb.Size = new System.Drawing.Size(190, 21);
            this.urunCb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Depo ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asgari Stok Miktarı";
            // 
            // stokMiktari
            // 
            this.stokMiktari.Location = new System.Drawing.Point(107, 51);
            this.stokMiktari.Name = "stokMiktari";
            this.stokMiktari.Size = new System.Drawing.Size(190, 20);
            this.stokMiktari.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Asgari Stok Miktarını Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OtomatikSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 188);
            this.Controls.Add(this.groupBox1);
            this.Name = "OtomatikSiparis";
            this.Text = "Otomatik Sipariş Sistemi";
            this.Load += new System.EventHandler(this.OtomatikSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox urunCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stokMiktari;
        private System.Windows.Forms.Button button2;
    }
}