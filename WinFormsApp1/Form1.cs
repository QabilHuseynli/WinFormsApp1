namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Form2 myform = new Form2();
                myform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}