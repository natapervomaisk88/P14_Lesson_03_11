using System.Net.Http.Headers;

namespace P14_Lesson_03_11
{
    public partial class Form1 : Form
    {
        Panel pn;
        public Form1()
        {
            InitializeComponent();
            pn = new Panel();
            this.Controls.Add(pn);
            pn.Width = 300;
            pn.Dock = DockStyle.Right;
            Button btn = new Button();
            btn.Location = new Point(0, menuStrip1.Height);
            btn.Width = 100;
            btn.Height = 100;
            btn.Text = "Clear";
            btn.Click += (sender, e) =>
            {
                richTextBox1.Text = string.Empty;
            };
            ToolTip tt = new ToolTip();
            tt.ToolTipTitle = "Attention";
            tt.ShowAlways = true;
            tt.SetToolTip(btn, "Clear all");
            tt.ToolTipIcon = ToolTipIcon.Error;
            tt.IsBalloon = true;
            pn.Controls.Add(btn);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeThemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pn.BackColor = colorDialog1.Color;
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string pathToFile = openFileDialog1.FileName;
            if (pathToFile != null)
            {
                string content = File.ReadAllText(pathToFile);
                richTextBox1.Text = content;
            }
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressForm prForm = new ProgressForm();
            prForm.ShowDialog();
        }
    }
}