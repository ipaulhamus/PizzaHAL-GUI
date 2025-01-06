using Microsoft.AspNetCore.Components;
using Project2.Code;

namespace Project2.Components.Pages
{
    public partial class Checkout : ComponentBase, ICalculates
    {
        private float FinalTotal {  get; set; }
		private float SubTotal { get; set; }
		private String? TakeoutValidation { get; set; } = null;
		private bool Takeout { get; set; } = false;
		private bool CheckedOut { get; set; } = false;

		public void TakeoutChoice()
		{
			if(TakeoutChoice == null || TakeoutValidation == "Your Choice") {  return; }

			if(TakeoutValidation == "No")
			{
				Takeout = false;
				return; 
			}
			else if(TakeoutValidation == "Yes")
			{
				Takeout = true;
				return;
			}
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

			if(TakeoutValidation == "Yes")
			{
				total = total + 8f;
			}

			CheckedOut = true;

			FinalTotal = total;
		}
	}
}
