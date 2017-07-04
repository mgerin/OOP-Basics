namespace _04.OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ');
                var member = new Person()
                                 {
                                     Name = inputTokens[0],
                                     Age = int.Parse(inputTokens[1])
                                 };
                people.Add(member);
            }

            people.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
