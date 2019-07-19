using licenceServicesDemo2.MenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace licenceServicesDemo2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MasterDetailPageItem RootPage { get => Application.Current.MainPage as MasterDetailPageItem; }
        List<MasterPageItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

           

            menuItems = new List<MasterPageItem>
            {
                new MasterPageItem {ID = MenuItemType.Server, Title="Server List" },
                new MasterPageItem {ID = MenuItemType.Feature, Title="Features" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[1];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((MasterPageItem)e.SelectedItem).ID;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}