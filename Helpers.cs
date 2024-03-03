using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Helpers
    {
        public static int SumTwoPositiveIntegers(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Both numbers must be positive");
            }

            return a + b;
        }

        public static bool IsNullOrEmpty(string value)
        {
            //return value is null or "";
            return value == null || value.Length == 0;
            // return value.Length == 0 || value == null; /// throws null reference exception
            //if (value == null)
            //{
            //    return true;
            //}
            //else if (value == "")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
