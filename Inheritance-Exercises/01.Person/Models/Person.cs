namespace _01.Person.Models
{
    using System;
    using System.Text;

    public class Person
    {
        // 1. Add Fields
        private string name;

        private int age;

        // 2. Add Constructor
        protected Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // 3. Add Properties
        private string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        protected virtual int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }

        // 4. Add Methods
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {this.Name}, Age: {this.Age}");

            return stringBuilder.ToString();
        }
    }
}
