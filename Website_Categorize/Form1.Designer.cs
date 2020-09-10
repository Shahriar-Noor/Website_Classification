namespace Website_Categorize
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label siteNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.websitesDataSet = new Website_Categorize.websitesDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Website_Categorize.websitesDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new Website_Categorize.websitesDataSetTableAdapters.TableAdapterManager();
            this.siteTableAdapter = new Website_Categorize.websitesDataSetTableAdapters.SiteTableAdapter();
            this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteNameListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtCategory = new System.Windows.Forms.ToolStripTextBox();
            this.btnAddCategory = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddSite = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveSite = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            categoryNameLabel = new System.Windows.Forms.Label();
            siteNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(80, 105);
            categoryNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(110, 17);
            categoryNameLabel.TabIndex = 1;
            categoryNameLabel.Text = "Category Name:";
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Location = new System.Drawing.Point(461, 105);
            siteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new System.Drawing.Size(77, 17);
            siteNameLabel.TabIndex = 3;
            siteNameLabel.Text = "Site Name:";
            // 
            // websitesDataSet
            // 
            this.websitesDataSet.DataSetName = "websitesDataSet";
            this.websitesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.websitesDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.SiteTableAdapter = this.siteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Website_Categorize.websitesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // categoryNameComboBox
            // 
            this.categoryNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryName", true));
            this.categoryNameComboBox.DataSource = this.websitesDataSet;
            this.categoryNameComboBox.DisplayMember = "Category.CategoryName";
            this.categoryNameComboBox.FormattingEnabled = true;
            this.categoryNameComboBox.Location = new System.Drawing.Point(199, 101);
            this.categoryNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryNameComboBox.Name = "categoryNameComboBox";
            this.categoryNameComboBox.Size = new System.Drawing.Size(160, 24);
            this.categoryNameComboBox.TabIndex = 2;
            this.categoryNameComboBox.ValueMember = "Category.CategoryID";
            this.categoryNameComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryNameComboBox_SelectedIndexChanged);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.websitesDataSet;
            // 
            // siteNameListBox
            // 
            this.siteNameListBox.DataSource = this.siteBindingSource;
            this.siteNameListBox.DisplayMember = "SiteName";
            this.siteNameListBox.FormattingEnabled = true;
            this.siteNameListBox.ItemHeight = 16;
            this.siteNameListBox.Location = new System.Drawing.Point(548, 105);
            this.siteNameListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteNameListBox.Name = "siteNameListBox";
            this.siteNameListBox.Size = new System.Drawing.Size(159, 116);
            this.siteNameListBox.TabIndex = 4;
            this.siteNameListBox.ValueMember = "SiteID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtCategory,
            this.btnAddCategory,
            this.btnRemoveCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(132, 27);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(105, 24);
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCategory.Image")));
            this.btnRemoveCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(131, 24);
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSite,
            this.btnRemoveSite});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(792, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddSite
            // 
            this.btnAddSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddSite.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSite.Image")));
            this.btnAddSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(70, 24);
            this.btnAddSite.Text = "Add Site";
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // btnRemoveSite
            // 
            this.btnRemoveSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveSite.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSite.Image")));
            this.btnRemoveSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveSite.Name = "btnRemoveSite";
            this.btnRemoveSite.Size = new System.Drawing.Size(96, 24);
            this.btnRemoveSite.Text = "Remove Site";
            this.btnRemoveSite.Click += new System.EventHandler(this.btnRemoveSite_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.DataBindings.Add(new System.Windows.Forms.Binding("Url", this.siteBindingSource, "URL", true));
            this.webBrowser1.Location = new System.Drawing.Point(27, 260);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(749, 511);
            this.webBrowser1.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 785);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(siteNameLabel);
            this.Controls.Add(this.siteNameListBox);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Classification";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websitesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private websitesDataSet websitesDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private websitesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private websitesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private websitesDataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.ComboBox categoryNameComboBox;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private System.Windows.Forms.ListBox siteNameListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtCategory;
        private System.Windows.Forms.ToolStripButton btnAddCategory;
        private System.Windows.Forms.ToolStripButton btnRemoveCategory;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddSite;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton btnRemoveSite;
    }
}

