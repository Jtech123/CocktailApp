using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CocktailUWPNew
{
    public partial class MainPage : ContentPage
    {

        private ListView cocktailsList;
        private StorageContainer Storage;

        public MainPage()
        {
            InitializeComponent();
            List<Cocktail> cock = Cocktail.GetAll();
            cocktailsList = this.FindByName<ListView>("cocktails");
            cocktailsList.ItemsSource = cock;

        }

        private async void cocktails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Cocktail) {
                Cocktail c = (Cocktail)e.Item;
                await Navigation.PushAsync(new CocktailDetail(c));
            }
            else
                await DisplayAlert("Incorrect class", "ERROR", "Ok");
        }
    }
}
