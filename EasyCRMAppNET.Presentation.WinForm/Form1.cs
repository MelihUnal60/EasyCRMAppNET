using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Infrastructure;
using System.ComponentModel;
using EasyCRMAppNET.Infrastructure;
using EasyCRMAppNET.App;
using System.CodeDom.Compiler;

namespace EasyCRMAppNET.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ICategoryService categoryService = IOCContainer.Resolve<ICategoryService>();

        private void AddCategoryToGrid()
        {
            grdCategory.DataSource = categoryService.GetCategories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCategoryToGrid();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (btnSaveCategory.Text == "KAYDET")
            {
                int id = Convert.ToInt32(txtCategoryId.Text);
                categoryService.Create(id, txtCategoryName.Text);
            }
            else
            {
                categoryService.Update(Convert.ToInt32(txtCategoryId.Text), txtCategoryName.Text);

                btnSaveCategory.Text = "KAYDET";
                txtCategoryId.Enabled = true;
                NewCategory.Text = "Yeni Kategori";

            }
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            AddCategoryToGrid();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = grdCategory.CurrentRow.Cells["Id"].Value.ToString();
           DialogResult result = MessageBox.Show($"{categoryName} kategorisi silmek istediðinizden emin misiniz?",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;


            int id = Convert.ToInt32(grdCategory.CurrentRow.Cells["Id"].Value);
            categoryService.Delete(id);
            AddCategoryToGrid();
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = grdCategory.CurrentRow.Cells["Name"].Value.ToString();
            string id = grdCategory.CurrentRow.Cells["Id"].Value.ToString();

            txtCategoryId.Text = id;
            txtCategoryName.Text = categoryName;

            txtCategoryId.Enabled = false;
            btnSaveCategory.Text = "Güncelle";
            NewCategory.Text = "Kategori Güncelle";
            
        }
    }
}   