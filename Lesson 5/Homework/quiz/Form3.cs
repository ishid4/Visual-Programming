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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public static int elapsedTime = Form2.elapsedTime, score = Form2.score;
        
        private void button1_Click(object sender, EventArgs e) {
            if (d.Checked == true)
                score += 5;

            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void Form3_Load(object sender, EventArgs e) {
            label2.Text = elapsedTime.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            elapsedTime++;
            label2.Text = elapsedTime.ToString();
        }
    }
}
