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

            Polynomial z = new Polynomial();
            z = z.PolynomSubstraction(x, y);
            Console.WriteLine();
            z.PolynomPrint();
        }
    }
}
