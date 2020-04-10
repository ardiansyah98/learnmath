using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnMath.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void BtnProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }

        private void BtnMateri_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMateriPage());
        }
    }
}