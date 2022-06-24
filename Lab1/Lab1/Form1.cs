using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double h = 0;
            if (radioButton4.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(2 * a + 2 * b);
            }
            if (radioButton5.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a * b);
            }
            if (radioButton6.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                h = Convert.ToDouble(textBox4.Text);
                textBox3.Text = Convert.ToString(a * h);
            }
            if (radioButton7.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox4.Text);
                textBox3.Text = Convert.ToString(((a + b) / 2) * h);
            }
            if (radioButton7.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                h = Convert.ToDouble(textBox4.Text);
                textBox3.Text = Convert.ToString(a * h);
            }




            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += (sender as Button).Text;
            }
            if (radioButton2.Checked)
            {
                textBox2.Text += (sender as Button).Text;
            }
            if (radioButton3.Checked)
            {
                textBox4.Text += (sender as Button).Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (radioButton3.Checked)
            {
                textBox4.Text = "";
            }
            if (radioButton1.Checked)
            {
                textBox1.Text = "";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = "";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            radioButton3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            radioButton3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            radioButton2.Enabled = false;
            textBox2.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            radioButton2.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
