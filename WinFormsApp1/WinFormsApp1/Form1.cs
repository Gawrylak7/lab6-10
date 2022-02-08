namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zadanie rozwi¹zane, gratulacje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            MessageBox.Show("Przycisk 2: odblokowany");
        }
    }
}