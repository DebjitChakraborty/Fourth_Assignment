using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Assignment
{
    internal class StackException:Exception
    {
        public StackException(string msg) : base(msg) { }
    }
}
