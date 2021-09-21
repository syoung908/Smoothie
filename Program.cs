using System;

namespace SmoothieProgram {
    public class Program {
        public static void Main() {
            Smoothie s1 = new(new string[] { "Banana" });
            foreach (string ingredient in s1.Ingredients) {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine(s1.GetCost());
            Console.WriteLine(s1.GetPrice());
            Console.WriteLine(s1.GetName());

            Smoothie s2 = new(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            foreach (string ingredient in s2.Ingredients) {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine(s2.GetCost());
            Console.WriteLine(s2.GetPrice());
            Console.WriteLine(s2.GetName());
        }
    }
}
