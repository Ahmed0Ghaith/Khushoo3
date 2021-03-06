﻿using System;
using System.Collections.Generic;
using Com.OneSignal;
using Com.OneSignal.Abstractions;
using Khushoo3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont ("ArbFONTS-Droid-Arabic-Kufi.ttf", Alias ="KufiFont" ) ]
[assembly: ExportFont("ArbFONTS-Droid-Arabic-Kufi-Bold.ttf", Alias = "KufiFontBold")]
[assembly: ExportFont("ArbFONTS-GaliModern-Regular.ttf", Alias = "GaliModernFont")]
[assembly: ExportFont("Tajawal-Bold.ttf", Alias = "TajawalFontBold")]
[assembly: ExportFont("Tajawal-Regular.ttf", Alias = "TajawalFont")]


namespace Khushoo3
{
    public partial class App : Application   
    {
        public static string DataBaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();

        }
        public App(string _DataBaseLocation)
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzUyNjcwQDMxMzgyZTMzMmUzMFdRenV1RUwyL1ZuVzdtNk9QL1l5bFJrZDZuV2gyNHNLWHAza1hZVUtFZGc9");
            DataBaseLocation = _DataBaseLocation;

            MainPage = new NavigationPage(new HomePage());
            OneSignal.Current.StartInit("7c5596e3-dc13-4815-a50c-a44754067e37")
 .Settings(new Dictionary<string, bool>() {
    { IOSSettings.kOSSettingsKeyAutoPrompt, false },
    { IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
 .InFocusDisplaying(OSInFocusDisplayOption.Notification)
 .EndInit();

            OneSignal.Current.RegisterForPushNotifications();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
