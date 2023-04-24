using System;

class Program {
    static void Main(string[] arge) {
        Console.WriteLine("4: ");
        int itemCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < itemCount; i++) {
            Console.WriteLine("LongSword" + (i + 1) + ": ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Weapon" + itemName + "/: ");
            string itemType = Console.ReadLine();

            Console.WriteLine("ShortSword" + (i + 1) + ": ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Weapon" + itemName + "/: ");
            string itemType = Console.ReadLine();        

 
            Console.WriteLine("Lollipop" + (i + 1) + ": ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Weapon" + itemName + "/: ");
            string itemType = Console.ReadLine();

            Console.WriteLine("GrilledFish" + (i + 1) + ": ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Food" + itemName + "/: ");
            string itemType = Console.ReadLine();


            items.Add(itemName, itemType)
        }

        while (true) 
        {
            Console.WriteLine("Search Mode: ");
            string mode = Console.ReadLine();

            if (mode == "ShowAll")
            {
                Console.WriteLine("LongSword/ ShortSword/ Lollipop/ GrilledFish")
                foreach (Item item in items)
                {
                    Console.WriteLine("itemName" + "("itmeType +): ")
                }
        }
    }
}
}