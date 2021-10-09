using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5._3_Sigma
{
    class StringPathUtilities
    {


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public static string StringFindFileName(string input)
        {

            string result = "";
            char stopChar = '\\';
            int index=0;

            for (int i = input.Length; i > 0; i--) { if (input[i - 1] == '.') { index = i; break; }        }

           



            for (int i =input.Length; i >0; i--)
            {
                
                
                
                    

                    for(; index>0; index--)
                    {
                        if (input[index-2] != stopChar) 
                        {
                            result += input[index-2];
                        }
                        else
                        {
                            break;
                        }



                    }





               
                


            }
            result = StringPathUtilities.Reverse(result);

            return result;


        }


        public static string StringFindRootFolder(string input)
        {
            string result = "";
            char stopChar = '\\';
            int index = 0;

            for (int i = input.Length; i > 0; i--) { if (input[i - 1] == stopChar) { index = i; break; } }


            for (int i = input.Length; i > 0; i--)
            {
                for (; index > 0; index--)
                {
                    if (input[index - 2] != stopChar)
                    {
                        result += input[index - 2];
                    }
                    else
                    {
                        break;
                    }


                }

            }


            result = StringPathUtilities.Reverse(result);

           


            return result;
        }




    }
}
