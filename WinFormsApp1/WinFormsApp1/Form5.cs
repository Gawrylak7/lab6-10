using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        Double result = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form5()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operation_pressed)
                textBox1.Clear();

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button_Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            result = Double.Parse(textBox1.Text);
            operation_pressed = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();

                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }




    }

}