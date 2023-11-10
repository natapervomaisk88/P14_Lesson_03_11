using P14_Lesson_07_11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_Lesson_07_11
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            List<Book> list = new List<Book>();
            list = new List<Book>();
            list.Add(new Book("b1", "a1", 2020));
            list.Add(new Book("b2", "a2", 2021));
            list.Add(new Book("b3", "a3", 2022));
            list.Add(new Book("b4", "a4", 2019));
            list.Add(new Book("b5", "a5", 2017));
            list.Add(new Book("b6", "a6", 2014));
            list.Add(new Book("b7", "a7", 2010));
            DataTable dt = new DataTable();
            dt.Columns.Add("Идентификатор", typeof(string));
            dt.Columns.Add("Название", typeof(string));
            dt.Columns.Add("Автор", typeof(string));
            dt.Columns.Add("Год", typeof(int));
            foreach (var book in list)
            {
                dt.Rows.Add(book.Id, book.Title, book.Author, book.Year);
            }
            dataGridView1.DataSource = dt;
            button1.ContextMenuStrip = contextMenuStrip1;
            //dataGridView1.DataSource = list;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked Open");
        }
    }
}
