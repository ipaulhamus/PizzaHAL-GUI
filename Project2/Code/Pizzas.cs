using PizzaHAL;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Project2.Code
{
    public class Pizza : Items
    {
        public String Size {  get; private set; }

        public String ToppingChoice { get; private set; }

        public float Price { get; private set; }

        public static readonly float SMALL_PIZZA_PRICE = 5.99f;

        public static readonly float MEDIUM_PIZZA_PRICE = 7.99f;

        public static readonly float LARGE_PIZZA_PRICE = 9.99f;

        public static readonly float EX_PIZZA_PRICE = 11.99f;

        public static readonly float SMALL_TOPPING = 0.50f;

        public static readonly float MEDIUM_TOPPING = 0.70f;

        public static readonly float LARGE_TOPPING = 0.90f;

        public static readonly float EX_TOPPING = 1.00f;

        public static String[] sizes = new String[]
        {
            "Small",
            "Medium",
            "Large",
            "Ex-Large"
        };

        public static String[] toppings = new String[]
        {
            "Pepperoni",
            "Bacon",
            "Sausage",
            "Pineapple",
            "Peppers",
            "Mushroom"
        };

        public Pizza(String size,String topping, float price)
        {
            this.Size = size;
            this.ToppingChoice = topping;
            this.Price = price;
        }
    }
}

