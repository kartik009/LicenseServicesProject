using System;
using System.Collections.Generic;
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

            sv_main.IsVisible = true;
            sv_content.IsVisible = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            sv_content.IsVisible = true;
            _height = GridUnitType.Auto;
        }

        private void Close_Clicked(object sender, EventArgs e)
        {

            sv_content.IsVisible = false;
            _height = 0;

        }
    }
}