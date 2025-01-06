using Microsoft.AspNetCore.Components;
using PizzaHAL;
using Project2.Code;

namespace Project2.Components.Pages
{
    public partial class Home : ComponentBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            //Add code here to run when the component is initialized
        }

        //Item Lists
        public static List<Sandwich> Sandwiches = new List<Sandwich> { };

        public static List<Pizza> Pizzas = new List<Pizza> { };

        public static List<Drink> Drinks = new List<Drink> { };

        public static List<Dessert> Desserts = new List<Dessert> { };

        public static List<Soup> Soups = new List<Soup> { };
    }
}
