using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Food food = new Food("solenki", 2.69m, 200);
            Console.WriteLine(food.Grams);

            Beverage sokche = new Beverage("sokche", 0.55m, 180);
            Console.WriteLine(sokche.Milliliters);

            Fish fish1 = new Fish("skumriq",12.50m);
            Console.WriteLine(fish1.Grams);

            Cake cake1 = new Cake("Garash");
            Console.WriteLine(cake1.Grams);
            Console.WriteLine(cake1.Calories);
            Console.WriteLine(cake1.Price);


            MainDish kavarma = new MainDish("Kavarma", 12.50m, 450);

            Console.WriteLine(kavarma.Price);
            Console.WriteLine(kavarma.Grams);
            Console.WriteLine(kavarma.Name);

            Dessert mandjaSGrozde = new Dessert("Mandja S Grozde", 50m, 900, 3000);
            Console.WriteLine(mandjaSGrozde.Grams);
            Console.WriteLine(mandjaSGrozde.Calories);
            Console.WriteLine(mandjaSGrozde.Price);
            Console.WriteLine(mandjaSGrozde.Name);

        }
    }
}