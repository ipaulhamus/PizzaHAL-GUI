using PizzaHAL;
using System.Drawing;

namespace Project2.Code
{
    public class Dessert : Items
    {
        public String Type {  get; private set; }

        public float Price { get; private set; }

        public static readonly float COOKIE_BROWNIE_PRICE = 6.49f;

        public static readonly float COOKIE_PRICE = 2.49f;

        public static readonly float TIRAMISU_PRICE = 4.99f;

        public static String[] types = new String[]
        {
            "Cookie Brownie",
            "Chocolate Chip Cookie",
            "Tiramisu"
        };

        public Dessert(String type, float price)
        {
            this.Type = type;
            this.Price = price;
        }
    }

        
}

