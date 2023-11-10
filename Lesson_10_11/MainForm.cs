using Lesson_10_11.Models;
using System.Collections.ObjectModel;

namespace Lesson_10_11
{
    public partial class MainForm : Form
    {
        List<Category> category;
        List<Product> products;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBoxProducts.SelectionMode = SelectionMode.MultiExtended;
            category = Seeder.InitCategory();
            products = Seeder.InitProduct(category);
            comboBoxCategory.DataSource = category;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            FillData();
        }
        private void FillData()
        {
            listBoxProducts.DataSource = products
                .Where(e => e.Category.Id.Equals(comboBoxCategory.SelectedValue)).ToList();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxProducts
                .SelectedItems
                .OfType<Product>().ToList();
            if (selectedProducts != null)
            {
                foreach (var el in selectedProducts)
                {
                    listBoxCart.Items.Add(el);

                }
                textBoxTotalPay.Text = listBoxCart.Items.OfType<Product>().Sum(e => e.Price).ToString();
                textBoxCount.Text = listBoxCart.Items.Count.ToString();
            }

        }
    }
}