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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[0]?.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0]?.Close(); //закрытие главной формы
        }

        public void SetValue(TextBox tb)
        {
            linkLabel1.Text = tb.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //var tb = Application.OpenForms[0]?.Controls.OfType<TextBox>();
            var tb = Application
                        .OpenForms[0]?
                        .Controls
                        .OfType<TextBox>()
                        .FirstOrDefault(e=>e.Name.Equals("textBox1"));
           
            linkLabel1.Text += tb.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=string.Empty)
            {
                Application.OpenForms[0].Text += textBox1.Text;
                Application.OpenForms[0]?.Show();
                
            }
        }
    }
}
