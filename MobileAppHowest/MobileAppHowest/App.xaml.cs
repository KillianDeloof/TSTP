﻿using MobileAppHowest.Models.MobileSDK;
using MobileAppHowest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileAppHowest
{
	public partial class App : Application
	{
		public App ()
		{
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new CampusPage(new Models.Ticket(new Models.UserInfo())));

        }

        public static IAuthenticate Authenticator { get; private set; }

        protected override void OnStart ()
		{
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
            // Handle when your app resumes
        }

        #region microsoftazuremobileclientsdk

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        #endregion
    }
}
