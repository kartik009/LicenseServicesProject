using licenceServicesDemo2.Helper;
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
    public partial class LogInPage : ContentPage
    {
        List<TempUser> suser;

        public LogInPage()
        {
            InitializeComponent();

            suser = new List<TempUser>()
            {
                new TempUser{ username ="euser", pass = "test" , type ="euser"},

                new TempUser{ username ="admin", pass = "admin" , type ="admin"},

                new TempUser{ username ="test", pass = "test" , type ="test"}
            };

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
            if (Et_user.Text != null && Et_pass.Text != null)
            {
                var temp = suser.FirstOrDefault(c => c.username.ToLower() == Et_user.Text.ToLower() && c.pass == Et_pass.Text) as TempUser;

                if (temp != null)
                {
                    //App.Current.Properties["TUser"] = temp.username;
                    //App.Current.Properties["TType"] = temp.type;
                    //App.Current.SavePropertiesAsync();

                    Settings.username = temp.username;

                    Settings.Ttype = temp.type;

                    Navigation.PushModalAsync(new MasterDetailsPageItem());

                }
                else
                {
                    DisplayAlert("App Name", "Something Wrong", "Ok");
                }

            }
            else
            {
                DisplayAlert("App Name", "Please enter user or pass", "Ok");
            }
        }
                
    }

  
}