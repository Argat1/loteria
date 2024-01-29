using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void gracz_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StonaGracz());
        }

        private void admin_Nnav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaAdmin());
        }

        private void wyniki_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StronaWynik());
        }
    }
}
