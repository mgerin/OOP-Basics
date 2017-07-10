namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            var allPeople = new List<Person>();
            var searchedPerson = Console.ReadLine();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("-"))
                {
                    var tokens = inputLine.Split('-').Select(x => x.Trim()).ToArray();
                    var parentParam = tokens[0];
                    var childParam = tokens[1];

                    var parent = new Person();
                    if (parentParam.Contains("/"))
                    {
                        parent.BirthDate = parentParam;
                    }
                    else
                    {
                        parent.Name = parentParam;
                    }

                    var child = new Person();
                    if (childParam.Contains("/"))
                    {
                        child.BirthDate = childParam;
                    }
                    else
                    {
                        child.Name = childParam;
                    }

                    AddParentIfMissing(allPeople, parent);

                    if (parent.Name != null)
                    {
                        allPeople.FirstOrDefault(p => p.Name == parent.Name).AddChild(child);
                    }
                    else
                    {
                        allPeople.FirstOrDefault(p => p.BirthDate == parent.BirthDate).AddChild(child);
                    }
                }
                else
                {
                    var tokens = inputLine.Split(' ');
                    var name = $"{tokens[0]} {tokens[1]}";
                    var date = tokens[2];

                    for (int i = 0; i < allPeople.Count; i++)
                    {
                        if (allPeople[i].Name == name)
                        {
                            allPeople[i].BirthDate = date;
                            break;
                        }

                        if (allPeople[i].BirthDate == date)
                        {
                            allPeople[i].Name = name;
                            break;
                        }

                        allPeople[i].AddChildrenInfo(name, date);
                    }
                }
            }

            PrintParentsAndChildren(allPeople, searchedPerson);
        }

        private static void PrintParentsAndChildren(List<Person> allPeople, string searchedPerson)
        {
            Person personWithTree;

        }

        private static void AddParentIfMissing(List<Person> allPeople, Person parent)
        {
            if (parent.Name != null && allPeople.Any(p => p.Name == parent.Name))
            {
                return;
            }

            if (parent.BirthDate != null && allPeople.Any(p => p.BirthDate == parent.BirthDate))
            {
                return;
            }

            allPeople.Add(parent);
        }
    }
}
