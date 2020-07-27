using JokesApi.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JokesApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FunnyPage();
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
