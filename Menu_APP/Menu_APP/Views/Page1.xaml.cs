using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Menu_APP.Views.AboutPage.Mypass;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nastroyki());

        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            result = "0";
            await Navigation.PushAsync(new AboutPage());
        }
        private void Button_Clicked3(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://www.swedbank.ee/private/home/important/gdprMobile");
            Browser.OpenAsync(halflife);
        }
    }
}