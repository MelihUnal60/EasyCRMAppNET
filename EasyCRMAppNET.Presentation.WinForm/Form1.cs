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
        IOpportunityService opportunityService = IOCContainer.Resolve<IOpportunityService>();

        private void AddCategoryToGrid()
        {
            grdCategory.DataSource = categoryService.GetCategories();
        }

        private void AddOpportunityToGrid()
        {
            grdOpportunities.DataSource = opportunityService.GetOpportunities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCategoryToGrid();
            AddOpportunityToGrid();
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

        private void btnSaveOpp_Click(object sender, EventArgs e)
        {
            if (btnSaveOpp.Text == "KAYDET")
            {
                int id = Convert.ToInt32(txtOppId.Text);
                opportunityService.CreateOpportunity(id, txtOppName.Text, txtOppStatus.Text, txtOppOwner.Text, txtCustomer.Text);
            }
            else
            {
                opportunityService.UpdateOpportunity(Convert.ToInt32(txtOppId.Text), txtOppName.Text, txtOppStatus.Text);
                btnSaveOpp.Text = "KAYDET";
                groupBox2.Text = "Fýrsat Köþesi";
                txtOppId.Enabled= true;
            }

            txtOppId.Text = "";
            txtCustomer.Text = "";
            txtOppName.Text = "";
            txtOppOwner.Text = "";
            txtOppStatus.Text = "";


            AddOpportunityToGrid();
        }

        private void firsatSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string opportunityName = grdOpportunities.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"{opportunityName} isimli fýrsati silmek istediðinizden emin misiz?", "Silme Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;

            int opportunityId = Convert.ToInt32(grdOpportunities.CurrentRow.Cells["Id"].Value);
            opportunityService.DeleteOpportunity(opportunityId);
            AddOpportunityToGrid();

        }

        private void firsatDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string opportunityName = grdOpportunities.CurrentRow.Cells["Name"].Value.ToString();
            string opportunityId = grdOpportunities.CurrentRow.Cells["Id"].Value.ToString();
            string opportunityStatus = grdOpportunities.CurrentRow.Cells["Status"].Value.ToString();
            string customer = grdOpportunities.CurrentRow.Cells["Customer"].Value.ToString() ;
            string owner = grdOpportunities.CurrentRow.Cells["Owner"].Value.ToString();

            txtOppId.Text = opportunityId;
            txtOppName.Text = opportunityName;
            txtCustomer.Text = customer;
            txtOppOwner.Text = owner;
            txtOppStatus.Text = opportunityStatus;

            txtOppId.Enabled= false;
            btnSaveOpp.Text = "Fýrsatý Güncelle";
            groupBox2.Text= "Fýrsat Güncelleme";


        }

        
    }
}   