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
	public partial class CocktailDetail : ContentPage
	{
        private Cocktail cocktail;

		public CocktailDetail (Cocktail c)
		{
			InitializeComponent ();
            cocktail = c;
            cocktailTitle.Text = cocktail.Name;
            cocktailDescription.Text = cocktail.Description;
            cocktailAlcohol.Text = cocktail.AlcoholPercentage + " %";
            cocktailImage.Source = cocktail.Url;
		}
	}
}