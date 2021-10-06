using System;
using System.Collections.Generic;
using System.Text;

namespace TimeKeeper.Utilities.Exceptions
{
    public class TimeKeeperException : Exception
    {
        public TimeKeeperException()
        {
        }

        public TimeKeeperException(string message)
            : base(message)
        {
        }

        public TimeKeeperException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
