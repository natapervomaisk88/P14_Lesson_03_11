namespace P14_Lesson_03_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            readToolStripMenuItem = new ToolStripMenuItem();
            newFormToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            changeThemaToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            leftPanel1 = new Panel();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            BtnFlyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            leftPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem, readToolStripMenuItem, newFormToolStripMenuItem, BtnFlyToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Закрыть";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // readToolStripMenuItem
            // 
            readToolStripMenuItem.Name = "readToolStripMenuItem";
            readToolStripMenuItem.Size = new Size(180, 22);
            readToolStripMenuItem.Text = "Прочитать";
            readToolStripMenuItem.Click += readToolStripMenuItem_Click;
            // 
            // newFormToolStripMenuItem
            // 
            newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            newFormToolStripMenuItem.Size = new Size(180, 22);
            newFormToolStripMenuItem.Text = "Новая форма";
            newFormToolStripMenuItem.Click += newFormToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeThemaToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // changeThemaToolStripMenuItem
            // 
            changeThemaToolStripMenuItem.Name = "changeThemaToolStripMenuItem";
            changeThemaToolStripMenuItem.Size = new Size(142, 22);
            changeThemaToolStripMenuItem.Text = "Смена темы";
            changeThemaToolStripMenuItem.Click += changeThemaToolStripMenuItem_Click;
            // 
            // leftPanel1
            // 
            leftPanel1.BackColor = SystemColors.ControlLight;
            leftPanel1.Controls.Add(richTextBox1);
            leftPanel1.Dock = DockStyle.Bottom;
            leftPanel1.Location = new Point(0, 24);
            leftPanel1.Name = "leftPanel1";
            leftPanel1.Size = new Size(800, 426);
            leftPanel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnFlyToolStripMenuItem
            // 
            BtnFlyToolStripMenuItem.Name = "BtnFlyToolStripMenuItem";
            BtnFlyToolStripMenuItem.Size = new Size(180, 22);
            BtnFlyToolStripMenuItem.Text = "Летающая кнопка";
            BtnFlyToolStripMenuItem.Click += BtnFlyToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(leftPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MY MAIN  FORM";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            leftPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem changeThemaToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem readToolStripMenuItem;
        private Panel leftPanel1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem newFormToolStripMenuItem;
        private ToolStripMenuItem BtnFlyToolStripMenuItem;
    }
}