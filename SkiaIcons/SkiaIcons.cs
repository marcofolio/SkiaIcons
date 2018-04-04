using System;
using SkiaSharp.Extended.Iconify;
using Xamarin.Forms;

namespace SkiaIcons
{
    public class App : Application
    {
        public App()
        {
            // Register the font
            SKTextRunLookup.Instance.AddFontAwesome();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
