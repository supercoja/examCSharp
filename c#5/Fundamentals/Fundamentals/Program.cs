using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker gradeBook = CreateGradeBook();
            gradeBook.AddGrade(91f);
            gradeBook.AddGrade(89.1f);
            gradeBook.AddGrade(75f);

            gradeBook.DoSomething();
            gradeBook.WriteGrades(Console.Out);
            GradeStatistics statistics = gradeBook.ComputeStatistics();

    /*        gradeBook.NamedChanged += OnNameChanged;
            gradeBook.NamedChanged += OnNameChanged;
            gradeBook.NamedChanged += OnNameChanged2;
            gradeBook.NamedChanged -= OnNameChanged;
*/
            gradeBook.Name = "André's Book";

            Console.WriteLine(gradeBook.Name);
            Console.WriteLine("Average Grade {0}", statistics.AverageGrade);
            Console.WriteLine("Highest Grade {0}", statistics.HighestGrade);
            Console.WriteLine("Lowest Grade {0}", statistics.LowestGrade);
            Console.WriteLine("Letter Grade {0}", statistics.LetterGrade);
            Console.WriteLine("{0} {1}", statistics.LetterGrade,statistics.Description);
//            int age = 10;
  //          string pass = age > 20 ? "pass" : "nopass";
        }

        private static IGradeTracker CreateGradeBook()
        {
            IGradeTracker gradeBook = new ThrowAwayGradeBook("Thiago's Book");
            return gradeBook;
        }

        private static void OnNameChanged2(object sender, NamedChangedEventArgs args)
        {
            Console.WriteLine("***");
        }

        private static void OnNameChanged(object sender, NamedChangedEventArgs args)
        {
            Console.WriteLine("Book's Named Changed From {0} to {1}", args.oldValueName, args.newValueName);
        }
    }
}
