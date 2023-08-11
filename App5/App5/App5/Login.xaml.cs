using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollPage());
        }

        private void OnFacebookButtonClicked(object sender, EventArgs e)
        {
            // aqui va el login de fb, sera a travez de API
        }

        private void OnGoogleButtonClicked(object sender, EventArgs e)
        {
            // aca el de google, sera a travez de API
        }

    }
}