using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sevenPage : ContentPage
    {
        public sevenPage()
        {
            InitializeComponent();
        }
        private void Call_Clicked(object sender, EventArgs e)
        {
            var call1 = CrossMessaging.Current.PhoneDialer;
            if (call1.CanMakePhoneCall)
            {
                call1.MakePhoneCall("+372 799236011");
            }
        }
    }
}