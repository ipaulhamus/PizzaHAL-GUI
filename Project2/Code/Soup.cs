using PizzaHAL;
using System.Drawing;
using System.Net.Http.Headers;

namespace Project2.Code
{
    public class Soup : Items
    {

        public String Type {  get; private set; }

        public float Price { get; private set; }

        public static readonly float SOUP_PRICE = 4.49f;

        public static String[] types = new String[]
        {
            "Tomato Basil Soup",
            "Broccoli Cheddar Soup",
            "Chicken Noodle Soup",
            "Italian Wedding Soup",
            "Clam Chowder"
        };

        public Soup(String type, float price)
        {
            this.Type = type;
            this.Price = price;
        }
    }

        
}

