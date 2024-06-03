namespace form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ali Wert";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label6.Text = "John";
            label7.Text = "Kennedy";
            label8.Text = "Teacher";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Software Developer";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
