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
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Thread.Sleep(200);
                this.Hide();

                Form2 frm = new Form2();
                frm.ShowDialog();

            }
        }
    }
}
