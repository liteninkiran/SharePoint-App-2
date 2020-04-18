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
            this.tcmd_Open_URL = new System.Windows.Forms.ToolStripButton();
            this.cmd_Close = new System.Windows.Forms.Button();
            this.cmd_Collapse_All = new System.Windows.Forms.Button();
            this.cmd_Expand_All = new System.Windows.Forms.Button();
            this.tos_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvw_Site
            // 
            this.tvw_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvw_Site.Location = new System.Drawing.Point(12, 38);
            this.tvw_Site.Name = "tvw_Site";
            this.tvw_Site.Size = new System.Drawing.Size(456, 351);
            this.tvw_Site.TabIndex = 0;
            this.tvw_Site.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_Site_AfterSelect);
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
            this.tos_Menu.Size = new System.Drawing.Size(481, 25);
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
            this.cmd_Close.Location = new System.Drawing.Point(375, 395);
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
            this.cmd_Collapse_All.Location = new System.Drawing.Point(12, 396);
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
            this.cmd_Expand_All.Location = new System.Drawing.Point(35, 396);
            this.cmd_Expand_All.Name = "cmd_Expand_All";
            this.cmd_Expand_All.Size = new System.Drawing.Size(16, 16);
            this.cmd_Expand_All.TabIndex = 5;
            this.cmd_Expand_All.UseVisualStyleBackColor = true;
            this.cmd_Expand_All.Click += new System.EventHandler(this.cmd_Expand_All_Click);
            // 
            // frm_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.cmd_Expand_All);
            this.Controls.Add(this.cmd_Collapse_All);
            this.Controls.Add(this.cmd_Close);
            this.Controls.Add(this.tos_Menu);
            this.Controls.Add(this.tvw_Site);
            this.Name = "frm_Site";
            this.Text = "SharePoint Sites";
            this.tos_Menu.ResumeLayout(false);
            this.tos_Menu.PerformLayout();
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
    }
}