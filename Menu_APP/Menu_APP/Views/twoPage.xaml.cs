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
    public partial class twoPage : ContentPage
    {
        public twoPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clickedweb(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://www.swedbank.ee/private/d2d/accounts/transactions?language=RUS");
            Browser.OpenAsync(halflife);
        }
    }
}