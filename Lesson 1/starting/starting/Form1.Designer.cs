namespace starting
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
            this.input = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bdıv = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(48, 27);
            this.input.MinimumSize = new System.Drawing.Size(260, 40);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(262, 20);
            this.input.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(48, 68);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(53, 48);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(117, 68);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(53, 48);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(187, 68);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(53, 48);
            this.b3.TabIndex = 1;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bplus
            // 
            this.bplus.Location = new System.Drawing.Point(257, 68);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(53, 48);
            this.bplus.TabIndex = 1;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.bplus_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(257, 133);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(53, 48);
            this.bsub.TabIndex = 1;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(187, 133);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(53, 48);
            this.b6.TabIndex = 1;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(117, 133);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(53, 48);
            this.b5.TabIndex = 1;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(48, 133);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(53, 48);
            this.b4.TabIndex = 1;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(48, 199);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(53, 48);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(117, 199);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(53, 48);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(187, 199);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(53, 48);
            this.b9.TabIndex = 1;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bmul
            // 
            this.bmul.Location = new System.Drawing.Point(257, 199);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(53, 48);
            this.bmul.TabIndex = 1;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // bdıv
            // 
            this.bdıv.Location = new System.Drawing.Point(257, 268);
            this.bdıv.Name = "bdıv";
            this.bdıv.Size = new System.Drawing.Size(53, 48);
            this.bdıv.TabIndex = 1;
            this.bdıv.Text = "/";
            this.bdıv.UseVisualStyleBackColor = true;
            this.bdıv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(187, 268);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(53, 48);
            this.bclear.TabIndex = 1;
            this.bclear.Text = "C";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(117, 268);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(53, 48);
            this.bdot.TabIndex = 1;
            this.bdot.Text = ",";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(48, 268);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(53, 48);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bequal
            // 
            this.bequal.Location = new System.Drawing.Point(48, 335);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(262, 48);
            this.bequal.TabIndex = 1;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 417);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bdıv);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button bdıv;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bequal;
    }
}

