using System;

namespace Task_4_Pilynom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };
            Polynomial x = new Polynomial(3, a);
           Polynomial y = Polynomial.Parse("x^5+43x^4+511x^3+2x^2-3x-25");
           
            y.PolynomPrint();



            //Test
            string test = "x^5+4x^4+511x^3+2x^2-3x-25";
            // Console.WriteLine(test[1]);

        }
    }
}
