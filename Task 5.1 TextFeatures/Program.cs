using System;

namespace Task_5._1_Sigma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter amount of lines in text: ");
            int amount = Int32.Parse(Console.ReadLine());
            Console.WriteLine();


            StringText example = new StringText(amount);
          

            Console.WriteLine();



            Console.WriteLine("Your Text: ");
            example.StringTextPrinter();

            example.StringTextReplaceFeatures();



        }
    }
}
