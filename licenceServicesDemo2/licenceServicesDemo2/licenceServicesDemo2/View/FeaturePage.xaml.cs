using licenceServicesDemo2.Model;
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
    public partial class FeaturePage : ContentPage
    {
        public List<Feature> Featurelist; 
        public FeaturePage()
        {
            InitializeComponent();

            

            MessagingCenter.Subscribe<List<Feature>>(this, "GetFeatures", (sender) => {
                Featurelist = sender as List<Feature>;
                FeatureListView.ItemsSource = Featurelist;
                MessagingCenter.Unsubscribe<List<Feature>>(this, "GetFeatures");
            });
            

            //Featurelist.Add(new Feature() { FeatureName = "f2", Ver = 2.0, count = 1, Available = 1, ExperyDate = "Permanent" });

            //Featurelist.Add(new Feature() { FeatureName = "f2", Ver = 1.0, count = 100, Available = 92, ExperyDate = "Permanent" });

            //Featurelist.Add(new Feature() { FeatureName = "f3", Ver = 1.0, count = 10, Available = 5, ExperyDate = "2021-01-31" });


            

            //if ((FeatureListView.ItemsSource as List<Servers>).Count == 0)
            //{
            //    FeatureListView.IsVisible = false;
            //    lb_empty_Feature.IsVisible = true;
            //}

        }

        private void FeatureListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}