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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOppOwner = new System.Windows.Forms.TextBox();
            this.txtOppStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnSaveOpp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOppName = new System.Windows.Forms.TextBox();
            this.txtOppId = new System.Windows.Forms.TextBox();
            this.grdOpportunities = new System.Windows.Forms.DataGridView();
            this.ctxgrdOppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fırsatSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fırsatDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbOppCat = new System.Windows.Forms.ComboBox();
            this.NewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.ctxgrdCategoryMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpportunities)).BeginInit();
            this.ctxgrdOppMenu.SuspendLayout();
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
            this.ctxgrdCategoryMenu.Size = new System.Drawing.Size(133, 58);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.duzenleToolStripMenuItem.Text = "Düzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbOppCat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOppOwner);
            this.groupBox2.Controls.Add(this.txtOppStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Controls.Add(this.btnSaveOpp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOppName);
            this.groupBox2.Controls.Add(this.txtOppId);
            this.groupBox2.Location = new System.Drawing.Point(777, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fırsat Köşesi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fırsat Sahibi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Durum";
            // 
            // txtOppOwner
            // 
            this.txtOppOwner.Location = new System.Drawing.Point(203, 172);
            this.txtOppOwner.Name = "txtOppOwner";
            this.txtOppOwner.Size = new System.Drawing.Size(395, 27);
            this.txtOppOwner.TabIndex = 8;
            // 
            // txtOppStatus
            // 
            this.txtOppStatus.Location = new System.Drawing.Point(203, 137);
            this.txtOppStatus.Name = "txtOppStatus";
            this.txtOppStatus.Size = new System.Drawing.Size(395, 27);
            this.txtOppStatus.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Müşteri";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(203, 104);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(395, 27);
            this.txtCustomer.TabIndex = 5;
            // 
            // btnSaveOpp
            // 
            this.btnSaveOpp.Location = new System.Drawing.Point(448, 251);
            this.btnSaveOpp.Name = "btnSaveOpp";
            this.btnSaveOpp.Size = new System.Drawing.Size(150, 29);
            this.btnSaveOpp.TabIndex = 4;
            this.btnSaveOpp.Text = "KAYDET";
            this.btnSaveOpp.UseVisualStyleBackColor = true;
            this.btnSaveOpp.Click += new System.EventHandler(this.btnSaveOpp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fırsat Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fırsat ID";
            // 
            // txtOppName
            // 
            this.txtOppName.Location = new System.Drawing.Point(203, 71);
            this.txtOppName.Name = "txtOppName";
            this.txtOppName.Size = new System.Drawing.Size(395, 27);
            this.txtOppName.TabIndex = 1;
            // 
            // txtOppId
            // 
            this.txtOppId.Location = new System.Drawing.Point(203, 38);
            this.txtOppId.Name = "txtOppId";
            this.txtOppId.Size = new System.Drawing.Size(395, 27);
            this.txtOppId.TabIndex = 0;
            // 
            // grdOpportunities
            // 
            this.grdOpportunities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOpportunities.ContextMenuStrip = this.ctxgrdOppMenu;
            this.grdOpportunities.Location = new System.Drawing.Point(781, 333);
            this.grdOpportunities.Name = "grdOpportunities";
            this.grdOpportunities.RowHeadersWidth = 51;
            this.grdOpportunities.RowTemplate.Height = 29;
            this.grdOpportunities.Size = new System.Drawing.Size(600, 367);
            this.grdOpportunities.TabIndex = 3;
            // 
            // ctxgrdOppMenu
            // 
            this.ctxgrdOppMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxgrdOppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fırsatSilToolStripMenuItem,
            this.toolStripSeparator2,
            this.fırsatDüzenleToolStripMenuItem});
            this.ctxgrdOppMenu.Name = "ctxgrdOppMenu";
            this.ctxgrdOppMenu.Size = new System.Drawing.Size(172, 58);
            this.ctxgrdOppMenu.Text = "ctxgrdOppMenu";
            // 
            // fırsatSilToolStripMenuItem
            // 
            this.fırsatSilToolStripMenuItem.Name = "fırsatSilToolStripMenuItem";
            this.fırsatSilToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fırsatSilToolStripMenuItem.Text = "Fırsat Sil";
            this.fırsatSilToolStripMenuItem.Click += new System.EventHandler(this.firsatSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // fırsatDüzenleToolStripMenuItem
            // 
            this.fırsatDüzenleToolStripMenuItem.Name = "fırsatDüzenleToolStripMenuItem";
            this.fırsatDüzenleToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.fırsatDüzenleToolStripMenuItem.Text = "Fırsat Düzenle";
            this.fırsatDüzenleToolStripMenuItem.Click += new System.EventHandler(this.firsatDuzenleToolStripMenuItem_Click);
            // 
            // cbbOppCat
            // 
            this.cbbOppCat.FormattingEnabled = true;
            this.cbbOppCat.Location = new System.Drawing.Point(203, 209);
            this.cbbOppCat.Name = "cbbOppCat";
            this.cbbOppCat.Size = new System.Drawing.Size(395, 28);
            this.cbbOppCat.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 735);
            this.Controls.Add(this.grdOpportunities);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.NewCategory);
            this.Name = "Form1";
            this.Text = "Yeni Kategori";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewCategory.ResumeLayout(false);
            this.NewCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ctxgrdCategoryMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpportunities)).EndInit();
            this.ctxgrdOppMenu.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox txtOppName;
        private TextBox txtOppId;
        private Button btnSaveOpp;
        private Label label7;
        private TextBox txtCustomer;
        private DataGridView grdOpportunities;
        private TextBox txtOppOwner;
        private TextBox txtOppStatus;
        private ContextMenuStrip ctxgrdOppMenu;
        private ToolStripMenuItem fırsatSilToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem fırsatDüzenleToolStripMenuItem;
        private Label label9;
        private ComboBox cbbOppCat;
    }
}