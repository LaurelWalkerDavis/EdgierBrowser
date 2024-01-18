using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();  
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();
            foreach(var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static List<HistoryItem> GetHistorySearchItems(string keyword)
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetDataBy(keyword);
            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static int DeleteHistoryEntryItem(int Id)
        {
            var adapter = new HistoryTableAdapter();
            int rows = adapter.DeleteEntry(Id);
            return rows;
        }

        public static void DeleteAllHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            adapter.DeleteAllHistoryQuery();
        }
    }
}
