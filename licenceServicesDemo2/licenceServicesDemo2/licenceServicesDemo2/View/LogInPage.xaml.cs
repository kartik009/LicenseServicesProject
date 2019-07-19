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
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();

            var ForgetPass_Tap = new TapGestureRecognizer();
            ForgetPass_Tap.Tapped += (s, e) =>
              {
                  Navigation.PushAsync(new ForgetPassPage());
              };
            sp_forgetPass.GestureRecognizers.Add(ForgetPass_Tap);



            var NewUSer_Tap = new TapGestureRecognizer();
            NewUSer_Tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new NewUserPage());
            };
            sp_NewUser.GestureRecognizers.Add(NewUSer_Tap);

        }

        private void Btn_Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MasterDetailPageItem());
        }
                
    }
}