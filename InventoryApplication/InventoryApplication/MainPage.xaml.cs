using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InventoryApplication
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            itemsList.ItemsSource = App.Database.GetItems();
            this.BindingContext = this;
        }

        //private void AddItem(object sender, EventArgs e)
        //{ 
        //    Items.Add(itemNameEntry.Text);
        //}

        private void RemoveItem(object sender, EventArgs e)
        {
            Item item = itemsList.SelectedItem as Item;
            if (item != null)
            {
                Items.Remove(item);
                itemsList.SelectedItem = null;
            }
        }

        private async void ToItemAddPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ItemAddPage());
        }


    }
}
