namespace _06.Company_Roster
{
    public class Employee
    {
        private string name;

        private decimal salary;

        private string position;

        private string department;

        private string email;

        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
    }
}
