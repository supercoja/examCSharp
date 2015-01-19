using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class GradeBook
    {
        public GradeBook()
        {
            _grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }
        public GradeStatistics ComputeStatistics()
        {
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

        List<float> _grades;



    }
}
