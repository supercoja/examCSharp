using System;

namespace Fundamentals
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
            :base(name)
        {
            Console.WriteLine("ThrowAway CTOR");
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThroAway ComputeStatistics");
            float lowestGrade = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowestGrade = Math.Min(lowestGrade, grade);
            }
            _grades.Remove(lowestGrade);
            return base.ComputeStatistics();
        }
    }
}
