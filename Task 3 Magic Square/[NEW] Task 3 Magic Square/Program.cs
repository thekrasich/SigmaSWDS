using System;

namespace _NEW__Task_3_Magic_Square
{
    class Program
    {
        static void Main(string[] args)
        {

            MagicSquare magicSquare = new MagicSquare();
            MatrixPrint printer = new MatrixPrint();



            Console.WriteLine("Enter size: ");
            int size = Int32.Parse(Console.ReadLine());
           

            magicSquare.MagicSquareGenerate(size);

            printer.PrintMatrix(magicSquare);


        }
    }
}
