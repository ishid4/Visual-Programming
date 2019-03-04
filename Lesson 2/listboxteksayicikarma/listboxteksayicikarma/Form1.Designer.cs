namespace listboxteksayicikarma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.giris = new System.Windows.Forms.TextBox();
            this.cikis = new System.Windows.Forms.TextBox();
            this.yap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yap2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.yap3 = new System.Windows.Forms.Button();
            this.yap4 = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(45, 28);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(100, 20);
            this.giris.TabIndex = 0;
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(45, 66);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(100, 20);
            this.cikis.TabIndex = 1;
            // 
            // yap
            // 
            this.yap.Location = new System.Drawing.Point(55, 92);
            this.yap.Name = "yap";
            this.yap.Size = new System.Drawing.Size(75, 23);
            this.yap.TabIndex = 2;
            this.yap.Text = "ÜRET";
            this.yap.UseVisualStyleBackColor = true;
            this.yap.Click += new System.EventHandler(this.yap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(100, 186);
            this.listBox1.TabIndex = 3;
            // 
            // yap2
            // 
            this.yap2.Location = new System.Drawing.Point(151, 204);
            this.yap2.Name = "yap2";
            this.yap2.Size = new System.Drawing.Size(75, 42);
            this.yap2.TabIndex = 4;
            this.yap2.Text = "SEÇİLİ ÜRET";
            this.yap2.UseVisualStyleBackColor = true;
            this.yap2.Click += new System.EventHandler(this.yap2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(232, 138);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(100, 186);
            this.listBox2.TabIndex = 5;
            // 
            // yap3
            // 
            this.yap3.Location = new System.Drawing.Point(232, 73);
            this.yap3.Name = "yap3";
            this.yap3.Size = new System.Drawing.Size(100, 42);
            this.yap3.TabIndex = 6;
            this.yap3.Text = "TEK SAYILARI ÇIKAR";
            this.yap3.UseVisualStyleBackColor = true;
            this.yap3.Click += new System.EventHandler(this.yap3_Click);
            // 
            // yap4
            // 
            this.yap4.Location = new System.Drawing.Point(338, 161);
            this.yap4.Name = "yap4";
            this.yap4.Size = new System.Drawing.Size(100, 42);
            this.yap4.TabIndex = 7;
            this.yap4.Text = "TOPLAM";
            this.yap4.UseVisualStyleBackColor = true;
            this.yap4.Click += new System.EventHandler(this.yap4_Click);
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(338, 216);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(100, 20);
            this.sonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.yap4);
            this.Controls.Add(this.yap3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.yap2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.yap);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox giris;
        private System.Windows.Forms.TextBox cikis;
        private System.Windows.Forms.Button yap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button yap2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button yap3;
        private System.Windows.Forms.Button yap4;
        private System.Windows.Forms.TextBox sonuc;
    }
}

