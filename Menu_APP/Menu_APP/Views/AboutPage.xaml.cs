using System;
using Plugin.Messaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public async void OnActionSheetSimple_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Enter your smart ID", "password", maxLength: 4, keyboard: Keyboard.Numeric);
            if (result == "7041")
            {
                
                //await DisplayAlert("Alert", "You have been alerted", "OK");
            }
        }


        /*
        private void SendSMS_Clicked(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.SmsMessenger;
            if (call.CanSendSms)
            {
                call.SendSms("+372 799236011");
            }
        }*/
    }
}