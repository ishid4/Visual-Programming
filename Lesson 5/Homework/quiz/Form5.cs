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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) {
            label2.Text = Form1.player_name;
            label4.Text = Form4.score.ToString();
            label6.Text = Form4.elapsedTime.ToString();
        }
    }
}
