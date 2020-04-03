using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;    

namespace ChromiumBrowser
{
    public partial class BrowserChromiumEdition : Form
    {

        public ChromiumWebBrowser browser;

        public BrowserChromiumEdition()
        {
            InitializeComponent();
            InitializeBrowser();
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            browserTabs.Dock = DockStyle.Bottom;
            browserTabs.Height = ClientRectangle.Height - 30;
            browserTabs.Controls.Clear();
            AddBrowserTab(null);
    
        }

        private void browserTabs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < browserTabs.TabCount; ++i)
                {
                    if (browserTabs.GetTabRect(i).Contains(e.Location))
                    {
                        
                        try
                        {
                            int selectedTabIndex = browserTabs.SelectedIndex;
                            browserTabs.TabPages[i].Dispose();
                            browserTabs.SelectedTab = browserTabs.TabPages[selectedTabIndex - 1];
                        }
                        catch
                        {

                        }
                        break;
                    }
                }
            }
        }

        public void InitializeBrowser()
        {
            Cef.Initialize(new CefSettings());
        }

        private void butnGo_Click(object sender, EventArgs e)
        {
            LoadActiveBrowser();
        }

        private void BrowserChromiumEdition_Resize(object sender, EventArgs e)
        {
            browserTabs.Height = ClientRectangle.Height - 30;
            
        }


        private void AddBrowserTab(string s)
        {
            TabPage newTab = new TabPage();
            newTab.Text = "tab";
            browserTabs.Controls.Add(newTab);
            if(s == null)
            {
                browser = new ChromiumWebBrowser("www.google.com");
            }
            else
            {
                browser = new ChromiumWebBrowser(s);
            }
            browser.Dock = DockStyle.Fill;
            newTab.Controls.Add(browser);
            browserTabs.SelectedTab = newTab;
        }



        private void butnAddTab_Click(object sender, EventArgs e)
        {
            AddBrowserTab(null);
        }

        private void butnRefresh_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser openedBrowser = (ChromiumWebBrowser)browserTabs.SelectedTab.Controls[0];
            openedBrowser.Reload();
        }

        private void LoadActiveBrowser()
        {
            try
            {
                ChromiumWebBrowser openedBrowser = (ChromiumWebBrowser)browserTabs.SelectedTab.Controls[0];
                openedBrowser.Load(tboxAddressBar.Text);
            }
            catch
            {
                AddBrowserTab(tboxAddressBar.Text);
            }
        }

        private void tboxAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadActiveBrowser();
            }
        }

        private void butnBack_Click(object sender, EventArgs e)
        {
            if (browserTabs.TabCount > 0)
            {
                ChromiumWebBrowser openedBrowser = (ChromiumWebBrowser)browserTabs.SelectedTab.Controls[0];
                if (openedBrowser.CanGoBack)
                {
                    openedBrowser.Back();
                }
            }
        }

        private void butnForward_Click(object sender, EventArgs e)
        {
            if(browserTabs.TabCount > 0)
            {
                ChromiumWebBrowser openedBrowser = (ChromiumWebBrowser)browserTabs.SelectedTab.Controls[0];
                if (openedBrowser.CanGoForward)
                {
                    openedBrowser.Forward();
                }
            }

        }

        private void tboxAddressBar_MouseDown(object sender, MouseEventArgs e)
        {
            tboxAddressBar.SelectAll();
        }

        private void butnDelete_Click(object sender, EventArgs e)
        {
            if(browserTabs.TabCount > 0)
            {
                try
                {
                    int selectedTabIndex = browserTabs.SelectedIndex;
                    browserTabs.SelectedTab.Dispose();
                    browserTabs.SelectedTab = browserTabs.TabPages[selectedTabIndex - 1];
                }
                catch
                {

                }

            }
        }
    }
}
