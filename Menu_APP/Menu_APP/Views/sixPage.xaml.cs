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
            await Navigation.PushAsync(new FriendsListPage());
        }
    }
}