using System;
using Plugin.Messaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        
        private void SendSMS_Clicked(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.SmsMessenger;
            if (call.CanSendSms)
            {
                call.SendSms("+372 799236011");
            }
        }
    }
}