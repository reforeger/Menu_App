﻿using System;
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
        public string result = "0";
        public AboutPage()
        {
            InitializeComponent();
        }

        //public async void OnActionSheetSimple1_Clicked(object sender, EventArgs e)
        //{
            //string result1 = await DisplayPromptAsync("Enter your smart ID", "password", initialValue: "result", maxLength: 4, keyboard: Keyboard.Numeric);
            
        //}

        public async void OnActionSheetSimple_Clicked(object sender, EventArgs e)
        {
            
            string result1 = await DisplayPromptAsync("Enter your smart ID", "password", maxLength: 4, keyboard: Keyboard.Numeric);
            if (result1 == "7041")
            {
                result = "7041";
                await DisplayAlert("Alert", "Access gained", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Smart-ID code is incorrect", "OK");
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