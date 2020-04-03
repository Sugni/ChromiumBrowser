namespace ChromiumBrowser
{
    partial class BrowserChromiumEdition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserChromiumEdition));
            this.browserTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butnGo = new System.Windows.Forms.ToolStripButton();
            this.tboxAddressBar = new System.Windows.Forms.ToolStripTextBox();
            this.butnAddTab = new System.Windows.Forms.ToolStripButton();
            this.butnRefresh = new System.Windows.Forms.ToolStripButton();
            this.butnBack = new System.Windows.Forms.ToolStripButton();
            this.butnForward = new System.Windows.Forms.ToolStripButton();
            this.butnDelete = new System.Windows.Forms.ToolStripButton();
            this.browserTabs.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserTabs
            // 
            this.browserTabs.Controls.Add(this.tabPage1);
            this.browserTabs.Controls.Add(this.tabPage2);
            this.browserTabs.Location = new System.Drawing.Point(-1, 30);
            this.browserTabs.Name = "browserTabs";
            this.browserTabs.SelectedIndex = 0;
            this.browserTabs.Size = new System.Drawing.Size(798, 416);
            this.browserTabs.TabIndex = 2;
            this.browserTabs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.browserTabs_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butnGo,
            this.tboxAddressBar,
            this.butnAddTab,
            this.butnDelete,
            this.butnRefresh,
            this.butnBack,
            this.butnForward});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butnGo
            // 
            this.butnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnGo.Image = ((System.Drawing.Image)(resources.GetObject("butnGo.Image")));
            this.butnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnGo.Name = "butnGo";
            this.butnGo.Size = new System.Drawing.Size(32, 24);
            this.butnGo.Text = "Go";
            this.butnGo.Click += new System.EventHandler(this.butnGo_Click);
            // 
            // tboxAddressBar
            // 
            this.tboxAddressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxAddressBar.Name = "tboxAddressBar";
            this.tboxAddressBar.Size = new System.Drawing.Size(400, 27);
            this.tboxAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxAddressBar_KeyDown);
            this.tboxAddressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tboxAddressBar_MouseDown);
            // 
            // butnAddTab
            // 
            this.butnAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnAddTab.Image = ((System.Drawing.Image)(resources.GetObject("butnAddTab.Image")));
            this.butnAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnAddTab.Name = "butnAddTab";
            this.butnAddTab.Size = new System.Drawing.Size(29, 24);
            this.butnAddTab.Text = "+";
            this.butnAddTab.Click += new System.EventHandler(this.butnAddTab_Click);
            // 
            // butnRefresh
            // 
            this.butnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butnRefresh.Image")));
            this.butnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnRefresh.Name = "butnRefresh";
            this.butnRefresh.Size = new System.Drawing.Size(29, 24);
            this.butnRefresh.Text = "⟲";
            this.butnRefresh.Click += new System.EventHandler(this.butnRefresh_Click);
            // 
            // butnBack
            // 
            this.butnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnBack.Image = ((System.Drawing.Image)(resources.GetObject("butnBack.Image")));
            this.butnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnBack.Name = "butnBack";
            this.butnBack.Size = new System.Drawing.Size(29, 24);
            this.butnBack.Text = "↶";
            this.butnBack.Click += new System.EventHandler(this.butnBack_Click);
            // 
            // butnForward
            // 
            this.butnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnForward.Image = ((System.Drawing.Image)(resources.GetObject("butnForward.Image")));
            this.butnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnForward.Name = "butnForward";
            this.butnForward.Size = new System.Drawing.Size(29, 24);
            this.butnForward.Text = "↷";
            this.butnForward.Click += new System.EventHandler(this.butnForward_Click);
            // 
            // butnDelete
            // 
            this.butnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butnDelete.Image = ((System.Drawing.Image)(resources.GetObject("butnDelete.Image")));
            this.butnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butnDelete.Name = "butnDelete";
            this.butnDelete.Size = new System.Drawing.Size(29, 24);
            this.butnDelete.Text = "-";
            this.butnDelete.Click += new System.EventHandler(this.butnDelete_Click);
            // 
            // BrowserChromiumEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.browserTabs);
            this.Name = "BrowserChromiumEdition";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.BrowserChromiumEdition_Resize);
            this.browserTabs.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl browserTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butnGo;
        private System.Windows.Forms.ToolStripTextBox tboxAddressBar;
        private System.Windows.Forms.ToolStripButton butnAddTab;
        private System.Windows.Forms.ToolStripButton butnRefresh;
        private System.Windows.Forms.ToolStripButton butnBack;
        private System.Windows.Forms.ToolStripButton butnForward;
        private System.Windows.Forms.ToolStripButton butnDelete;
    }
}

