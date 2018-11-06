using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CocktailUWPNew
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            if (DatabaseHandler.Instance().GetConnection().Table<Allergy>().Count() == 0)
                Allergy.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<AllergyIngredient>().Count() == 0)
                AllergyIngredient.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<Category>().Count() == 0)
                Category.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<Cocktail>().Count() == 0)
                Cocktail.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<CocktailIngredient>().Count() == 0)
                CocktailIngredient.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<Glass>().Count() == 0)
                Glass.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<Ingredient>().Count() == 0)
                Ingredient.FillDatabase();
            if (DatabaseHandler.Instance().GetConnection().Table<User>().Count() == 0)
                User.FillDatabase();
		}

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (UsernameBox.Text.Length > 0 && PasswordBox.Text.Length > 0)
            {
                User user = User.Login(UsernameBox.Text, PasswordBox.Text);
                if (user == null)
                {
                    await DisplayAlert("No Access", "The username and password combination is incorrect", "OK");
                }
                else
                {
                    DatabaseHandler.Instance().currentUser = user;
                    await Navigation.PushAsync(new MainPage());
                }
            }
            else
            {
                await DisplayAlert("No Input", "Please provide an username and password", "OK");
            }
        }
    }
}