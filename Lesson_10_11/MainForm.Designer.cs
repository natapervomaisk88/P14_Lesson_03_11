namespace Lesson_10_11
{
    partial class MainForm
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
            comboBoxCategory = new ComboBox();
            listBoxProducts = new ListBox();
            listBoxCart = new ListBox();
            AddCartBtn = new Button();
            textBoxTotalPay = new TextBox();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Dock = DockStyle.Top;
            comboBoxCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(0, 0);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(828, 33);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.Dock = DockStyle.Left;
            listBoxProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 25;
            listBoxProducts.Location = new Point(0, 33);
            listBoxProducts.MultiColumn = true;
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.ScrollAlwaysVisible = true;
            listBoxProducts.Size = new Size(326, 526);
            listBoxProducts.TabIndex = 1;
            // 
            // listBoxCart
            // 
            listBoxCart.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 30;
            listBoxCart.Location = new Point(332, 33);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(496, 454);
            listBoxCart.TabIndex = 2;
            // 
            // AddCartBtn
            // 
            AddCartBtn.BackColor = SystemColors.WindowFrame;
            AddCartBtn.ForeColor = SystemColors.ControlLightLight;
            AddCartBtn.Location = new Point(44, 468);
            AddCartBtn.Name = "AddCartBtn";
            AddCartBtn.Size = new Size(118, 55);
            AddCartBtn.TabIndex = 3;
            AddCartBtn.Text = "Купить";
            AddCartBtn.UseVisualStyleBackColor = false;
            AddCartBtn.Click += AddCartBtn_Click;
            // 
            // textBoxTotalPay
            // 
            textBoxTotalPay.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTotalPay.Location = new Point(403, 511);
            textBoxTotalPay.Name = "textBoxTotalPay";
            textBoxTotalPay.ReadOnly = true;
            textBoxTotalPay.Size = new Size(269, 33);
            textBoxTotalPay.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 559);
            Controls.Add(textBoxTotalPay);
            Controls.Add(AddCartBtn);
            Controls.Add(listBoxCart);
            Controls.Add(listBoxProducts);
            Controls.Add(comboBoxCategory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private ListBox listBoxProducts;
        private ListBox listBoxCart;
        private Button AddCartBtn;
        private TextBox textBoxTotalPay;
    }
}