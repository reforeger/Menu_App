using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class fivePage : ContentPage
    {
        public fivePage()
        {
            InitializeComponent();
        }

        public async void OnActionSheetSimple_Clicked3(object sender, EventArgs e)
        {

            Uri halflife = new Uri("https://www.swedbank.ee/");
            Browser.OpenAsync(halflife);
        }

        public async void OnActionSheetSimple_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        
    }
}