using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieProgram {
    public class Smoothie {
        public string[] Ingredients { get; private set; }

        private readonly Dictionary<string, double> _prices = new() {
            { "Strawberries", 1.50 },
            { "Banana", 0.50 },
            { "Mango", 2.50 },
            { "Blueberries", 1.00 },
            { "Raspberries", 1.00 },
            { "Apple", 1.75 },
            { "Pineapple", 3.50 }
        };

        public Smoothie(string[] ingredients) {
            Ingredients = ingredients;

            foreach (string ingredient in ingredients) {
                if (!_prices.ContainsKey(ingredient)) {
                    throw new ArgumentException("Invalid ingredient.");
                }
            }
        }

        private double CalculateCost() {
            double total = 0.0;
            foreach (string ingredient in Ingredients) {
                total += _prices[ingredient];
            }
            return total;
        }

        public string GetCost() {
            return string.Format("${0:f2}", CalculateCost());
        }

        public string GetPrice() {
            double cost = CalculateCost();
            double price = Math.Round(cost + (cost * 1.5), 2);
            return string.Format("${0:f2}", price);
        }

        public string GetName() {
            StringBuilder builder = new();
            string[] sortedIngredients = Ingredients;
            Array.Sort(sortedIngredients);

            foreach (string ingredient in sortedIngredients) {
                if(builder.Length != 0) {
                    builder.Append(' ');
                }
                builder.Append(ingredient.Replace("berries", "berry"));
            }

            if (Ingredients.Length > 1) {
                builder.Append(" Fusion");
            } else {
                builder.Append(" Smoothie");
            }
            return builder.ToString();
        }

    }
}
