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
    public partial class MasterDetailPageItem : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        //public MasterPageItem pm;


        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MasterDetailPageItem()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Feature, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {

            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Server:
                        MenuPages.Add(id, new NavigationPage(new ServerList()));
                        break;
                    case (int)MenuItemType.Feature:
                        MenuPages.Add(id, new NavigationPage(new FeaturePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}