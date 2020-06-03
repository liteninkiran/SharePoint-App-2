using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;

namespace SharePoint_App_2
{
    public partial class frm_Site : System.Windows.Forms.Form
    {
        // Store the SharePoint connection
        ClientContext clientContext;

        // Stores a list of Sites
        List<Web> subWebs = new List<Web>();

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
            //MessageBox.Show(tcmd_View_Lists.Text);

            GetLists();
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

            // Store Web in collection
            subWebs.Add(web);

            // Add top level node
            TreeNode node = tvw_Site.Nodes.Add(web.Title);
            node.Tag = 0;

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
                    // Add item to collection
                    subWebs.Add(subWeb);

                    // Add a node
                    TreeNode n = node.Nodes.Add(subWeb.Title);
                    n.Tag = subWebs.Count - 1;

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
            if (tvw_Site.GetNodeCount(true) == 0)
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
                Web web = GetWeb();
                string url = web.Url;

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
            // Update header label
            lbl_Site_Name.Text = reset ? "" : tvw_Site.SelectedNode.Text;

            // Get the site
            Web web = GetWeb();

            // Derive the caption text
            string caption = reset ? "SharePoint Sites" : (web == null ? "" : web.Url);

            // Update form caption
            this.Text = caption;
        }

        private Web GetWeb(TreeNode node = null)
        {
            // Return NULL if there aren't any nodes on the tree
            if(tvw_Site.GetNodeCount(true) == 0)
            {
                return null;
            }

            // Check if a node has been supplied
            if(node == null)
            {
                // Use the selected node
                node = tvw_Site.SelectedNode;

                // Check there is a selcted node
                if (node == null)
                {
                    // Use the base node
                    node = tvw_Site.Nodes[0];

                    // Ensure it is selected
                    tvw_Site.SelectedNode = node;
                }
            }

            // Store the index from the node's tag
            int i = (int)node.Tag;

            // Return the web
            return subWebs[i];
        }

        private void GetLists()
        {
            // Get the site
            Web web = GetWeb();

            // Retreive lists
            clientContext.Load(web.Lists);
            clientContext.ExecuteQuery();

            // Clear the datagridview
            dgv_List.Rows.Clear();
            dgv_List.Columns.Clear();

            // Add columns to datagridview
            AddColumnsList();

            int i = 0;

            // Loop through each list
            foreach (SP.List oList in web.Lists)
            {
                clientContext.Load(oList.DefaultView);
                clientContext.ExecuteQuery();

                SP.View oView = oList.DefaultView;

                string viewTitle;
                string viewUrl;
                string listUrl;
                string siteUrl = web.Url;
                string listType = GetBaseTypeDescription(oList.BaseType);

                try
                {
                    viewTitle = oView.Title;
                    viewUrl = oView.ServerRelativeUrl;
                    listUrl = clientContext.Url + viewUrl;
                }
                catch (Exception ex)
                {
                    listUrl = "";
                    viewTitle = "";
                }


                dgv_List.Rows.Add();

                dgv_List[0, i].Value = i;
                dgv_List[1, i].Value = web.Title;
                dgv_List[2, i].Value = siteUrl;
                dgv_List[3, i].Value = oList.Title;
                dgv_List[4, i].Value = oList.Description;
                dgv_List[5, i].Value = listType;
                dgv_List[6, i].Value = viewTitle;
                dgv_List[7, i].Value = !oList.DisableGridEditing;
                dgv_List[8, i].Value = 0;
                dgv_List[9, i].Value = 0;
                dgv_List[10, i].Value = oList.ItemCount;
                dgv_List[11, i].Value = oList.Id.ToString();
                dgv_List[12, i].Value = oList.Created.ToString();
                dgv_List[13, i].Value = listUrl;

                dgv_List.Refresh();

                i++;
            }
           
        }

        private string GetBaseTypeDescription(SP.BaseType baseType)
        {
            string listType = null;

            switch ((int)baseType)
            {
                case -1: listType = "None"; break;
                case 0: listType = "List"; break;
                case 1: listType = "Document Library"; break;
                case 2: listType = "Unused"; break;
                case 3: listType = "Discussion Board"; break;
                case 4: listType = "Survey"; break;
                case 5: listType = "Issue"; break;
            }

            return listType;
        }

        public void AddColumnsList()
        {
            // Create a linked column for URL
            DataGridViewLinkColumn lnk = new DataGridViewLinkColumn();
            lnk.HeaderText = "Site URL";
            lnk.Name = "url";
            lnk.UseColumnTextForLinkValue = false;

            DataGridViewCheckBoxColumn checkEdit = new DataGridViewCheckBoxColumn();
            checkEdit.HeaderText = "Quick Edit";
            checkEdit.Name = "quickEdit";

            DataGridViewColumn col = null;

            col = dgv_List.Columns[dgv_List.Columns.Add("rowNumber", "Number")]; col.ValueType = typeof(int);
            col = dgv_List.Columns[dgv_List.Columns.Add("siteName", "Site Name")];
            col = dgv_List.Columns[dgv_List.Columns.Add("siteAddress", "Site Address")];
            col = dgv_List.Columns[dgv_List.Columns.Add("listName", "List Name")];
            col = dgv_List.Columns[dgv_List.Columns.Add("description", "Description")];
            col = dgv_List.Columns[dgv_List.Columns.Add("baseType", "Type")];
            col = dgv_List.Columns[dgv_List.Columns.Add("defaultView", "Default View")];
            col = dgv_List.Columns[dgv_List.Columns.Add(checkEdit)];
            col = dgv_List.Columns[dgv_List.Columns.Add("fieldCount", "Field Count")]; col.ValueType = typeof(int);
            col = dgv_List.Columns[dgv_List.Columns.Add("viewCount", "View Count")]; col.ValueType = typeof(int);
            col = dgv_List.Columns[dgv_List.Columns.Add("itemCount", "Item Count")]; col.ValueType = typeof(int);
            col = dgv_List.Columns[dgv_List.Columns.Add("listId", "GUID")];
            col = dgv_List.Columns[dgv_List.Columns.Add("created", "Created")]; col.ValueType = typeof(DateTime);
            col = dgv_List.Columns[dgv_List.Columns.Add(lnk)];
        }
    }
}
