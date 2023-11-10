using Lesson_10_11.Models;

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


    }
}