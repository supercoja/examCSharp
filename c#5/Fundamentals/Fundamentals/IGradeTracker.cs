using System.Collections;
using System.IO;

namespace Fundamentals
{
    public interface IGradeTracker : IEnumerable
    {
            void AddGrade(float grade);
            GradeStatistics ComputeStatistics();
            void WriteGrades(TextWriter textWriter);
            string Name { get; set; }
            //     event NamedChangedDelegate NameChanged;
            void DoSomething();
            IEnumerator GetEnumerator();

   }
}
