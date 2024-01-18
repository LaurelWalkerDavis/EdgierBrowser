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

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'historyDataSet.History' table. You can move, or remove it, as needed.
            load_data();
        }

        private void load_data()
        {
            var items = HistoryManager.GetHistoryItems();
            listBoxHistory.DataSource = items;
        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            string toFind = historySearchTextBox.Text;
            var items = HistoryManager.GetHistorySearchItems(toFind);
            listBoxHistory.DataSource = items;
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            HistoryItem item = (HistoryItem)listBoxHistory.SelectedItem;
            HistoryManager.DeleteHistoryEntryItem(item.Id);
            load_data();
        }

        private void listBoxHistory_Format(object sender, ListControlConvertEventArgs e)
        {
            var historyItem = (HistoryItem)e.ListItem;
            e.Value = string.Format("[{0}] {1} ({2})", historyItem.Date, historyItem.Title, historyItem.URL);
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteAllHistoryItems();
            load_data();
        }
    }
}
