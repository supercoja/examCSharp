using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
            :base(name)
        {
            Console.WriteLine("GradeBook CTOR");
        }

        public GradeStatistics ComputeStatistics()
        {
            return base.ComputeStatistics();
        }
    }
}
