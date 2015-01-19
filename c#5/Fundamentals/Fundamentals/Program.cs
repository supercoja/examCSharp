using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeBook = new GradeBook();
            gradeBook.AddGrade(91f);
            gradeBook.AddGrade(89.1f);
            gradeBook.AddGrade(75f);
            GradeStatistics statistics = gradeBook.ComputeStatistics();

            Console.WriteLine("Average Grade {0}", statistics.AverageGrade);
            Console.WriteLine("Highest Grade {0}", statistics.HighestGrade);
            Console.WriteLine("Lowest Grade {0}", statistics.LowestGrade);
        }
    }
}
