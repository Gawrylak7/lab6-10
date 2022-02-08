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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);

                textBox4.Text = (x + y + z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane ", "Uwaga!", MessageBoxButtons.OK);
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);

                textBox4.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane ", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
