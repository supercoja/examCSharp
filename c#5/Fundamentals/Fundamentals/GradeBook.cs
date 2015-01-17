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
            _grades.Add(grade);
        }
        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        List<float> _grades;



    }
}
