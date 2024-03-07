using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class UnitTestingSystemError: IDESystemError
    {
        public override string UEMessage()
        {
            return "Assert.AreEqual failed," +
                " please Check the values being compared and ensure they are what is expected!";
        }
    }
}
