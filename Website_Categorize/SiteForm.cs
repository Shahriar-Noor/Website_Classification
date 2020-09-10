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
    public partial class SiteForm : Form
    {
        public SiteForm()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websitesDataSet);

        }

        private void SiteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websitesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.websitesDataSet.Category);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing added.", "Add Site");
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSiteName.Text.Equals("") || txtURL.Text.Equals(""))
            {
                MessageBox.Show("You must specify values for both Site anem and URL", "Add Site");
            }
            else
            {
                // Create a new SiteRow object
                websitesDataSet.SiteRow newSite = websitesDataSet.Site.NewSiteRow();

                // Set field values for this new site
                newSite.SiteName = txtSiteName.Text;
                newSite.URL = txtURL.Text;
                newSite.CategoryID = Convert.ToInt32(categoryNameComboBox.SelectedValue);

                // Add the row to the database
                websitesDataSet.Site.AddSiteRow(newSite);

                // Update the siteTableAdapter object
                siteTableAdapter.Update(newSite);
                MessageBox.Show(txtSiteName.Text + " site added to " + categoryNameComboBox.Text + " category.", "Add Site");
                Close();
            }
        }
    }
}
