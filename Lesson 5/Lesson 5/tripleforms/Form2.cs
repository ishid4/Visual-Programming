using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tripleforms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int finishedCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = finishedCount;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                Form3 frm3 = new Form3();
                this.Hide();
                frm3.Show();
            }
            else
                finishedCount += 10;
        }
    }
}
