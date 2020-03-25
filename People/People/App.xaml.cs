using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace People
{
    public partial class App : Application
    {
        public App(string displayText)
        {
            InitializeComponent();

            MainPage = new People.MainPage()
            {
                Text = displayText
            };
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
