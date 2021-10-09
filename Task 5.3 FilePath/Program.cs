using System;

namespace Task_5._3_Sigma
{
    class Program
    {
        static void Main(string[] args)
        {

            string example = @"'c: \ WebServers \ home \ testsite \ www \ myFile.Name57.txt'";
            string answer;

            Console.WriteLine($"Example String : {example} \n");


            answer = StringPathUtilities.StringFindFileName(example);
            Console.WriteLine($"File Name without expansion: {answer} \n");

            answer = StringPathUtilities.StringFindRootFolder(example);
            Console.WriteLine($"Root Folder of file: {answer} \n");


        }
    }
}
