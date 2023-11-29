namespace CS_4273_Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Test
        }

        private void zero_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void one_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
        private void two_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }
        private void three_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }
        private void four_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }
        private void five_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }
        private void six_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void seven_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void eight_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void nine_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }
    }
}