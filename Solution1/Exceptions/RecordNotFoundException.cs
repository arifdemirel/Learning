using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RecordNotFoundException : Exception //Exception system class is inherited here
    {
        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}
