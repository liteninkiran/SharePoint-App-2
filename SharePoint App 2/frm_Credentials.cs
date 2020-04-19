using System;
using System.Windows.Forms;

namespace SharePoint_App_2
{
    public partial class frm_Credentials : Form
    {
        frm_Site siteForm;

        public frm_Credentials(frm_Site parent)
        {
            InitializeComponent();
            siteForm = parent;
        }

        private void frm_Credentials_Load(object sender, EventArgs e)
        {
            this.Width = 500;
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if(this.txt_Site_URL.Text == "")
            {
                MessageBox.Show("Please enter a URL");
                this.txt_Site_URL.Select();
                return;
            }

            if (this.txt_Username.Text == "")
            {
                MessageBox.Show("Please enter a Username");
                this.txt_Username.Select();
                return;
            }

            if (this.txt_Password.Text == "")
            {
                MessageBox.Show("Please enter a Password");
                this.txt_Password.Select();
                return;
            }

            // Store credentials in the Site Form variables
            siteForm.url = this.txt_Site_URL.Text;
            siteForm.username = this.txt_Username.Text;
            siteForm.password = this.txt_Password.Text;

            // Reset the Site Form
            siteForm.ResetControls();

            this.Close();
        }
    }
}
