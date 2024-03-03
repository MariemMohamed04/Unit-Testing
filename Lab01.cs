using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Console
{
    public class Lab01
    {
        public static int WordCount(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            int count = 0;
            bool inWord = false;
            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        count++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }

            if (inWord)
            {
                count++;
            }

            return count;
        }
    }
}
