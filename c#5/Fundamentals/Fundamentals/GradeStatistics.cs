using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamentals
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            AverageGrade = 0;
            LowestGrade = float.MaxValue;
        }
       public float HighestGrade;
       public float AverageGrade;
       public float LowestGrade;
    }
}
