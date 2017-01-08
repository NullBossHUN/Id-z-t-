using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Időzítő
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hh = 0;
        int mm = 0;
        int ss = 0;
        Timer t1 = new Timer();
        string ttime = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Resume";
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            timer1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
            label6.Text = numericUpDown2.Value.ToString();
            label5.Text = numericUpDown3.Value.ToString();
            timer1.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "00";
            label5.Text = "00";
            label6.Text = "00";
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int.TryParse(label1.Text, out hh);
            if (label1.Text != "")
                if (hh > 0)

                {
                    if (mm == 0)
                        hh -= 1;
                    {
                        if (mm == 0)
                            mm = 60;
                    }
                    label1.Text = hh.ToString();
                    label5.Text = mm.ToString();
                }

            int.TryParse(label5.Text, out mm);
            if (label5.Text != "")
                if (mm > 0)
                {
                    if (ss == 0)
                        mm -= 1;
                    {
                        if (ss == 0)
                            ss = 60;
                    }
                    label5.Text = mm.ToString();
                    label6.Text = ss.ToString();
                }
            int.TryParse(label6.Text, out ss);
            if (label6.Text != "")
            {
                if (ss > 0)
                    ss -= 1;
                label6.Text = ss.ToString();
            }
        }
    }
}

