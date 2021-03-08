﻿using DemoApp.ViewModels;
using DemoApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
