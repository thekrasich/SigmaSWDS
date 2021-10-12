using System;

namespace Task_4_Pilynom
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Polynomial y = Polynomial.Parse("10x^3+5x^2+5");
            Polynomial x = Polynomial.Parse("5x^3+3x^2-3");
          



            y.PolynomPrint();
            Console.WriteLine();
            x.PolynomPrint();
            Console.WriteLine();



            Polynomial z = new Polynomial();
            Console.WriteLine("Substraction: ");
            z = x - y;

       
            z.PolynomPrint();
            Console.WriteLine();

            Console.WriteLine("Addition: ");
            z = x+y;

            z.PolynomPrint();
            Console.WriteLine();
            Console.WriteLine("Multiplication: ");
            z = x * y;
            z.PolynomPrint();


            double t = 5;
            Polynomial convTest = t;
            Console.WriteLine();
            convTest.PolynomPrint();
        }
    }
}
