using System.IO;

namespace Fundamentals
{
    public interface IGradeTracker
    {
            void AddGrade(float grade);
            GradeStatistics ComputeStatistics();
            void WriteGrades(TextWriter textWriter);
            string Name { get; set; }
            //     event NamedChangedDelegate NameChanged;
            void DoSomething();
   }
}
