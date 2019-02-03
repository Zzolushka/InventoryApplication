using InventoryApplication.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace InventoryApplication
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Items.db";
        public static ItemRepository database;
        public static ItemRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
