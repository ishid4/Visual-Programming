using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int elapsedTime = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3() ;
            this.Hide();
            frm3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
        }
    }
}
