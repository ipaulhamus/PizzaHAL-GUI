using PizzaHAL;
using System.Runtime.CompilerServices;

namespace Project2.Code
{
    public class Sandwich : Items
    {
        public String Type {  get; set; }
        public float Price { get; set; }

        public static readonly float SANDWICH_PRICE = 4.99f;

        public static String[] sandwichTypes = new String[]
        {
            "Buffalo Chicken",
            "Mediterranean Veggie",
            "Philly Cheese Steak",
            "Chicken Parm"
        };

        public Sandwich(String type, float price) 
        {
            this.Type = type;
            this.Price = SANDWICH_PRICE;
        }
    }

        
}

