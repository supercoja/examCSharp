using System.Collections;
using System.IO;

namespace Fundamentals
{

    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textWriter);

        public abstract IEnumerator GetEnumerator();

        public abstract void DoSomething();



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
                        NamedChanged(this, _eventArgsNameChanged);
                    }
                }
            }
        }

        public NamedChangedDelegate NamedChanged;

    }
}
