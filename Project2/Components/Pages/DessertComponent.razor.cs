using Microsoft.AspNetCore.Components;
using Project2.Code;
using System.Runtime.CompilerServices;

namespace Project2.Components.Pages
{
    public partial class DessertComponent : ComponentBase
    {
        private string? DessertType { get; set; } = null;

        private float DessertPrice { get; set; }

        private void CreateDessert()
        {
            if(DessertType == null || DessertType == "Select a Type") 
            {
                return;
            }

            if(DessertType == "Chocolate Chip Cookie")
            {
                DessertPrice = Dessert.COOKIE_PRICE;
            }
            else if(DessertType == "Cookie Brownie")
            {
                DessertPrice = Dessert.COOKIE_BROWNIE_PRICE;
            }
            else
            {
                DessertPrice = Project2.Code.Dessert.TIRAMISU_PRICE;
            }

            Dessert order = new Dessert(DessertType, DessertPrice);

            Home.Desserts.Add(order);

            Console.WriteLine($"You created a dessert with the type of {DessertType} and the price of {DessertPrice}");

            DessertType = null;
            DessertPrice = 0;
        }
    }
}
