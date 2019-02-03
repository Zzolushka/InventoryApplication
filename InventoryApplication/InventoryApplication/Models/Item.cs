using SQLite;

namespace InventoryApplication.Models
{
    //public class Item
    //{
    //    private string itemName;
    //    private int itemsCount;
    //    private double itemCoast;
    //    private string itemDescription;
    //    private double itemImage;

    //    public string getItemName { get => itemName;}
    //    public int getItemsCount { get => itemsCount;}
    //    public double getItemCoast { get => itemCoast;}
    //    public string getItemDescription { get => itemDescription;}
    //    public double getItemImage { get => itemImage;}


    //    public string setItemName {set => itemName = value; }
    //    public int setItemsCount {set => itemsCount = value; }
    //    public double setItemCoast {set => itemCoast = value; }
    //    public string setItemDescription {set => itemDescription = value; }
    //    public double setItemImage {set => itemImage = value; }

    //    public double GetSum()
    //    {
    //        double sum = itemsCount * itemCoast * 1.0;
    //        return sum;
    //    }
    //}

    [Table("Items")]
    public class Item
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int itemId { get; set; }

        public string itemName { get; set; }
        public double itemCoast { get; set; }
        public int itemsCount { get; set; }
    }
}
