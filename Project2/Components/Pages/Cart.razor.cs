using Microsoft.AspNetCore.Components;
using Project2.Code;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Project2.Components.Pages
{
    public partial class Cart : ComponentBase, ICalculates
    {
        private float SubTotal { get; set; }

		protected override void OnInitialized()
		{
			CalculateTotal();
			base.OnInitialized();
		}

		public void CalculateTotal()
        {
			float total = 0;

			for (int i = 0; i < Home.Pizzas.Count; i++)
			{
				total = total + Home.Pizzas[i].Price;
			}
			for (int i = 0; i < Home.Drinks.Count; i++)
			{
				total = total + Home.Drinks[i].Price;
			}
			for (int i = 0; i < Home.Sandwiches.Count; i++)
			{
				total = total + Home.Sandwiches[i].Price;
			}
			for (int i = 0; i < Home.Desserts.Count; i++)
			{
				total = total + Home.Desserts[i].Price;
			}
			for (int i = 0; i < Home.Soups.Count; i++)
			{
				total = total + Home.Soups[i].Price;
			}

			SubTotal = total;
		}
	}
}
