using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool comp = false;
        public float h1 = 0;
        public string type = "Not";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                label2.Text = "No Problems";
            } else
            {
                label2.Text = "Nothing to Delete!";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            h1 = float.Parse(textBox1.Text);
            comp = true;
            textBox1.Clear();
            type = "add";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (comp == true)
            {
                if(textBox1.Text.Length > 0)
                {
                    float h2 = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    if (type == "add")
                    {
                        textBox1.Text = Convert.ToString(h1 + h2);
                    }
                    if (type == "sub")
                    {
                        textBox1.Text = Convert.ToString(h1 - h2);
                    }
                    if (type == "div")
                    {
                        textBox1.Text = Convert.ToString(h1 / h2);
                    }
                    if (type == "mul")
                    {
                        textBox1.Text = Convert.ToString(h1 * h2);
                    }
                    if (type == "pow")
                    {
                        textBox1.Text = Convert.ToString(Math.Pow(h1, h2));
                    }
                    label2.Text = "No Problems";
                    comp = false;
                } else
                {
                    label2.Text = "Text Box is Empty!";
                }
                
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            h1 = float.Parse(textBox1.Text);
            comp = true;
            textBox1.Clear();
            type = "sub";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            h1 = float.Parse(textBox1.Text);
            comp = true;
            textBox1.Clear();
            type = "mul";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            h1 = float.Parse(textBox1.Text);
            comp = true;
            textBox1.Clear();
            type = "div";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3.14159265";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            type = "sqrt";
            if (type == "sqrt")
                h1 = float.Parse(textBox1.Text);
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(h1));
            }
            comp = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            h1 = float.Parse(textBox1.Text);
            comp = true;
            textBox1.Clear();
            type = "pow";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Info m = new Info();
            m.Show();
        }
    }
}