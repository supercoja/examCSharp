using System;

namespace Fundamentals
{
    public class NamedChangedEventArgs : EventArgs
    {
        public string oldValueName { get; set; }
        public string newValueName { get; set; }
    }
}
