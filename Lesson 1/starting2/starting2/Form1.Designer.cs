namespace starting2
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
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(135, 90);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(100, 20);
            this.giris.TabIndex = 0;
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(135, 129);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(100, 20);
            this.cikis.TabIndex = 1;
            // 
            // yap
            // 
            this.yap.Location = new System.Drawing.Point(135, 166);
            this.yap.Name = "yap";
            this.yap.Size = new System.Drawing.Size(75, 23);
            this.yap.TabIndex = 2;
            this.yap.Text = "YAP";
            this.yap.UseVisualStyleBackColor = true;
            this.yap.Click += new System.EventHandler(this.yap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(252, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

