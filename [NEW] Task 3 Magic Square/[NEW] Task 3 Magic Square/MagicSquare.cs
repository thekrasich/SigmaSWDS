using System;
using System.Collections.Generic;
using System.Text;

namespace _NEW__Task_3_Magic_Square
{
    class MagicSquare: Matrix
    {
        

        public void MagicSquareGenerate(int size)
        {
            _size = size;
            if (_size>0 && _size % 2 != 0)
            {

                int x = _size / 2;
                int y = _size - 1;
                int i = 1;


                while(i <= _size * _size)
                {

                    if(x == -1 && y == _size)
                    {
                        x = 0;
                        y = _size - 2;
                    }
                    else
                    {
                        if (y == _size)
                        {
                            y = 0;
                        }
                        if (x < 0)
                        {
                            x = _size - 1;
                        }

                    }
                    if(_matrix[x,y]!=0)
                    {
                        y -= 2;
                        x++;
                    }
                    else
                    {
                        _matrix[x, y] = i++;


                        x--;
                        y++;
                    }




                }









            }
            else
            {
                _size = 1;
                for(int i = 0; i < _size; i++)
                {
                    for(int j = 0; j <_size; j++)
                    {
                        _matrix[i, j] = 0;
                    }
                   
                }
            }


        }


        //Test
        /*
        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.Write($"{_matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        */

    }
}
