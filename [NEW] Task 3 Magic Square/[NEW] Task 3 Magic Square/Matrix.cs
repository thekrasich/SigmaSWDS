using System;
using System.Collections.Generic;
using System.Text;

namespace _NEW__Task_3_Magic_Square
{
    class Matrix
    {
        protected int _size;
        protected double[,] _matrix = new double[100,100];




        //Constructors
        public Matrix() 
        {
            _size = 1;
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _matrix[i, j] = 0;
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


            for(int i =0; i < _size;i++ )
            {
                for (int j = 0; j < _size; j++)
                {

                    _matrix[i, j] = 0;

                }
            }
        }


        public double GetElement(int i , int  j)
        {
            if(( i <0 && i>_size) || (j < 0 && j > _size))
            {
                throw new ArgumentException("Index cannot be out of range");
            }


            return _matrix[i, j];
        }


        public int Size
        {
            get => _size;
        }













    }

}
