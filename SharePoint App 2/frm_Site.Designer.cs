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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Site));
            this.tvw_Site = new System.Windows.Forms.TreeView();
            this.tos_Menu = new System.Windows.Forms.ToolStrip();
            this.tcmd_Credentials = new System.Windows.Forms.ToolStripButton();
            this.tprg_Site = new System.Windows.Forms.ToolStripProgressBar();
            this.tcmd_Connect = new System.Windows.Forms.ToolStripButton();
            this.tcmd_Open_URL = new System.Windows.Forms.ToolStripButton();
            this.cmd_Close = new System.Windows.Forms.Button();
            this.cmd_Collapse_All = new System.Windows.Forms.Button();
            this.cmd_Expand_All = new System.Windows.Forms.Button();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.spc_Site = new System.Windows.Forms.SplitContainer();
            this.cms_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_Site = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmi_Open_URL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tos_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Site)).BeginInit();
            this.spc_Site.Panel1.SuspendLayout();
            this.spc_Site.Panel2.SuspendLayout();
            this.spc_Site.SuspendLayout();
            this.cms_List.SuspendLayout();
            this.cms_Site.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvw_Site
            // 
            this.tvw_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw_Site.Location = new System.Drawing.Point(0, 0);
            this.tvw_Site.Name = "tvw_Site";
            this.tvw_Site.Size = new System.Drawing.Size(150, 344);
            this.tvw_Site.TabIndex = 0;
            this.tvw_Site.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_Site_NodeMouseClick);
            // 
            // tos_Menu
            // 
            this.tos_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmd_Credentials,
            this.tprg_Site,
            this.tcmd_Connect,
            this.tcmd_Open_URL});
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
            // tcmd_Open_URL
            // 
            this.tcmd_Open_URL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tcmd_Open_URL.Enabled = false;
            this.tcmd_Open_URL.Image = ((System.Drawing.Image)(resources.GetObject("tcmd_Open_URL.Image")));
            this.tcmd_Open_URL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tcmd_Open_URL.Name = "tcmd_Open_URL";
            this.tcmd_Open_URL.Size = new System.Drawing.Size(23, 22);
            this.tcmd_Open_URL.Text = "Open In Browser";
            this.tcmd_Open_URL.Click += new System.EventHandler(this.tcmd_Open_URL_Click);
            // 
            // cmd_Close
            // 
            this.cmd_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Close.Location = new System.Drawing.Point(428, 391);
            this.cmd_Close.Name = "cmd_Close";
            this.cmd_Close.Size = new System.Drawing.Size(93, 43);
            this.cmd_Close.TabIndex = 2;
            this.cmd_Close.Text = "Close";
            this.cmd_Close.UseVisualStyleBackColor = true;
            this.cmd_Close.Click += new System.EventHandler(this.cmd_Close_Click);
            // 
            // cmd_Collapse_All
            // 
            this.cmd_Collapse_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmd_Collapse_All.Enabled = false;
            this.cmd_Collapse_All.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Collapse_All.Image")));
            this.cmd_Collapse_All.Location = new System.Drawing.Point(12, 392);
            this.cmd_Collapse_All.Name = "cmd_Collapse_All";
            this.cmd_Collapse_All.Size = new System.Drawing.Size(16, 16);
            this.cmd_Collapse_All.TabIndex = 4;
            this.cmd_Collapse_All.UseVisualStyleBackColor = true;
            this.cmd_Collapse_All.Click += new System.EventHandler(this.cmd_Collapse_All_Click);
            // 
            // cmd_Expand_All
            // 
            this.cmd_Expand_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmd_Expand_All.Enabled = false;
            this.cmd_Expand_All.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Expand_All.Image")));
            this.cmd_Expand_All.Location = new System.Drawing.Point(35, 392);
            this.cmd_Expand_All.Name = "cmd_Expand_All";
            this.cmd_Expand_All.Size = new System.Drawing.Size(16, 16);
            this.cmd_Expand_All.TabIndex = 5;
            this.cmd_Expand_All.UseVisualStyleBackColor = true;
            this.cmd_Expand_All.Click += new System.EventHandler(this.cmd_Expand_All_Click);
            // 
            // dgv_List
            // 
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_List.Location = new System.Drawing.Point(0, 0);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.Size = new System.Drawing.Size(355, 344);
            this.dgv_List.TabIndex = 6;
            // 
            // spc_Site
            // 
            this.spc_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc_Site.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Site.Location = new System.Drawing.Point(12, 41);
            this.spc_Site.Name = "spc_Site";
            // 
            // spc_Site.Panel1
            // 
            this.spc_Site.Panel1.Controls.Add(this.tvw_Site);
            // 
            // spc_Site.Panel2
            // 
            this.spc_Site.Panel2.Controls.Add(this.dgv_List);
            this.spc_Site.Size = new System.Drawing.Size(509, 344);
            this.spc_Site.SplitterDistance = 150;
            this.spc_Site.TabIndex = 7;
            // 
            // cms_List
            // 
            this.cms_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.cms_List.Name = "cms_List";
            this.cms_List.Size = new System.Drawing.Size(104, 26);
            // 
            // cms_Site
            // 
            this.cms_Site.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_Open_URL});
            this.cms_Site.Name = "cms_Site";
            this.cms_Site.Size = new System.Drawing.Size(181, 48);
            // 
            // tmi_Open_URL
            // 
            this.tmi_Open_URL.Name = "tmi_Open_URL";
            this.tmi_Open_URL.Size = new System.Drawing.Size(180, 22);
            this.tmi_Open_URL.Text = "Open URL";
            this.tmi_Open_URL.Click += new System.EventHandler(this.tmi_Open_URL_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Open";
            // 
            // frm_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 446);
            this.Controls.Add(this.spc_Site);
            this.Controls.Add(this.cmd_Expand_All);
            this.Controls.Add(this.cmd_Collapse_All);
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
            this.cms_List.ResumeLayout(false);
            this.cms_Site.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Close;
        public System.Windows.Forms.TreeView tvw_Site;
        public System.Windows.Forms.ToolStrip tos_Menu;
        public System.Windows.Forms.ToolStripButton tcmd_Credentials;
        public System.Windows.Forms.ToolStripButton tcmd_Connect;
        private System.Windows.Forms.Button cmd_Collapse_All;
        private System.Windows.Forms.Button cmd_Expand_All;
        private System.Windows.Forms.ToolStripProgressBar tprg_Site;
        public System.Windows.Forms.ToolStripButton tcmd_Open_URL;
        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.SplitContainer spc_Site;
        private System.Windows.Forms.ContextMenuStrip cms_Site;
        private System.Windows.Forms.ToolStripMenuItem tmi_Open_URL;
        private System.Windows.Forms.ContextMenuStrip cms_List;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}