﻿using System;
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


        private void frm_Site_Load(object sender, EventArgs e)
        {
            ResetControls();
            InitialiseForm();
        }

        private void tvw_Site_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Check if we are right-clicking
            if (e.Button == MouseButtons.Right)
            {
                // Select the entry that was right-clicked on
                tvw_Site.SelectedNode = e.Node;
            }
        }

        private void tvw_Site_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateLabels(false);
        }

        private void tcmd_Collapse_All_Click(object sender, EventArgs e)
        {
            // Loop through first level nodes and collapse
            foreach (TreeNode n in tvw_Site.Nodes[0].Nodes)
            {
                n.Collapse();
            }

            // Bring focus to control to show selected node
            tvw_Site.Select();
        }

        private void tcmd_Expand_All_Click(object sender, EventArgs e)
        {
            // Expand all nodes
            tvw_Site.ExpandAll();

            // Bring focus to control to show selected node
            tvw_Site.Select();
        }

        private void tcmd_View_Lists_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tcmd_View_Lists.Text);
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
            if (url == null || username == null || password == null)
            {
                // Tell user to enter credentials
                MessageBox.Show("Please enter credentials");

                // Open the credentials form
                ShowCredentialsForm();
            }

            // Try to get the client
            clientContext = GetClient();

            // Exit if we got an error
            if (clientContext == null) { return; }

            // Change button text
            tcmd_Connect.Enabled = false;
            tcmd_Connect.Text = "Connected";

            // Add nodes to the treeview control
            AddNodes();

            // Enable ToolStrip controls for TreeView
            EnableToolStripItems(this.tos_Tree, true);
        }

        private void tcmd_Open_URL_Click(object sender, EventArgs e)
        {
            OpenUrl();
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

            // Select the treeview control
            tvw_Site.Select();

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

        private void OpenUrl()
        {
            // Check we have entries
            if (tvw_Site.Nodes.Count == 0)
            {
                // Disable the control
                tcmd_Open_URL.Enabled = false;

                // Jump out
                return;
            }

            // Store the selected node
            TreeNode node = tvw_Site.SelectedNode;

            // Check we have selected a node
            if (node != null)
            {
                // Store URL from the node's tag
                string url = tvw_Site.SelectedNode.Tag.ToString();

                // Open up the browser and navigate to URL
                System.Diagnostics.Process.Start(url);
            }
            else
            {
                // Inform the user
                MessageBox.Show("Please select a site");

                // Select the TreeView control
                tvw_Site.Select();
            }
        }

        public void EnableToolStripItems(ToolStrip ts, bool enabled)
        {
            // Loop through all items in the ToolStrip control
            foreach (ToolStripItem tsi in ts.Items)
            {
                // Enable or disable control
                tsi.Enabled = enabled;
            }
        }

        private void InitialiseForm()
        {
            // Make form a bit bigger than it is in design view
            this.Height = 800;
            this.Width = 1000;

            // Maximise window
            this.WindowState = FormWindowState.Maximized;

            // Set the vertical splitter distance
            this.spc_Site.SplitterDistance = 300;
        }

        public void ResetControls()
        {
            UpdateLabels(true);

            // Disable all ToolStrip controls in the Panels
            EnableToolStripItems(this.tos_Tree, false);
            EnableToolStripItems(this.tos_Grid, false);

            // Enable the "Connect" button
            this.tcmd_Connect.Text = "Connect";
            this.tcmd_Connect.Enabled = true;

            // Clear the treeview control
            this.tvw_Site.Nodes.Clear();

            // Clear the DataGridView control
            this.dgv_List.Rows.Clear();
            this.dgv_List.Columns.Clear();
        }

        private void UpdateLabels(bool reset)
        {
            // Ternary operator
            // A ? B : C ==> if(A){B}else{C}

            // Update header label
            lbl_Site_Name.Text = reset ? "" : tvw_Site.SelectedNode.Text;

            // Update form caption
            this.Text = reset ? "SharePoint Sites" : tvw_Site.SelectedNode.Tag.ToString();
        }
    }
}
