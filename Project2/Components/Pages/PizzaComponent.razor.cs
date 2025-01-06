using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Logging.Abstractions;
using Project2.Code;
using System.Reflection.Metadata.Ecma335;

namespace Project2.Components.Pages
{
	public partial class PizzaComponent
	{
		private String? PizzaSize { get; set; } = null;
		private String? PizzaTopping { get; set; } = null;
		private float PizzaPrice { get; set; }

		private void CreatePizza()
		{
			if (PizzaSize == null || PizzaTopping == null) { return; }

			if (PizzaSize == "Select Size" || PizzaTopping == "Make a Selection") { return; }

			if(PizzaSize == "Small") { PizzaPrice = PizzaPrice + Pizza.SMALL_PIZZA_PRICE; }

			else if (PizzaSize == "Medium") { PizzaPrice = PizzaPrice + Pizza.MEDIUM_PIZZA_PRICE; }

			else if (PizzaSize == "Large") { PizzaPrice = PizzaPrice + Pizza.LARGE_PIZZA_PRICE; }

			else if (PizzaSize == "Ex-Large") { PizzaPrice = PizzaPrice + Pizza.EX_PIZZA_PRICE; }

			
			if (PizzaTopping != "None")
			{
				if (PizzaSize == "Small") { PizzaPrice = PizzaPrice + Pizza.SMALL_TOPPING; }

				else if (PizzaSize == "Medium") { PizzaPrice = PizzaPrice + Pizza.MEDIUM_TOPPING; }

				else if (PizzaSize == "Large") { PizzaPrice = PizzaPrice + Pizza.LARGE_TOPPING; }

				else if (PizzaSize == "Ex-Large") { PizzaPrice = PizzaPrice + Pizza.EX_TOPPING; }
			}

			Pizza order = new Pizza(PizzaSize, PizzaTopping, PizzaPrice);

			Home.Pizzas.Add(order);

			Console.WriteLine($"You created a pizza with the size of {PizzaSize}, the topping of {PizzaTopping}, and the price of {PizzaPrice}");

			PizzaSize = null;
			PizzaTopping = null;
			PizzaPrice = 0;
		}

	}
}
