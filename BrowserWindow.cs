using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Web;

namespace WebBrowser.UI
{
    public partial class BrowserWindow : Form
    {
        public BrowserWindow()
        {
            InitializeComponent();
            browserBar1.Dock = DockStyle.Fill;
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Laurel Walker Davis.\nAuburn University Student\nllw0008@auburn.edu");
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserBar newBrwBar = new BrowserBar();
            newBrwBar.Dock = DockStyle.Fill;

            TabPage newTab = new TabPage("Tab " + (tabControl1.TabPages.Count + 1));
            newTab.Controls.Add(newBrwBar);            
            tabControl1.TabPages.Add(newTab);
            tabControl1.SelectedTab = newTab;
        }

        private void closeCurrentTabMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm historyForm = new HistoryManagerForm();
            historyForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm bookmarkForm = new BookmarkManagerForm();
            bookmarkForm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteAllHistoryItems();
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var current = tabControl1.SelectedTab;
            browserBar1.HtmlPage();      
        }

        private void nextTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = tabControl1.TabCount;
            int current = tabControl1.SelectedIndex;
            int next = current + 1;

            if (next < count)
                tabControl1.SelectedIndex = next;
            else
                tabControl1.SelectedIndex = 0;
        }        

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserBar1.printPage();
        }

        private void browserBar1_MouseHover(object sender, EventArgs e)
        {
            browserBar1.htmlLabel.Text = browserBar1.addressBox.Text;
        }

        private void browserBar1_MouseLeave(object sender, EventArgs e)
        {
            browserBar1.htmlLabel.Text = "";
        }

        private void browserBar1_MouseEnter(object sender, EventArgs e)
        {
            browserBar1.htmlLabel.Text = browserBar1.addressBox.Text;
        }

    }
}
