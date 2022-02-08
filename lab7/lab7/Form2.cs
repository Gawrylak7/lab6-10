using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 6);
            }
            if (radioButton2.Checked)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 12);
            }
            if (radioButton3.Checked)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 18);
            }
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Orange;
            }
        }
    }
}