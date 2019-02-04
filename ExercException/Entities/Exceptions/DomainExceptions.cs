using System;
using System.Collections.Generic;
using System.Text;

namespace ExercException.Entities.Exceptions
{
    class DomainExceptions : Exception
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
