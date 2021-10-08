using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Pilynom
{
    class StringUtilities
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
