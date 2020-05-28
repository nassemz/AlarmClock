using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime aa = DateTime.Now;
            clocklbl.Text = aa.ToLongTimeString();
            if (clocklbl.Text.Equals(textBox1.Text))
                webBrowser1.Navigate(textBox2.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Start();
            else
            {
                timer1.Stop();
                webBrowser1.Navigate("");
            }
        }
    }
}
