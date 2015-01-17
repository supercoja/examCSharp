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

            GradeStatistics statistics = gradeBook.ComputeStatistics();


            var gradeBook2 = new GradeBook();
            gradeBook2.AddGrade(75f);
            gradeBook2.AddGrade(55.5f);


            
        }
    }
}
