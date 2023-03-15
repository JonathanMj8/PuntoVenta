using PuntoVenta.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PuntoVenta.Views
{
    [Preserve(AllMembers = true)]
    public static class Utils
    {
        public static void ApplyDarkTheme(this ResourceDictionary resources)
        {
            if (resources != null)
            {
                var mergedDictionaries = resources.MergedDictionaries;
                var lightTheme = mergedDictionaries.OfType<LightTheme>().FirstOrDefault();
                if (lightTheme != null)
                {
                    mergedDictionaries.Remove(lightTheme);
                }

                mergedDictionaries.Add(new DarkTheme());
                AppSettings.Instance.IsDarkTheme = true;
            }
        }
        public static void ApplyLightTheme(this ResourceDictionary resources)
        {
            if (resources != null)
            {
                var mergedDictionaries = resources.MergedDictionaries;

                var darkTheme = mergedDictionaries.OfType<DarkTheme>().FirstOrDefault();
                if (darkTheme != null)
                {
                    mergedDictionaries.Remove(darkTheme);
                }

                mergedDictionaries.Add(new LightTheme());
                AppSettings.Instance.IsDarkTheme = false;
            }
        }
    }
}
