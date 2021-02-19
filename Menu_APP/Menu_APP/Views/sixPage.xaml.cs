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
    public partial class sixPage : ContentPage
    {
        public sixPage()
        {
            InitializeComponent();
        }

        public async void OnActionSheetSimple_Clicked123(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            Browser.OpenAsync(halflife);
        }
    }
}