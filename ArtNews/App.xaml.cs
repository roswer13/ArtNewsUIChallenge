using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArtNews.Services;
using ArtNews.Views;
using ArtNews.ViewModels.Base;
using System.Threading.Tasks;
using ArtNews.ViewModels;
using Plugin.SharedTransitions;

namespace ArtNews
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new SharedTransitionNavigationPage(new DetailAuthorPage());
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
