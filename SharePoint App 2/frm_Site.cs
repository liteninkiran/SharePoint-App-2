using System;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;

namespace SharePoint_App_2
{
    public partial class frm_Site : System.Windows.Forms.Form
    {
        ClientContext clientContext;

        public string url = null;
        public string username = null;
        public string password = null;

        public frm_Site()
        {
            InitializeComponent();
        }

        private void tcmd_Credentials_Click(object sender, EventArgs e)
        {
            ShowCredentialsForm();
        }

        private void cmd_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcmd_Connect_Click(object sender, EventArgs e)
        {
            // Check user has entered credentials
            if(url == null || username == null || password == null)
            {
                // Tell user to enter credentials
                MessageBox.Show("Please enter credentials");

                // Open the credentials form
                ShowCredentialsForm();
            }

            // Change button text
            //tcmd_Connect.Text = "Connecting...";

            // Try to get the client
            clientContext = GetClient();

            // Exit if we got an error
            if (clientContext == null){return;}

            AddNodes();

            // Change connect button
            tcmd_Connect.Enabled = false;
            tcmd_Connect.Text = "Connected";

            // Enable expand/collapse buttons
            cmd_Collapse_All.Enabled = true;
            cmd_Expand_All.Enabled = true;

            // Enable the Open URL button
            tcmd_Open_URL.Enabled = true;

            tos_Menu.Refresh();
        }

        private void AddNodes()
        {
            // Get the SharePoint web  
            Web web = clientContext.Web;

            // Load lists
            clientContext.Load(web.Webs);

            // Execute the query to the server  
            clientContext.ExecuteQuery();

            // Update the progress bar
            tprg_Site.Minimum = 0;

            // Set the maximum for the progress bar
            tprg_Site.Maximum = web.Webs.Count + 1;

            // Update the progress bar
            tprg_Site.Value = 0;

            // Show the progress bar
            tprg_Site.Visible = true;

            // Add top level node
            TreeNode node = tvw_Site.Nodes.Add(web.Title);
            node.Tag = web.Url;

            // Update the progress bar
            tprg_Site.Value++;
            tos_Menu.Refresh();

            // Refresh the treeview for visual effect
            tvw_Site.Refresh();

            // Recursively add sub-nodes
            AddSubNodes(web, node);

            // Update the progress bar
            tprg_Site.Value = 0;
        }

        private void AddSubNodes(Web web, TreeNode node)
        {
            // Load lists
            clientContext.Load(web.Webs);

            // Execute the query to the server  
            clientContext.ExecuteQuery();

            // Loop through all the webs  
            foreach (Web subWeb in web.Webs)
            {
                // Check whether it is an app URL or not - If not then get into this block  
                if (subWeb.Url.Contains(web.Url))
                {
                    // Add a node
                    TreeNode n = node.Nodes.Add(subWeb.Title);
                    n.Tag = subWeb.Url;

                    // Expand first level nodes & update progress bar
                    if (n.Level == 1)
                    {
                        // Update the progress bar
                        tprg_Site.Value++;
                        tos_Menu.Refresh();

                        // Expand the top level node if required
                        if (node.IsExpanded == false)
                        {
                            node.Expand();
                        }

                        // Refresh the treeview control
                        tvw_Site.Refresh();
                    }                    

                    // Call procedure recursively
                    AddSubNodes(subWeb, n);
                }
            }
        }

        private void ShowCredentialsForm()
        {
            frm_Credentials credForm = new frm_Credentials(this);
            credForm.ShowDialog();
        }

        private ClientContext GetClient()
        {
            string errorMessage = "";

            // Get client
            ClientContext clientContext = cls_SharePoint.GetClient(url, username, password, ref errorMessage);

            if (clientContext == null)
            {
                MessageBox.Show(errorMessage);
                return null;
            }

            return clientContext;
        }

        private void cmd_Collapse_All_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in tvw_Site.Nodes[0].Nodes)
            {
                n.Collapse();
            }
            tvw_Site.Select();
        }

        private void cmd_Expand_All_Click(object sender, EventArgs e)
        {
            tvw_Site.ExpandAll();
            tvw_Site.Select();
        }

        private void tvw_Site_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(tvw_Site.SelectedNode.Tag.ToString());
        }

        private void tcmd_Open_URL_Click(object sender, EventArgs e)
        {
            if(tvw_Site.Nodes.Count == 0)
            {
                tcmd_Open_URL.Enabled = false;
                return;
            }
            
            TreeNode node = tvw_Site.SelectedNode;

            if(node != null)
            {
                string url = tvw_Site.SelectedNode.Tag.ToString();

                System.Diagnostics.Process.Start(url);
            }
            else
            {
                MessageBox.Show("Please select a site");
                tvw_Site.Select();
            }
        }
    }
}
