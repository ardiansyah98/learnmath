using LearnMath.Constants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnMath.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListMateriPage : ContentPage
    {
        public ListMateriPage()
        {
            InitializeComponent();
            ListViewMateri.ItemsSource = MateriConstant.listMateri;
        }

        private void ListViewMateri_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new LatihanPage(e.Item.ToString(), e.ItemIndex));
        }
    }
}