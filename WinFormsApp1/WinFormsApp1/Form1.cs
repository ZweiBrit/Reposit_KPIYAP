namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
        }
    }
}
