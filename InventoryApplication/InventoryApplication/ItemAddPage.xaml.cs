using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InventoryApplication
{
   
    public partial class ItemAddPage : ContentPage
    {
        public ItemAddPage()
        {
            InitializeComponent();
        }

        public void ReturnItem(object sender, EventArgs e)
        {
            App.Database.SaveItem(new Models.Item() { itemName = itemName.Text,
                itemCoast = Convert.ToDouble(itemCoast.Text),
                itemsCount = Convert.ToInt16(itemsCount.Text)});
            Navigation.PopModalAsync();
        }
    }
}