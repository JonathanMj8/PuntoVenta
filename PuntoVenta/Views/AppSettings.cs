using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using PuntoVenta.Views;

namespace PuntoVenta.Views
{
    [Preserve(AllMembers = true)]
    public class AppSettings
    {

        private readonly OSAppTheme currentTheme;


        private bool isDarkTheme;

        static AppSettings()
        {
            Instance = new AppSettings();
        }

        private AppSettings()
        {
            this.currentTheme = Application.Current.RequestedTheme;
        }

        public static AppSettings Instance { get; }

        /// <summary>
        /// Gets the AndroidSecretCode.
        /// </summary>
        public static string AndroidSecretCode => "88dda0e2-da50-466e-9aa5-36fc504d9ed3";

        /// <summary>
        /// Gets the iOSSecretCode.
        /// </summary>
        public static string IOSSecretCode => "b327e367-8f04-4efe-ad7a-85be8c828ec3";

        /// <summary>
        /// Gets the UWPSecretCode.
        /// </summary>
        public static string UWPSecretCode => "ca0577ad-4cd2-4258-a35b-465e8f4669d9";

        public bool IsDarkTheme
        {
            get => this.isDarkTheme;
            set
            {
                if (this.isDarkTheme == value)
                {
                    return;
                }

                this.isDarkTheme = value;
                if (this.isDarkTheme)
                {
                    // Dark Theme
                    Application.Current.Resources.ApplyDarkTheme();
                }
                else
                {
                    // Light Theme
                    Application.Current.Resources.ApplyLightTheme();
                }
            }
        }
    }

}
