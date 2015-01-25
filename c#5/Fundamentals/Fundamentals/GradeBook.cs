using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fundamentals
{
    public class GradeBook : GradeTracker
    {
        public GradeBook(string name = "There Is No Name")
        {
            Console.WriteLine("GradeBook CTOR");
            _grades = new List<float>();
            if (!String.IsNullOrEmpty(name))
            {
                Name = name;
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook ComputeStatistics");
            var calculatedStatistics = new GradeStatistics();
            float sumOfGrades = 0;
            foreach (float grade in _grades)
            {
               calculatedStatistics.HighestGrade = Math.Max(grade, calculatedStatistics.HighestGrade);
               calculatedStatistics.LowestGrade =  Math.Min(grade, calculatedStatistics.LowestGrade);
                sumOfGrades += grade;
            }

            calculatedStatistics.AverageGrade = (sumOfGrades / _grades.Count());
            return calculatedStatistics;
        }

        public override void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades: ");

            int i = 0;
            do 
            {
                textWriter.WriteLine(_grades[i]);
                i++;
            } while (i < _grades.Count);

            textWriter.WriteLine(" End Of Writing Grades ***");
        }

        protected List<float> _grades;

    }
}
