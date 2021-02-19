using System;
using Plugin.Messaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using static Menu_APP.Views.AboutPage.Mypass;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class onePage : ContentPage
    {
        
        public onePage()
        {
            InitializeComponent();
        }
        public async void OnActionSheetSimple12_Clicked(object sender, EventArgs e)
        {
            if (result == "7041")
            {
                await DisplayAlert("Alert", "Access gained", "OK");
            }

        }
    }
}