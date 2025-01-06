using Microsoft.AspNetCore.Components;
using Project2.Code;

namespace Project2.Components.Pages
{
    public partial class SoupComponent : ComponentBase
    {
		private string? SoupType { get; set; } = null;

        private float SoupPrice { get; set; } = Soup.SOUP_PRICE;

		private void CreateSoup()
		{
			if (SoupType == null)
			{
				return;
			}

			if(SoupType == "Select a Soup") { return; }

			Soup order = new Soup(SoupType, SoupPrice);

			Home.Soups.Add(order);

			Console.WriteLine($"You created a soup with the type of {SoupType} and the price of {SoupPrice}");

			SoupType = null;
		}
	}
}
