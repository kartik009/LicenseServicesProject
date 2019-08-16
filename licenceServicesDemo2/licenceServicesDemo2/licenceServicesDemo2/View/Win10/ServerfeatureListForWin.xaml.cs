using licenceServicesDemo2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace licenceServicesDemo2.View.Win10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServerfeatureListForWin : ContentPage
    {


        public ObservableCollection<Servers> Temp;

        public ObservableCollection<Feature> fe;

        private GridUnitType _height = 0;
        public GridUnitType height
        {
            get => _height; set
            {
                _height = value;
                OnPropertyChanged();
            }
        }
        public ServerfeatureListForWin()
        {
            InitializeComponent();
            fe = new ObservableCollection<Feature>();

            fe.Add(new Feature() { FeatureName = "f2", Ver = (float)2.0, count = 1, Available = 1, ExperyDate = "Permanent" });

            fe.Add(new Feature() { FeatureName = "f2", Ver = (float)1.0, count = 100, Available = 92, ExperyDate = "Permanent" });

            fe.Add(new Feature() { FeatureName = "f3", Ver = (float)1.0, count = 10, Available = 5, ExperyDate = "2021-01-31" });


            Temp = new ObservableCollection<Servers>();


            Temp.Add(new Servers() { ServerID = 1, SeverName = "Microsoft Azure", IP = "10.100.12.1", Used = 15, Available = 52, features = fe.ToList() });
            Temp.Add(new Servers() { ServerID = 2, SeverName = "AWS", IP = "10.100.12.2", Used = 25, Available = 42, features = fe.ToList() });
            Temp.Add(new Servers() { ServerID = 3, SeverName = "G-Cloude", IP = "10.100.12.3", Used = 35, Available = 32 });

            ServerListView.ItemsSource = Temp;

            //sv_Main.HeightRequest
            sv_Main.IsVisible = true;
            sv_content.IsVisible = false;
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    sv_content.IsVisible = true;
        //    _height = GridUnitType.Auto;
        //}

        //private void Close_Clicked(object sender, EventArgs e)
        //{

        //    sv_content.IsVisible = false;
        //    _height = 0;

        //}

        private void ServerListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var serv = e.Item as Servers;

            var features = serv.features;

            FeatureListView.ItemsSource = features;

            sv_content.IsVisible = true;

            _height = GridUnitType.Auto;


        }

        private void FeatureListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void BT_Close_Clicked(object sender, EventArgs e)
        {

            sv_content.IsVisible = false;         
            
            sv_content.HeightRequest = 0;
            _height = 0;

        }
    }
}