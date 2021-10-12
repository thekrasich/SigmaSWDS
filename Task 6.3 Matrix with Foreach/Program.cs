using System;

namespace Task_6._3_Sigma_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(4);
            Console.WriteLine("Our Matrix: ");
            matrix.MatrixPrint();
            Console.WriteLine("Matrix with foreach print:");
            matrix.MatrixForeachTest();


        }
    }
}
