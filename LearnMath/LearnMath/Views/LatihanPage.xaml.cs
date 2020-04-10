using LearnMath.Constants;
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
    public partial class LatihanPage : ContentPage
    {
        private string judulMateri;
        private int indexMateri;

        public LatihanPage()
        {
            InitializeComponent();
        }

        public LatihanPage(string _judulMateri, int _indexMateri)
        {
            InitializeComponent();

            judulMateri = _judulMateri;
            indexMateri = _indexMateri;

            FillContent();
        }

        private void BtnPembahasan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PembahasanPage(judulMateri, indexMateri));
        }


        private void FillContent()
        {
            switch (indexMateri)
            {
                case 0:
                    FillContentBarisanDanDeret();
                    break;
                case 1:
                    FillContentSistemKoordinat();
                    break;
                case 2:
                    FillContentRelasiDanFungsi();
                    break;
                case 3:
                    FillContentPersamaanGarisLurus();
                    break;
                case 4:
                    FillContentSPLDVDanSPLTV();
                    break;
                case 5:
                    FillContentPhytagoras();
                    break;
                case 6:
                    FillContentSudutDanGarisSinggung();
                    break;
                case 7:
                    FillContentBangunRuang();
                    break;
                case 8:
                    FillContentStatistika();
                    break;
                case 9:
                    FillContentPeluang();
                    break;

                default:
                    break;
            }
        }

        private void FillContentBarisanDanDeret()
        {
            KontenMateri.Children.Add(new Image { Source = "barisan_dan_deret_1.png", Margin= new Thickness(10,10,10,0) });
            KontenMateri.Children.Add(new Image { Source = "barisan_dan_deret_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "barisan_dan_deret_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentSistemKoordinat()
        {
            KontenMateri.Children.Add(new Image { Source = "sistem_koordinat_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "sistem_koordinat_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "sistem_koordinat_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentRelasiDanFungsi()
        {
            KontenMateri.Children.Add(new Image { Source = "relasi_dan_fungsi_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "relasi_dan_fungsi_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "relasi_dan_fungsi_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentPersamaanGarisLurus()
        {
            KontenMateri.Children.Add(new Image { Source = "persamaan_garis_lurus_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "persamaan_garis_lurus_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "persamaan_garis_lurus_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentSPLDVDanSPLTV()
        {
            KontenMateri.Children.Add(new Image { Source = "spldv_dan_splt_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "spldv_dan_splt_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "spldv_dan_splt_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentPeluang()
        {
            KontenMateri.Children.Add(new Image { Source = "peluang_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "peluang_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "peluang_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentStatistika()
        {
            KontenMateri.Children.Add(new Image { Source = "statistika_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "statistika_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "statistika_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentPhytagoras()
        {
            KontenMateri.Children.Add(new Image { Source = "phytagoras_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "phytagoras_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "phytagoras_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentSudutDanGarisSinggung()
        {
            KontenMateri.Children.Add(new Image { Source = "sudut_dan_garis_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "sudut_dan_garis_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "sudut_dan_garis_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }

        private void FillContentBangunRuang()
        {
            KontenMateri.Children.Add(new Image { Source = "bangun_ruang_1.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "bangun_ruang_2.png", Margin = new Thickness(10, 10, 10, 0) });
            KontenMateri.Children.Add(new Image { Source = "bangun_ruang_3.png", Margin = new Thickness(10, 10, 10, 10) });
        }
    }
}