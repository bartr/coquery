namespace coquery
{
    partial class frmMain
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.AcceptsReturn = true;
            this.txtQuery.AcceptsTab = true;
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(0, 40);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(1417, 240);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.WordWrap = false;
            // 
            // txtResults
            // 
            this.txtResults.AcceptsReturn = true;
            this.txtResults.AcceptsTab = true;
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(0, 284);
            this.txtResults.Margin = new System.Windows.Forms.Padding(2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(1417, 552);
            this.txtResults.TabIndex = 1;
            this.txtResults.WordWrap = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuTools,
            this.mnuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1417, 33);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 29);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(205, 30);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.MnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(205, 30);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.MnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(205, 30);
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.MnuFileSaveAs_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(205, 30);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewQuery,
            this.mnuViewResults,
            this.mnuViewZoom});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(61, 29);
            this.mnuView.Text = "&View";
            // 
            // mnuViewQuery
            // 
            this.mnuViewQuery.Name = "mnuViewQuery";
            this.mnuViewQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuViewQuery.Size = new System.Drawing.Size(213, 30);
            this.mnuViewQuery.Text = "&Query";
            this.mnuViewQuery.Click += new System.EventHandler(this.MnuViewQuery_Click);
            // 
            // mnuViewResults
            // 
            this.mnuViewResults.Name = "mnuViewResults";
            this.mnuViewResults.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuViewResults.Size = new System.Drawing.Size(213, 30);
            this.mnuViewResults.Text = "&Results";
            this.mnuViewResults.Click += new System.EventHandler(this.MnuViewResults_Click);
            // 
            // mnuViewZoom
            // 
            this.mnuViewZoom.Name = "mnuViewZoom";
            this.mnuViewZoom.Size = new System.Drawing.Size(213, 30);
            this.mnuViewZoom.Text = "&Zoom";
            this.mnuViewZoom.Click += new System.EventHandler(this.MnuViewZoom_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsExecute,
            this.mnuToolsLogin});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(65, 29);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsExecute
            // 
            this.mnuToolsExecute.Name = "mnuToolsExecute";
            this.mnuToolsExecute.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuToolsExecute.Size = new System.Drawing.Size(215, 30);
            this.mnuToolsExecute.Text = "&Execute";
            this.mnuToolsExecute.Click += new System.EventHandler(this.MnuToolsExecute_Click);
            // 
            // mnuToolsLogin
            // 
            this.mnuToolsLogin.Name = "mnuToolsLogin";
            this.mnuToolsLogin.Size = new System.Drawing.Size(215, 30);
            this.mnuToolsLogin.Text = "&Login";
            this.mnuToolsLogin.Click += new System.EventHandler(this.MnuToolsLogin_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 29);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelpAbout.Size = new System.Drawing.Size(177, 30);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.MnuHelpAbout_Click);
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 838);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1417, 30);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.Text = "Ready";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 868);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.Text = "CosmosDB Query Tool";
            this.Load += new System.EventHandler(this.FormLoad);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewZoom;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsExecute;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuViewQuery;
        private System.Windows.Forms.ToolStripMenuItem mnuViewResults;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsLogin;
    }
}

