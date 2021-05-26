using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Check
{
    public static class IsNumberCheck
    {
        public static bool IsNumber(this string str)
        {
            float output;
            return float.TryParse(str, out output);
        }

    }
}
