using licenceServicesDemo2.Model;
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
    public partial class ServerList : ContentPage
    {
        public List<Servers> Temp;
        public ServerList()
        {
            InitializeComponent();

            Temp = new List<Servers>(); 
                              

            Temp.Add(new Servers() { ServerID = 1, IP = "10.100.12.1", Used = 15, Avaiable = 52 });
            Temp.Add(new Servers() { ServerID = 2, IP = "10.100.12.2", Used = 25, Avaiable = 42 });
            //Temp.Add(new Servers() { ServerID = 3, IP = "10.100.12.3", Used = 35, Avaiable = 32 });
           

            ServerListView.ItemsSource = Temp;
        }
    }
}