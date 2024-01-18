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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void bookmarkSearchButton_Click(object sender, EventArgs e)
        {
            string toFind = bookmarkSearchTextBox.Text;
            var items = BookmarksManager.GetBookmarkSearchItems(toFind);
            listBoxBookmark.DataSource = items;
        }

        private void listBoxBookmark_Format(object sender, ListControlConvertEventArgs e)
        {
            BookmarkItem bookmarkItem = (BookmarkItem)e.ListItem;
            e.Value = string.Format("{0} ({1})", bookmarkItem.Title, bookmarkItem.URL);
        }

        private void deleteBookmarkButton_Click(object sender, EventArgs e)
        {
            BookmarkItem item = (BookmarkItem)listBoxBookmark.SelectedItem;
            BookmarksManager.DeleteBookmarkEntryItem(item.Id);
            load_data();
        }

        private void load_data()
        {
            var items = BookmarksManager.GetBookmarksItems();
            listBoxBookmark.DataSource = items;
        }
    }
}
