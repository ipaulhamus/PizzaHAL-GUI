using Microsoft.AspNetCore.Components;
using Project2.Code;
using System.Runtime.CompilerServices;

namespace Project2.Components.Pages
{
    public partial class SandwichesComponent : ComponentBase
    {
        private string? SandwichType { get; set; } = null;

        private float SandwichPrice { get; set; } = Sandwich.SANDWICH_PRICE;

        private void CreateSandwich()
        {
            if(SandwichType == null) { return; }

            if(SandwichType == "Select a Type") { return; }

            Sandwich order = new Sandwich(SandwichType, SandwichPrice);

            Home.Sandwiches.Add(order);

            Console.WriteLine($"You created a sandwich with the type of {SandwichType} and the price of {SandwichPrice}");

            SandwichType = null;
        }
    }
}
