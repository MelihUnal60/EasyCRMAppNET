namespace EasyCRMAppNET.Presentation.WinForm
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
            this.components = new System.ComponentModel.Container();
            this.NewCategory = new System.Windows.Forms.GroupBox();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.ctxgrdCategoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.ctxgrdCategoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCategory
            // 
            this.NewCategory.Controls.Add(this.btnSaveCategory);
            this.NewCategory.Controls.Add(this.label2);
            this.NewCategory.Controls.Add(this.txtCategoryName);
            this.NewCategory.Controls.Add(this.label1);
            this.NewCategory.Controls.Add(this.txtCategoryId);
            this.NewCategory.Location = new System.Drawing.Point(66, 29);
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Size = new System.Drawing.Size(622, 298);
            this.NewCategory.TabIndex = 0;
            this.NewCategory.TabStop = false;
            this.NewCategory.Text = "Yeni Kategori";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(452, 225);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(158, 29);
            this.btnSaveCategory.TabIndex = 3;
            this.btnSaveCategory.Text = "KAYDET";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Adı";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(243, 157);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(367, 27);
            this.txtCategoryName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori ID";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(243, 82);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(367, 27);
            this.txtCategoryId.TabIndex = 1;
            // 
            // grdCategory
            // 
            this.grdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.ContextMenuStrip = this.ctxgrdCategoryMenu;
            this.grdCategory.Location = new System.Drawing.Point(66, 333);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RowHeadersVisible = false;
            this.grdCategory.RowHeadersWidth = 51;
            this.grdCategory.RowTemplate.Height = 29;
            this.grdCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategory.Size = new System.Drawing.Size(622, 367);
            this.grdCategory.TabIndex = 1;
            // 
            // ctxgrdCategoryMenu
            // 
            this.ctxgrdCategoryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxgrdCategoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.toolStripSeparator1,
            this.duzenleToolStripMenuItem});
            this.ctxgrdCategoryMenu.Name = "contextMenuStrip1";
            this.ctxgrdCategoryMenu.Size = new System.Drawing.Size(211, 86);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // düzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.duzenleToolStripMenuItem.Text = "Düzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 735);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.NewCategory);
            this.Name = "Form1";
            this.Text = "Yeni Kategori";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewCategory.ResumeLayout(false);
            this.NewCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ctxgrdCategoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSaveCategory;
        private Label label1;
        private GroupBox NewCategory;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private Label label2;
        private DataGridView grdCategory;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtCatName;
        private TextBox txtCatId;
        private Label label4;
        private Button buttonSaveCategory;
        private DataGridView dataGridView2;
        private ContextMenuStrip ctxgrdCategoryMenu;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem duzenleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}