﻿namespace BashSoft.Repository
{
    using System.Collections.Generic;
    using System.Linq;

    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                PrintStudents(wantedData
                    .OrderBy(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else if(comparison == "descending")
            {
                PrintStudents(wantedData
                    .OrderByDescending(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidQueryComparison);
            }
        }

        public void PrintStudents(Dictionary<string, List<int>> studentsSorted)
        {
            foreach (var kv in studentsSorted)
            {
                OutputWriter.PrintStudent(kv);
            }
        }
    }
}
