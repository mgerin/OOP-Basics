namespace FamilyTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private List<Person> children;

        public string Name { get; set; }

        public string BirthDate { get; set; }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }

        public void AddChildrenInfo(string name, string date)
        {
            if (this.children.FirstOrDefault(c => c.Name == name) != null)
            {
                this.children.FirstOrDefault(c => c.Name == name).BirthDate = date;
                return;
            }

            if (this.children.FirstOrDefault(c => c.BirthDate == date) != null)
            {
                this.children.FirstOrDefault(c => c.BirthDate == date).Name = name;
            }
        }
    }
}
