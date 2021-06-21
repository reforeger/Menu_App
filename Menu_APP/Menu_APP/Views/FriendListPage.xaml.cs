﻿using Menu_APP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendListPage : ContentView
    {
        public FriendListPage()
        {
            InitializeComponent();
            BindingContext = new FriedsListViewModel() { Navigation = Navigation };
        }
    }
}