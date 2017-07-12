namespace _03.Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _03.Mankind.Models;

    class Startup
    {
        static void Main()
        {
            try
            {
                var input = Console.ReadLine();
                var humanTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstName = humanTokens[0];
                var lastName = humanTokens[1];
                var facultyNumber = humanTokens[2];

                Student student = new Student(firstName, lastName, facultyNumber);

                input = Console.ReadLine();
                humanTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                firstName = humanTokens[0];
                lastName = humanTokens[1];
                var salary = decimal.Parse(humanTokens[2]);
                var workingHours = decimal.Parse(humanTokens[3]);

                Worker worker = new Worker(firstName, lastName, salary, workingHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
