namespace SharePoint_App_2
{
    partial class frm_Site
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Site));
            this.tvw_Site = new System.Windows.Forms.TreeView();
            this.tos_Menu = new System.Windows.Forms.ToolStrip();
            this.tcmd_Credentials = new System.Windows.Forms.ToolStripButton();
            this.tprg_Site = new System.Windows.Forms.ToolStripProgressBar();
            this.tcmd_Connect = new System.Windows.Forms.ToolStripButton();
            this.cmd_Close = new System.Windows.Forms.Button();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.spc_Site = new System.Windows.Forms.SplitContainer();
            this.spc_Tree = new System.Windows.Forms.SplitContainer();
            this.tos_Tree = new System.Windows.Forms.ToolStrip();
            this.tcmd_Collapse_All = new System.Windows.Forms.ToolStripButton();
            this.tcmd_Expand_All = new System.Windows.Forms.ToolStripButton();
            this.tcmd_Open_URL = new System.Windows.Forms.ToolStripButton();
            this.tcmd_View_Lists = new System.Windows.Forms.ToolStripButton();
            this.spc_Grid = new System.Windows.Forms.SplitContainer();
            this.tos_Grid = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.lbl_Site_Name = new System.Windows.Forms.Label();
            this.tos_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Site)).BeginInit();
            this.spc_Site.Panel1.SuspendLayout();
            this.spc_Site.Panel2.SuspendLayout();
            this.spc_Site.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Tree)).BeginInit();
            this.spc_Tree.Panel1.SuspendLayout();
            this.spc_Tree.Panel2.SuspendLayout();
            this.spc_Tree.SuspendLayout();
            this.tos_Tree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Grid)).BeginInit();
            this.spc_Grid.Panel1.SuspendLayout();
            this.spc_Grid.Panel2.SuspendLayout();
            this.spc_Grid.SuspendLayout();
            this.tos_Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvw_Site
            // 
            this.tvw_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw_Site.Location = new System.Drawing.Point(0, 0);
            this.tvw_Site.Name = "tvw_Site";
            this.tvw_Site.Size = new System.Drawing.Size(150, 190);
            this.tvw_Site.TabIndex = 0;
            this.tvw_Site.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_Site_AfterSelect);
            this.tvw_Site.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_Site_NodeMouseClick);
            // 
            // tos_Menu
            // 
            this.tos_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmd_Credentials,
            this.tprg_Site,
            this.tcmd_Connect});
            this.tos_Menu.Location = new System.Drawing.Point(0, 0);
            this.tos_Menu.Name = "tos_Menu";
            this.tos_Menu.Size = new System.Drawing.Size(540, 25);
            this.tos_Menu.TabIndex = 1;
            this.tos_Menu.Text = "toolStrip1";
            // 
            // tcmd_Credentials
            // 
            this.tcmd_Credentials.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Credentials.Image")));
            this.tcmd_Credentials.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Credentials.Name = "tcmd_Credentials";
            this.tcmd_Credentials.Size = new System.Drawing.Size(116, 22);
            this.tcmd_Credentials.Text = "Enter Credentials";
            this.tcmd_Credentials.Click += new System.EventHandler(this.tcmd_Credentials_Click);
            // 
            // tprg_Site
            // 
            this.tprg_Site.Name = "tprg_Site";
            this.tprg_Site.Size = new System.Drawing.Size(100, 22);
            // 
            // tcmd_Connect
            // 
            this.tcmd_Connect.Enabled = false;
            this.tcmd_Connect.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Connect.Image")));
            this.tcmd_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Connect.Name = "tcmd_Connect";
            this.tcmd_Connect.Size = new System.Drawing.Size(99, 22);
            this.tcmd_Connect.Text = "Disconnected";
            this.tcmd_Connect.Click += new System.EventHandler(this.tcmd_Connect_Click);
            // 
            // cmd_Close
            // 
            this.cmd_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Close.Location = new System.Drawing.Point(428, 298);
            this.cmd_Close.Name = "cmd_Close";
            this.cmd_Close.Size = new System.Drawing.Size(93, 43);
            this.cmd_Close.TabIndex = 2;
            this.cmd_Close.Text = "Close";
            this.cmd_Close.UseVisualStyleBackColor = true;
            this.cmd_Close.Click += new System.EventHandler(this.cmd_Close_Click);
            // 
            // dgv_List
            // 
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_List.Location = new System.Drawing.Point(0, 0);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.Size = new System.Drawing.Size(355, 190);
            this.dgv_List.TabIndex = 6;
            // 
            // spc_Site
            // 
            this.spc_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc_Site.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Site.Location = new System.Drawing.Point(12, 68);
            this.spc_Site.Name = "spc_Site";
            // 
            // spc_Site.Panel1
            // 
            this.spc_Site.Panel1.Controls.Add(this.spc_Tree);
            // 
            // spc_Site.Panel2
            // 
            this.spc_Site.Panel2.Controls.Add(this.spc_Grid);
            this.spc_Site.Size = new System.Drawing.Size(509, 224);
            this.spc_Site.SplitterDistance = 150;
            this.spc_Site.TabIndex = 7;
            // 
            // spc_Tree
            // 
            this.spc_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Tree.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Tree.IsSplitterFixed = true;
            this.spc_Tree.Location = new System.Drawing.Point(0, 0);
            this.spc_Tree.Name = "spc_Tree";
            this.spc_Tree.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_Tree.Panel1
            // 
            this.spc_Tree.Panel1.Controls.Add(this.tos_Tree);
            // 
            // spc_Tree.Panel2
            // 
            this.spc_Tree.Panel2.Controls.Add(this.tvw_Site);
            this.spc_Tree.Size = new System.Drawing.Size(150, 224);
            this.spc_Tree.SplitterDistance = 30;
            this.spc_Tree.TabIndex = 0;
            // 
            // tos_Tree
            // 
            this.tos_Tree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmd_Collapse_All,
            this.tcmd_Expand_All,
            this.tcmd_Open_URL,
            this.tcmd_View_Lists});
            this.tos_Tree.Location = new System.Drawing.Point(0, 0);
            this.tos_Tree.Name = "tos_Tree";
            this.tos_Tree.Size = new System.Drawing.Size(150, 25);
            this.tos_Tree.TabIndex = 0;
            this.tos_Tree.Text = "toolStrip1";
            // 
            // tcmd_Collapse_All
            // 
            this.tcmd_Collapse_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tcmd_Collapse_All.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Collapse_All.Image")));
            this.tcmd_Collapse_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Collapse_All.Name = "tcmd_Collapse_All";
            this.tcmd_Collapse_All.Size = new System.Drawing.Size(23, 22);
            this.tcmd_Collapse_All.Text = "Collapse All";
            this.tcmd_Collapse_All.Click += new System.EventHandler(this.tcmd_Collapse_All_Click);
            // 
            // tcmd_Expand_All
            // 
            this.tcmd_Expand_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tcmd_Expand_All.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Expand_All.Image")));
            this.tcmd_Expand_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Expand_All.Name = "tcmd_Expand_All";
            this.tcmd_Expand_All.Size = new System.Drawing.Size(23, 22);
            this.tcmd_Expand_All.Text = "Expand All";
            this.tcmd_Expand_All.Click += new System.EventHandler(this.tcmd_Expand_All_Click);
            // 
            // tcmd_Open_URL
            // 
            this.tcmd_Open_URL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tcmd_Open_URL.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Open_URL.Image")));
            this.tcmd_Open_URL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Open_URL.Name = "tcmd_Open_URL";
            this.tcmd_Open_URL.Size = new System.Drawing.Size(23, 22);
            this.tcmd_Open_URL.Text = "Open URL";
            this.tcmd_Open_URL.Click += new System.EventHandler(this.tcmd_Open_URL_Click);
            // 
            // tcmd_View_Lists
            // 
            this.tcmd_View_Lists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tcmd_View_Lists.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_View_Lists.Image")));
            this.tcmd_View_Lists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_View_Lists.Name = "tcmd_View_Lists";
            this.tcmd_View_Lists.Size = new System.Drawing.Size(23, 22);
            this.tcmd_View_Lists.Text = "View Lists";
            this.tcmd_View_Lists.Click += new System.EventHandler(this.tcmd_View_Lists_Click);
            // 
            // spc_Grid
            // 
            this.spc_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Grid.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Grid.IsSplitterFixed = true;
            this.spc_Grid.Location = new System.Drawing.Point(0, 0);
            this.spc_Grid.Name = "spc_Grid";
            this.spc_Grid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_Grid.Panel1
            // 
            this.spc_Grid.Panel1.Controls.Add(this.tos_Grid);
            // 
            // spc_Grid.Panel2
            // 
            this.spc_Grid.Panel2.Controls.Add(this.dgv_List);
            this.spc_Grid.Size = new System.Drawing.Size(355, 224);
            this.spc_Grid.SplitterDistance = 30;
            this.spc_Grid.TabIndex = 0;
            // 
            // tos_Grid
            // 
            this.tos_Grid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6});
            this.tos_Grid.Location = new System.Drawing.Point(0, 0);
            this.tos_Grid.Name = "tos_Grid";
            this.tos_Grid.Size = new System.Drawing.Size(355, 25);
            this.tos_Grid.TabIndex = 0;
            this.tos_Grid.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // lbl_Site_Name
            // 
            this.lbl_Site_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Site_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Site_Name.Location = new System.Drawing.Point(-3, 25);
            this.lbl_Site_Name.Name = "lbl_Site_Name";
            this.lbl_Site_Name.Size = new System.Drawing.Size(543, 40);
            this.lbl_Site_Name.TabIndex = 8;
            this.lbl_Site_Name.Text = "label1";
            this.lbl_Site_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 353);
            this.Controls.Add(this.lbl_Site_Name);
            this.Controls.Add(this.spc_Site);
            this.Controls.Add(this.cmd_Close);
            this.Controls.Add(this.tos_Menu);
            this.Name = "frm_Site";
            this.Text = "SharePoint Sites";
            this.Load += new System.EventHandler(this.frm_Site_Load);
            this.tos_Menu.ResumeLayout(false);
            this.tos_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.spc_Site.Panel1.ResumeLayout(false);
            this.spc_Site.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Site)).EndInit();
            this.spc_Site.ResumeLayout(false);
            this.spc_Tree.Panel1.ResumeLayout(false);
            this.spc_Tree.Panel1.PerformLayout();
            this.spc_Tree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Tree)).EndInit();
            this.spc_Tree.ResumeLayout(false);
            this.tos_Tree.ResumeLayout(false);
            this.tos_Tree.PerformLayout();
            this.spc_Grid.Panel1.ResumeLayout(false);
            this.spc_Grid.Panel1.PerformLayout();
            this.spc_Grid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Grid)).EndInit();
            this.spc_Grid.ResumeLayout(false);
            this.tos_Grid.ResumeLayout(false);
            this.tos_Grid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Close;
        public System.Windows.Forms.TreeView tvw_Site;
        public System.Windows.Forms.ToolStrip tos_Menu;
        public System.Windows.Forms.ToolStripButton tcmd_Credentials;
        public System.Windows.Forms.ToolStripButton tcmd_Connect;
        private System.Windows.Forms.ToolStripProgressBar tprg_Site;
        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.SplitContainer spc_Site;
        private System.Windows.Forms.SplitContainer spc_Tree;
        private System.Windows.Forms.ToolStripButton tcmd_Collapse_All;
        private System.Windows.Forms.ToolStripButton tcmd_Expand_All;
        private System.Windows.Forms.ToolStripButton tcmd_View_Lists;
        private System.Windows.Forms.SplitContainer spc_Grid;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        public System.Windows.Forms.ToolStripButton tcmd_Open_URL;
        public System.Windows.Forms.ToolStrip tos_Tree;
        public System.Windows.Forms.ToolStrip tos_Grid;
        private System.Windows.Forms.Label lbl_Site_Name;
    }
}