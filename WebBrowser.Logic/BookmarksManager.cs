using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarksManager
    {
        public static void AddBookmarksItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            Boolean duplicate = false;
            foreach (var entry in adapter.GetData())
            {
                if(entry.URL == item.URL)
                {
                    duplicate = true;
                }
            }
            if(!duplicate)
            {
                adapter.Insert(item.URL, item.Title, item.Id);
            }            
        }

        public static List<BookmarkItem> GetBookmarksItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static List<BookmarkItem> GetBookmarkSearchItems(string keyword)
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetDataBySearch(keyword);
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static int DeleteBookmarkEntryItem(int Id)
        {
            var adapter = new BookmarksTableAdapter();
            int rows = adapter.DeleteSelection(Id);
            return rows;
        }
    }
}
