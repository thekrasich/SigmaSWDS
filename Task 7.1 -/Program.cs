using System;
using System.IO;
using System.Collections.Generic;
namespace Task_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Study\C# Sigma University\Task 7.1\Task 7.1\In.txt";
            string text = File.ReadAllText(path);
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"I","Boy" },
                { "go","run"},
                {"to","to" },
                {"school","cinema" }
            };


            string[] words = text.Split(' ');
            int size = words.Length;
            Console.WriteLine("Your Text: ");
            for(int i = 0; i < size; i++)
            {

                Console.Write($"{words[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dictionary: ");
            foreach (var pair in dict)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            string dictionar="";
            foreach (var item in dict.Keys)
            {
                dictionar += item;
                dictionar += " ";
            }
            foreach (var item in dict.Values)
            {
                dictionar += item;
                dictionar += " ";
            }

            //Console.WriteLine(dictionar);

            string[] wordsDict = text.Split(' ');
            int sizeDict = wordsDict.Length;

            Console.WriteLine();



            bool flag = true;
            string forDict ="";
            int index=0;
            for(int i = 0 ; i < sizeDict ; i++ )
            {
                flag = true;
                for (int j = 0 ; j < size ;j++ )
                {
                    if(words[j] == wordsDict[i])
                    {
                        Console.WriteLine($"{words[j]} {wordsDict[i]}");
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        index = j;
                    }

                }
                if(flag == false)
                {
                    Console.WriteLine($"Enter pair for word {words[index]}");
                    forDict = Console.ReadLine();



                }
            }

        











        }
    }
}
