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
using P14_Lesson_07_11.Models;

namespace P14_Lesson_07_11
{
    public partial class Form3 : Form
    {
        public Form3(Book b)
        {
            InitializeComponent();
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelId.Text = b.Id;
            labelTitle.Text = b.Title;
            labelAuthor.Text = b.Author;
            labelYear.Text = b.Year.ToString();
        
        }
    }
}
