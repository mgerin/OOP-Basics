namespace _06.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split(' ');

                if (employeeInfo.Length > 4)
                {
                    if (int.TryParse(employeeInfo[4], out int age))
                    {
                        //age
                    }
                    else
                    {
                        //email
                    }
                }

                var employee = new Employee(
                    employeeInfo[0],
                    decimal.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3]);
            }
        }
    }
}
