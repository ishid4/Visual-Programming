using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        public static int elapsedTime = Form2.elapsedTime, score = Form2.score;

        private void Form4_Load(object sender, EventArgs e) {
            label2.Text = elapsedTime.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            elapsedTime++;
            label2.Text = elapsedTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (b.Checked == true)
                score += 5;

            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }
    }
}
