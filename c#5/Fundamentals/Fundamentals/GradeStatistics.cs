
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

       public string Description
       {

           get
           {
               string _result;
               switch (LetterGrade)
               {
                   case 'A':
                       _result = "Excellent";
                       break;
                   case 'B':
                       _result = "Above Average";
                       break;
                   case 'C':
                       _result = "Average";
                       break;
                   case 'D':
                       _result = "Below Average";
                       break;
                   default:
                       _result = "Fail";
                       break;
               }
               return _result;
           }
       }

       public char LetterGrade
       {
           get
           {
               char _result;
               if (AverageGrade >= 90)
               {
                   _result = 'A';
               }
               else if (AverageGrade >= 80)
               {
                   _result = 'B';
               }
               else if (AverageGrade >= 70)
               {
                   _result = 'C';
               }
               else if (AverageGrade >= 60)
               {
                   _result = 'D';
               }
               else { _result = 'F'; }

               return _result;
           }
       }
    }
}
