using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2API.Exceptions
{
    public class MissingAccountIdException : Exception
    {
        public MissingAccountIdException()
            : base()
        {
        }

        public MissingAccountIdException(string message)
            : base(message)
        {
        }

        public MissingAccountIdException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
