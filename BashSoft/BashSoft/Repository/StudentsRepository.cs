namespace BashSoft.Repository
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class StudentsRepository
    {
        private Dictionary<string, Dictionary<string, List<int>>> studentByCourse;

        private bool isDataInilized;

        private RepositoryFilter filter;

        private RepositorySorter sorter;

        public StudentsRepository(RepositorySorter sorter, RepositoryFilter filter)
        {
            this.filter = filter;
            this.sorter = sorter;
            this.studentByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
        }


        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.studentByCourse[courseName].Count;
                }

               this.filter.FilterAndTake(this.studentByCourse[courseName], givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.studentByCourse[courseName].Count;
                }

                this.sorter.OrderAndTake(this.studentByCourse[courseName], comparison, studentsToTake.Value);
            }
        }
        
        public void LoadData(string fileName)
        {
            if (this.isDataInilized)
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
                return;
            }
            
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            this.ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInilized)
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            this.studentByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            this.isDataInilized = false;
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                var rgx = new Regex(@"([A-Z][A-Za-z+#]*_[A-Z][a-z]{2}_201[4-9])\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d{1,3})");
                var allInputLines = File.ReadAllLines(path);
                for (int i = 0; i < allInputLines.Length; i++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[i]) && rgx.IsMatch(allInputLines[i]))
                    {
                        var currentMatch = rgx.Match(allInputLines[i]);
                        var course = currentMatch.Groups[1].Value;
                        var student = currentMatch.Groups[2].Value;
                        int score;
                        var hasParsed = int.TryParse(currentMatch.Groups[3].Value, out score);

                        if (hasParsed && score <= 100 && score >= 0)
                        {
                            if (!this.studentByCourse.ContainsKey(course))
                            {
                                this.studentByCourse.Add(course, new Dictionary<string, List<int>>());
                            }

                            if (!this.studentByCourse[course].ContainsKey(student))
                            {
                                this.studentByCourse[course].Add(student, new List<int>());
                            }

                            this.studentByCourse[course][student].Add(score);
                        }
                    }
                }
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidPath);
                return;
            }

            this.isDataInilized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (this.isDataInilized)
            {
                if (this.studentByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (this.IsQueryForCoursePossible(courseName) && this.studentByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public void GetStudentScoresFromCourse(string courseName, string username)
        {
            OutputWriter.PrintStudent(
                new KeyValuePair<string, List<int>>(username, this.studentByCourse[courseName][username]));
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");
                foreach (var studetMarksEntry in this.studentByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studetMarksEntry);
                }
            }
        }
    }
}