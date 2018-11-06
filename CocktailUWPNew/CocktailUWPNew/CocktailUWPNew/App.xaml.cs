using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CocktailUWPNew
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DatabaseHandler.Instance();
            MainPage = new NavigationPage(new LoginPage());
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
