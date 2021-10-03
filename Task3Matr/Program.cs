using System;

namespace Task_4_sigm
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaration
            int choice;
            bool flag;
            Matrix matrix = new Matrix();

            //Input
            Console.WriteLine("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine());
           
            if(size%2 == 0)
            {

                Console.WriteLine("Error! Input size again");
                size = int.Parse(Console.ReadLine());

            }





            //Menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Enter matrix manually;");
            Console.WriteLine("2 - fill matrix with random numbers;");

            Console.WriteLine("Enter command: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:

                    matrix.MatrixManualFill(size);
                    matrix.MatrixPrint(size);


                    break;

                case 2:
                    matrix.MatrixRandomFill(size);
                    matrix.MatrixPrint(size);


                    break;

                default:
                    Console.WriteLine("Error! Enter command again: ");
                    choice = int.Parse(Console.ReadLine());

                    break;

            }



            //Realisation

            flag = matrix.IsMagicSquare(size);
            if (flag)
            {
                Console.WriteLine("Matrix is magic square;");
            }
            else
            {
                Console.WriteLine("Matrix is not magic square;");
            }


        }
    }
}
