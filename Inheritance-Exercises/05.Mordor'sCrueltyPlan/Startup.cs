namespace _05.Mordor_sCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _05.Mordor_sCrueltyPlan.Models;
    using _05.Mordor_sCrueltyPlan.Models.Foods;
    using _05.Mordor_sCrueltyPlan.Models.Moods;

    class Startup
    {
        static void Main()
        {
            var foods = new List<FoodFactory>();
            var foodsArgs = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var food in foodsArgs)
            {
                switch (food.ToLower())
                {
                    case "apple":
                        foods.Add(new Apple());
                        break;
                    case "cram":
                        foods.Add(new Cram());
                        break;
                    case "honeycake":
                        foods.Add(new HoneyCake());
                        break;
                    case "lembas":
                        foods.Add(new Lembas());
                        break;
                    case "melon":
                        foods.Add(new Melon());
                        break;
                    case "mushrooms":
                        foods.Add(new Mushrooms());
                        break;
                    default:
                        foods.Add(new Other());
                        break;
                }
            }

            var sum = foods.Sum(f => f.Points);
            Console.WriteLine(sum);
            if (sum < -5)
            {
                Console.WriteLine(typeof(Angry).Name);
            }
            else if (sum < 1)
            {
                Console.WriteLine(typeof(Sad).Name);
            }
            else if (sum < 16)
            {
                Console.WriteLine(typeof(Happy).Name);
            }
            else
            {
                Console.WriteLine(typeof(JavaScript).Name);
            }

        }
    }
}
