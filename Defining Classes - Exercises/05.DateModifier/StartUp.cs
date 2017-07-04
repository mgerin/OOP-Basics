namespace _05.DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            var dateDiff = new DateModifier();
            dateDiff.CalculateDifference(date1, date2);
            Console.WriteLine(dateDiff.Difference);
        }
    }
}
