using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace InventoryApplication.Models
{
    public class ItemRepository
    {
        SQLiteConnection database;
        public ItemRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Item>();
        }
        public IEnumerable<Item> GetItems()
        {
            return (from i in database.Table<Item>() select i).ToList();
        }
        public Item GetItem(int id)
        {
            return database.Get<Item>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Item>(id);
        }
        public int SaveItem(Item item)
        {
            if (item.itemId != 0)
            {
                database.Update(item);
                return item.itemId;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
