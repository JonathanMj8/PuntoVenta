using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using PuntoVenta.Views;
using PuntoVenta.Services;
using Xamarin.Forms.Internals;

[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "Montserrat-Bold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
[assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]

namespace PuntoVenta
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class App : Application
    {
        static Database database;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            OSAppTheme currentTheme = Application.Current.RequestedTheme;

            if (currentTheme == OSAppTheme.Light)
            {
                Application.Current.Resources.ApplyLightTheme();
            }
            else
            {
                Application.Current.Resources.ApplyDarkTheme();
            }

        }
        //base de datos
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dbnew.db3"));
                }
                return database;
            }
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
