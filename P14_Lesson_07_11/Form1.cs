using P14_Lesson_07_11.Models;
using System.Net.Http.Headers;

namespace P14_Lesson_07_11
{
    public partial class Form1 : Form
    {
        Form2 f2;
        List<Book> list;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            list = new List<Book>();
            list.Add(new Book("b1", "a1", 2020));
            list.Add(new Book("b2", "a2", 2021));
            list.Add(new Book("b3", "a3", 2022));
            list.Add(new Book("b4", "a4", 2019));
            //list.Add(new Book("b5", "a5", 2017));
            //list.Add(new Book("b6", "a6", 2014));
            //list.Add(new Book("b7", "a7", 2010));

            int diff = 50;
            foreach (var book in list)
            {
                Button b = new Button()
                {
                    Text = book.Title,
                    Tag = book,
                    Location = new Point(diff,50)
                };
                diff += 100;
                b.Click += B_Click;
                this.Controls.Add(b);
              
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form3 bookForm = new Form3((Book)btn.Tag);
            // MessageBox.Show(btn?.Tag.ToString());
            bookForm.Show();
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
            if (e.KeyCode == Keys.Enter)
            {
                ShowSecondWindow();
            }
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }
    }
}