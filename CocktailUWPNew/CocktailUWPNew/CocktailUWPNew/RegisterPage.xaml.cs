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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
            BirthDate.MaximumDate = DateTime.UtcNow;
		}

        private void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            if (UsernameBox.Text != null && UsernameBox.Text.Length > 0 && PasswordBox.Text != null && PasswordBox.Text.Length > 0 && BirthDate.Date > BirthDate.MinimumDate && BirthDate.Date < BirthDate.MaximumDate)
            {
                User u = User.Register(UsernameBox.Text, PasswordBox.Text, BirthDate.Date);
            }
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }
    }
}