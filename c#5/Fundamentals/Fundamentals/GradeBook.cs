using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class GradeBook
    {
        public GradeBook(string name)
        {
            _grades = new List<float>();
            if (!String.IsNullOrEmpty(name))
            {
                _name = name;
            }
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

        private string _name;
        public string Name 
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    var _oldNameValue = _name;
                    _name = value;
                    if (NamedChanged != null)
                    {
                        var _eventArgsNameChanged = new NamedChangedEventArgs();
                        _eventArgsNameChanged.oldValueName = _oldNameValue;
                        _eventArgsNameChanged.newValueName = value;
                        NamedChanged(this,_eventArgsNameChanged);
                    }
                }
            } 
        }

       public NamedChangedDelegate NamedChanged;
    }
}
