using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class DebugingSystemError : IDESystemError
    {
        public override string UEMessage()
        {
            return $"The debuger has stopped answering, please restart your IDE and try again!";
        }
    }
}
