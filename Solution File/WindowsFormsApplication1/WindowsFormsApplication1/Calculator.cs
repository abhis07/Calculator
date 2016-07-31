using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string opr;
        double oparand1, oparand2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(display.Text);
            opr = "-";
            display.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (display.Text.Contains("."))
            {
                display.Text = display.Text;
            }
            else
            {
                display.Text = display.Text + ".";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(display.Text);
            opr = "/";
            display.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(display.Text);
            opr = "+";
            display.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(display.Text);
            opr = "*";
            display.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oparand2 = Convert.ToDouble(display.Text);
            switch (opr)
            {
                case "+":
                    result = oparand1 + oparand2;
                    display.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = oparand1 - oparand2;
                    display.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = oparand1 * oparand2;
                    display.Text = Convert.ToString(result);
                    break;

                case "/": if (oparand2 == 0)
                    {
                        display.Text = "0.0";
                        break;
                    }
                    else
                    {
                        result = oparand1 / oparand2;
                        display.Text = Convert.ToString(result);
                        break;
                    }
            }
        }
    }
}
