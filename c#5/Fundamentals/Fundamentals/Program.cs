using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeBook = new GradeBook("Thiago's Book");
            gradeBook.AddGrade(91f);
            gradeBook.AddGrade(89.1f);
            gradeBook.AddGrade(75f);
            GradeStatistics statistics = gradeBook.ComputeStatistics();

            gradeBook.NamedChanged += OnNameChanged;
            gradeBook.NamedChanged += OnNameChanged;
            gradeBook.NamedChanged += OnNameChanged2;
//            gradeBook.NamedChanged = new NamedChangedDelegate(OnNameChanged2);
            gradeBook.Name = "André's Book";

            Console.WriteLine(gradeBook.Name);
            Console.WriteLine("Average Grade {0}", statistics.AverageGrade);
            Console.WriteLine("Highest Grade {0}", statistics.HighestGrade);
            Console.WriteLine("Lowest Grade {0}", statistics.LowestGrade);


        }

        private static void OnNameChanged2(string oldValueName, string newValueName)
        {
            Console.WriteLine("***"); ;
        }

        private static void OnNameChanged(string oldValueName, string newValueName)
        {
            Console.WriteLine("Named changed from {0} to {1}", oldValueName, newValueName);
        }
    }
}
