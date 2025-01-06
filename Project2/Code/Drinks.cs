using PizzaHAL;

namespace Project2.Code
{
    public class Drink : Items
    {

        public String Size { get; private set; }

        public String Type { get; private set; }

        public String Ice { get; private set; }

        public float Price { get; private set; }

        public static readonly float SMALL_PRICE = 1.19f;

        public static readonly float MEDIUM_PRICE = 1.59f;

        public static readonly float LARGE_PRICE = 1.99f;

        public static String[] sizes = new String[]
        {
            "Small",
            "Medium",
            "Large"
        };

        public static String[] flavors = new String[]
        {
            "Dr. Dynamite",
            "Dr. Thunder",
            "Lemon Lime",
            "Mountain Lightning",
            "Mr. Pibb",
            "7 Dew"
        };

        public static String[] iceAmount = new String[]
        {
            "None",
            "Regular",
            "Extra"
        };

        public Drink(String size, String type, String ice, float price)
        {
            this.Size = size;
            this.Type = type;
            this.Ice = ice;
            this.Price = price;
        }
    }
}

