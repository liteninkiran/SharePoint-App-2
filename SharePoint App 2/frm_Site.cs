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
            tcmd_Connect.Text = "Connecting...";

            // Try to get the client
            clientContext = GetClient();

            // Exit if we got an error
            if (clientContext == null){return;}

            // Add nodes to the treeview control
            AddNodes();

            // Change connect button
            tcmd_Connect.Enabled = false;
            tcmd_Connect.Text = "Connected";

            // Enable expand/collapse buttons
            cmd_Collapse_All.Enabled = true;
            cmd_Expand_All.Enabled = true;

            // Enable the Open URL button
            tcmd_Open_URL.Enabled = true;

            // Refresh the tool strip menu
            tos_Menu.Refresh();

            // Assign the context menu strip
            tvw_Site.ContextMenuStrip = cms_Site;
            tvw_Site.Select();
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

            // Ensure a node is selected
            tvw_Site.SelectedNode = node;
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
            // Create new form
            frm_Credentials credForm = new frm_Credentials(this);

            // Show as dialog
            credForm.ShowDialog();
        }

        private ClientContext GetClient()
        {
            // Store error message
            string errorMessage = "";

            // Get client
            ClientContext clientContext = cls_SharePoint.GetClient(url, username, password, ref errorMessage);

            // If an error occured, the object will be NULL
            if (clientContext == null)
            {
                // Show user the message
                MessageBox.Show(errorMessage);
            }

            // Return the object
            return clientContext;
        }

        private void cmd_Collapse_All_Click(object sender, EventArgs e)
        {
            // Loop through first level nodes and collapse
            foreach (TreeNode n in tvw_Site.Nodes[0].Nodes)
            {
                n.Collapse();
            }

            // Bring focus to control to show selected node
            tvw_Site.Select();
        }

        private void cmd_Expand_All_Click(object sender, EventArgs e)
        {
            // Expand all nodes
            tvw_Site.ExpandAll();

            // Bring focus to control to show selected node
            tvw_Site.Select();
        }

        private void tcmd_Open_URL_Click(object sender, EventArgs e)
        {
            OprnUrl();
        }

        private void OprnUrl()
        {
            // Check we have entries
            if (tvw_Site.Nodes.Count == 0)
            {
                tcmd_Open_URL.Enabled = false;
                return;
            }

            // Store the selected node
            TreeNode node = tvw_Site.SelectedNode;

            if (node != null)
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

        private void frm_Site_Load(object sender, EventArgs e)
        {
            this.Height = 800;
            this.Width = 1000;
            this.WindowState = FormWindowState.Maximized;

            spc_Site.SplitterDistance = 300;
        }

        private void tvw_Site_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvw_Site.SelectedNode = e.Node;
            }
        }

        private void tmi_Open_URL_Click(object sender, EventArgs e)
        {
            OprnUrl();
        }
    }
}
