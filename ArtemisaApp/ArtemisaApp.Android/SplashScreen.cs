﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtemisaApp.Droid.Resources
{
    [Activity(Label = "Artemisa", Icon = "@drawable/Icon", Theme = "@style/newtheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashScreen : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            // Create your application here
        }
    }
}