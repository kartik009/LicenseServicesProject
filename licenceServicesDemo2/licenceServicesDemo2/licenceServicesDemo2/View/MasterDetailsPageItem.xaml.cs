using licenceServicesDemo2.Helper;
using licenceServicesDemo2.MenuItem;
using licenceServicesDemo2.Model;
using licenceServicesDemo2.View.Phone;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        TempUser temp;
        public ObservableCollection<MasterPageItem> AppUsermenuList
        {
            get;
            set;
        }

        public ObservableCollection<MasterPageItem> AdminmenuList
        {
            get;
            set;
        }
        public MasterDetailsPageItem()
        {

            //MasterBehavior = MasterBehavior.Popover;
            InitializeComponent();

            temp = new TempUser();


            temp.username = Settings.username;

            temp.type = Settings.Ttype;
           
                //temp.username = Convert.ToString(App.Current.Properties.ContainsKey("TUser"));

                //temp.type = Convert.ToString(App.Current.Properties.ContainsKey("TType"));
         
            
            AppUsermenuList = new ObservableCollection<MasterPageItem>();
            
            AdminmenuList = new ObservableCollection<MasterPageItem>();

            // Adding menu items to menuList and you can define title ,page and icon ==For App USer 
            AppUsermenuList.Add(new MasterPageItem()
            {
                Title = "Server List",
                //Icon = "homeicon.png",
                TargetType = typeof(TabbedPageSF)
            });

            //menuList.Add(new MasterPageItem()
            //{
            //    Title = "Features",
            //    //Icon = "contacticon.png",
            //    TargetType = typeof(FeaturePage)
            //});
                      

            AppUsermenuList.Add(new MasterPageItem()
            {
                Title = "Settings",
                TargetType = typeof(AppUserSettings)
            });



            AppUsermenuList.Add(new MasterPageItem()
            {
                Title="Log out"
            });




            // Adding menu items to menuList and you can define title ,page and icon ==For Admin USer 
            AdminmenuList.Add(new MasterPageItem()
            {
                Title = "Server List",
                //Icon = "homeicon.png",
                TargetType = typeof(TabbedPageSF)
            });

            //menuList.Add(new MasterPageItem()
            //{
            //    Title = "Features",
            //    //Icon = "contacticon.png",
            //    TargetType = typeof(FeaturePage)
            //});

               AdminmenuList.Add(new MasterPageItem()
                {
                    Title = "User Manage"
                });



            AdminmenuList.Add(new MasterPageItem()
            {
                Title = "Settings",
                TargetType = typeof(AppUserSettings)
            });



            AdminmenuList.Add(new MasterPageItem()
            {
                Title = "Log out"
            });



            // Setting our list to be ItemSource for ListView in MainPage.xaml  

            if (temp.type.ToLower() == "admin")
            {
                navigationDrawerList.ItemsSource = AdminmenuList;
            }
            else
            {
                navigationDrawerList.ItemsSource = AppUsermenuList;
            }
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AppUserSettings)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            if (item.Title == "Log out")
            {
                Application.Current.Properties.Remove("TUser");
                Application.Current.Properties.Remove("TType");

                App.Current.MainPage = new NavigationPage(new LogInPage());

                Navigation.PushModalAsync(new LogInPage());

                //await PopupNavigation.PopAllAsync();
                //var logpage = new LogInPage();//this could be content page
                //var rootPage = new NavigationPage(logpage);
                //App= rootPage.Navigation;
            }
            else
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            }
            IsPresented = false;
        }
    }
}