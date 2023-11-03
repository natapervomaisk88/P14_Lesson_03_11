namespace P14_Lesson_03_11
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarRed = new TrackBar();
            labelRed = new Label();
            label1 = new Label();
            trackBarGreen = new TrackBar();
            label2 = new Label();
            trackBarBlue = new TrackBar();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(98, 74);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Orientation = Orientation.Vertical;
            trackBarRed.Size = new Size(45, 104);
            trackBarRed.TabIndex = 0;
            trackBarRed.TickFrequency = 5;
            trackBarRed.Scroll += trackBar_Scroll;
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRed.Location = new Point(98, 197);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(24, 23);
            labelRed.TabIndex = 1;
            labelRed.Text = "R";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 197);
            label1.Name = "label1";
            label1.Size = new Size(24, 23);
            label1.TabIndex = 3;
            label1.Text = "G";
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(211, 74);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Orientation = Orientation.Vertical;
            trackBarGreen.Size = new Size(45, 104);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.TickFrequency = 5;
            trackBarGreen.Scroll += trackBar_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(332, 197);
            label2.Name = "label2";
            label2.Size = new Size(24, 23);
            label2.TabIndex = 5;
            label2.Text = "B";
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(332, 74);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Orientation = Orientation.Vertical;
            trackBarBlue.Size = new Size(45, 104);
            trackBarBlue.TabIndex = 4;
            trackBarBlue.TickFrequency = 5;
            trackBarBlue.Scroll += trackBar_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(trackBarRed);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelRed);
            groupBox1.Controls.Add(trackBarBlue);
            groupBox1.Controls.Add(trackBarGreen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(174, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 304);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Цвета";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Color mania";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TrackBar trackBarRed;
        private Label labelRed;
        private Label label1;
        private TrackBar trackBarGreen;
        private Label label2;
        private TrackBar trackBarBlue;
        private GroupBox groupBox1;
    }
}