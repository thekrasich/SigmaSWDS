using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6._3_Sigma_Matrix
{
    class Matrix
    {

        protected int _size;
        protected double[,] _matrix;



        //Constructors
        public Matrix()
        {
           
            System.Random random = new System.Random();
            _size = 1;
            _matrix = new double[_size, _size];
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _matrix[i, j] = random.Next(0,50);
                }
            }
        }
        public Matrix(int size)
        {
            if (size <= 0)
            {
                _size = 1;
            }
            else
            {
                _size = size;
            }
            _matrix = new double[_size, _size];
            System.Random random = new System.Random();
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {

                    _matrix[i, j] = random.Next(0, 50); ;

                }
            }
        }


        public double GetElement(int i, int j)
        {
            if ((i < 0 && i > _size) || (j < 0 && j > _size))
            {
                throw new ArgumentException("Index cannot be out of range");
            }


            return _matrix[i, j];
        }


        public int Size
        {
            get => _size;
        }


        

        public void MatrixForeachTest()
        {
            ReverseMatrix(_matrix);
           foreach(int i in _matrix)
            {
                Console.Write("{0} ", i);
            }



        }

        public void MatrixPrint()
        {
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j<Size;j++)
                {
                    Console.Write($"{_matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }



        static void ReverseMatrix<T>(T[,] matrix)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);
            int startRow = 0;
            int startCol = 0;
            int endRow = height - 1;
            int endCol = width - 1;

            while (true)
            {
                if (startRow == height - 1 || endRow == 0) return;

                // swap
                var temp = matrix[startRow, startCol];
                matrix[startRow, startCol] = matrix[endRow, endCol];
                matrix[endRow, endCol] = temp;

                startCol++;
                endCol--;
                if (startCol == width)
                {
                    startRow++;
                    startCol = width - 1;
                }
                if (endCol == -1)
                {
                    endRow--;
                    endCol = 0;
                }
            }
        }


    }
}
