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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timeCount = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            time.Text = timeCount.ToString();

            if(timeCount == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up");

                dlg = MessageBox.Show("Do you want to exit?"
                    , "Exit Program"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning);
            }
            else
            {
                timeCount--;
            }

            if (dlg == DialogResult.Yes)
                Application.Exit();
            else if(dlg == DialogResult.No)
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
        }
    }
}
