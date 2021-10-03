using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_sigm
{
    class Matrix
    {

        //Data
        private const int _size = 1111;
        private int[,] _matrix = new int[_size, _size];




        //Functions

        //Constructors 

        public Matrix()
        {

            for(int i = 0;  i  < 1; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    _matrix[i,j] = 0;
                }

            }


        }
        public Matrix(int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    _matrix[i, j] = 0;
                }

            }

        }

        //General

        public void MatrixRandomFill(int size)
        {

            Random random = new Random();

            if(size%2 != 0)
            {

                for (int i = 0; i < size; i++)
                {

                    for (int j = 0; j < size; j++)
                    {

                        _matrix[i, j] = random.Next(100);

                    }

                }






            }
            else
            {

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        _matrix[i, j] = 0;
                    }

                }

            }


        }



        public void MatrixManualFill(int size)
        {

            Console.WriteLine("Input elements: ");
            if (size % 2 != 0)
            {
                for (int i = 0; i < size; i++)
                {

                    for (int j = 0; j < size; j++)
                    {

                        _matrix[i, j] = int.Parse(Console.ReadLine());

                    }

                }


            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        _matrix[i, j] = 0;
                    }

                }

            }




        }



        public bool IsMagicSquare(int size)
        {

            //Can be united into 2 int
            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int firstRowSum = 0;
            int secondRowSum = 0;
            int firstColumnSum = 0;
            int secondColumnSum = 0;
            
            //Diagonals


            for (int i = 0; i < size; i++)
            {
               int j = i;
               mainDiagonalSum += _matrix[i, j];
                

            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    // Condition for secondary diagonal
                    if ((i + j) == (size - 1))
                    {
                        secondaryDiagonalSum += _matrix[i, j];
                    }
                       
                }
            }
            
            if(mainDiagonalSum != secondaryDiagonalSum)
            {
                return false ;
            }


            //Rows Correct

            for (int i = 0; i < size-1; i++)
            {
                firstRowSum = 0;
                secondRowSum = 0;

                for (int j = 0; j < size; j++)
                {


                    firstRowSum += _matrix[i, j];
                    secondRowSum += _matrix[i + 1, j];

                }



              // Console.WriteLine(firstRowSum);
             //  Console.WriteLine(secondRowSum);

                if(firstRowSum != secondRowSum)
                {
                    return false;
                }

            }


            //Columns REWORK

            for(int i =0;  i <size-1; i++)
            {

                firstColumnSum = 0;
                secondColumnSum = 0;

                for (int j =0; j <size; j++)
                {


                    firstColumnSum += _matrix[j, i];
                    secondColumnSum += _matrix[j, i+1];


                    
                }
               // Console.WriteLine(firstColumnSum);
               // Console.WriteLine(secondColumnSum);


                if(firstColumnSum!= secondColumnSum)
                {
                    return false;
                }


            }
           










            return true;

        }
 



        public void MatrixPrint(int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(_matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }




        }





    }
}
