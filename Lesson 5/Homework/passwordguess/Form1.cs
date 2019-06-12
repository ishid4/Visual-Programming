using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordguess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int theNumber, time = 90;

        private void timer1_Tick(object sender, EventArgs e) {
            time--;
            timerText.Text = time.ToString();
            if(time == 0) {
                timer1.Stop();

                MessageBox.Show("Time is up, the password was " + theNumber.ToString());
                Application.Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string fullPass = pass1.Text + pass2.Text + pass3.Text;

            if (int.Parse(fullPass) < theNumber) {
                hintText.Text = "<";
            }
            else {
                hintText.Text = ">";
            }

            if (theNumber == int.Parse(fullPass)) {
                MessageBox.Show("You guessed the PASSWORD! The password was "+ theNumber.ToString());
                Application.Restart();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Random rnd = new Random();

            theNumber = rnd.Next(100, 999);
        }
    }
}
