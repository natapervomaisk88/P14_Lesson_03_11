namespace P14_Lesson_07_11
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //f2.Show();
            f2.Show();
            this.Hide();
        }

        private void ShowSecondWindow()
        {
            if (textBox1.Text != string.Empty)
            {
                //f2.SetValue(textBox1);
                f2.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSecondWindow();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                ShowSecondWindow();
            }
        }
    }
}