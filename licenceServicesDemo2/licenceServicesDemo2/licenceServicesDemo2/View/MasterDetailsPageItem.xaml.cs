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
    public partial class MasterDetailsPageItem : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public MasterDetailsPageItem()
        {

            //MasterBehavior = MasterBehavior.Popover;
            InitializeComponent();

            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "Server List",
                //Icon = "homeicon.png",
                TargetType = typeof(ServerList)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Features",
                //Icon = "contacticon.png",
                TargetType = typeof(FeaturePage)
            });


            menuList.Add(new MasterPageItem()
            {
                Title = "Settingss"
            });


            menuList.Add(new MasterPageItem()
            {
                Title="Log out"
            });
            
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ServerList)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}