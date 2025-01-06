using Microsoft.AspNetCore.Components;
using Project2.Code;

namespace Project2.Components.Pages
{
    public partial class DrinksComponent
    {
        private String? DrinkSize { get; set; } = null;
        private String? DrinkType { get; set; } = null;
        private String? DrinkIce { get; set; } = null;
        private float DrinkPrice { get; set; }

        private void CreateDrink()
        {
            if(DrinkSize == null || DrinkType == null || DrinkIce == null) { return; }

            if(DrinkSize == "Select a Size" || DrinkType == "Select a Type" || DrinkIce == "Select Your Ice Amount") { return; }

            if(DrinkSize == "Small") { DrinkPrice = Drink.SMALL_PRICE; }

            else if(DrinkSize == "Medium") { DrinkPrice = Drink.MEDIUM_PRICE; }

            else if(DrinkSize == "Large") { DrinkPrice = Drink.LARGE_PRICE; }

            Drink order = new Drink(DrinkSize, DrinkType, DrinkIce, DrinkPrice);

			Home.Drinks.Add(order);

			Console.WriteLine($"You created a drink with the size of {DrinkSize}, the type of {DrinkType}, and the price of {DrinkPrice}");

			DrinkSize = null;
			DrinkType = null;
			DrinkIce = null;
		}
    }
}
