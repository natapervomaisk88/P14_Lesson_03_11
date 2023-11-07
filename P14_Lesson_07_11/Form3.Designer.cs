namespace P14_Lesson_07_11
{
    partial class Form3
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
            labelId = new Label();
            labelTitle = new Label();
            labelAuthor = new Label();
            labelYear = new Label();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(361, 85);
            labelId.Name = "labelId";
            labelId.Size = new Size(83, 32);
            labelId.TabIndex = 0;
            labelId.Text = "label1";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(361, 153);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(83, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "label2";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAuthor.Location = new Point(361, 216);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(83, 32);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "label3";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(361, 297);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(83, 32);
            labelYear.TabIndex = 3;
            labelYear.Text = "label4";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelYear);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle);
            Controls.Add(labelId);
            Name = "Form3";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelTitle;
        private Label labelAuthor;
        private Label labelYear;
    }
}