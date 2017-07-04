namespace _05.DateModifier
{
    using System;

    public class DateModifier
    {
        public int Difference { get; set; }

        public void CalculateDifference(string date1, string date2)
        {
            var firstDate = DateTime.Parse(date1);
            var secondDate = DateTime.Parse(date2);

            var difference = firstDate - secondDate;

            this.Difference = Math.Abs(difference.Days);
        }
    }
}
