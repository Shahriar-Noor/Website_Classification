using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Website_Categorize
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websitesDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websitesDataSet.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.websitesDataSet.Site);
            // TODO: This line of code loads data into the 'websitesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.websitesDataSet.Category);

            FilterData();
        }

        private void FilterData()
        {
            try
            {
                siteBindingSource.Filter = "CategoryID = " + categoryNameComboBox.SelectedValue;
            }
            catch (SyntaxErrorException see)
            {
            }
        }

        private void categoryNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // Check to see if the user entered anything in the Category text box
            if (txtCategory.Text.Equals(""))
                MessageBox.Show("You must first enter a category name in the text box!", "Add Category");
            else
            {
                // Create an object for the new category row
                websitesDataSet.CategoryRow newCat = websitesDataSet.Category.NewCategoryRow();
                // Set the name of this category
                newCat.CategoryName = txtCategory.Text;

                // Add the new category to the data set
                websitesDataSet.Category.AddCategoryRow(newCat);

                // Update the database to reflect this new record
                categoryTableAdapter.Update(newCat);

                // Cleanup
                MessageBox.Show(txtCategory.Text + " category was added.", "Add Category");
                txtCategory.Text = "";

                // Refill the TableAdapter
                categoryTableAdapter.Fill(websitesDataSet.Category);
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("You are about to delete the " + categoryNameComboBox.Text + " category and all of its contents.  OK?", "Delete Category", MessageBoxButtons.OKCancel);

            if (answer == DialogResult.Cancel)
            {
                MessageBox.Show("Nothing deleted", "Delete Category");
            }
            else
            {
                // Store category name for use in the message box later
                String delName = categoryNameComboBox.Text;

                // Store CategoryID for cleaner code
                int catID = Convert.ToInt32(categoryNameComboBox.SelectedValue);

                // Create an array of items that have the CategoryID to be deleted
                websitesDataSet.SiteRow[] sites = (websitesDataSet.SiteRow[])websitesDataSet.Site.Select("CategoryID = " + catID);

                // Go through each website and delete it
                foreach (websitesDataSet.SiteRow delSite in sites)
                    delSite.Delete();
                siteTableAdapter.Update(websitesDataSet);

                // Delete the Category
                // Search for the record by CategoryID and assign this record to a CategoryRow object
                websitesDataSet.CategoryRow delCat = websitesDataSet.Category.FindByCategoryID(catID);
                delCat.Delete();
                categoryTableAdapter.Update(delCat);
                FilterData();
                MessageBox.Show(delName + " category deleted", "Delete Category");
            }
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            // Create a new SiteForm object
            SiteForm sf = new SiteForm();

            // Display the form
            sf.ShowDialog();

            // Refill the site table adapter
            siteTableAdapter.Fill(websitesDataSet.Site);
        }

        private void btnRemoveSite_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("You are about to delete the " +
                siteNameListBox.Text + " site.  OK?",
                "Delete Site", MessageBoxButtons.OKCancel);

            if (answer == DialogResult.Cancel)
            {
                MessageBox.Show("Nothing deleted", "Delete Site");
            }
            else
            {
                // Store site name for use in the message box later
                String delName = siteNameListBox.Text;

                // Store SiteID for cleaner code
                int oldSiteID = Convert.ToInt32(siteNameListBox.SelectedValue);

                // Delete the Site
                // Search for the record by SiteID and assign this record to a SiteRow object
                websitesDataSet.SiteRow delSite = websitesDataSet.Site.FindBySiteID(oldSiteID);

                delSite.Delete();
                siteTableAdapter.Update(delSite);

                FilterData();

                MessageBox.Show(delName + " site deleted", "Delete Site");
            }
        }
    }
}
