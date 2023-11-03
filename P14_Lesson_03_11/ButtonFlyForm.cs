using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_Lesson_03_11
{
    public partial class ButtonFlyForm : Form
    {
        int diff;
        public ButtonFlyForm()
        {
            InitializeComponent();
            diff = button1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.X + diff);
            diff += 5;
        }
    }
}
