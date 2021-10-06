using System;
using System.Collections.Generic;
using System.Text;

namespace _NEW__Task_3_Magic_Square
{
    class MatrixPrint
    {




        public void PrintMatrix(Matrix obj)
        {

            for(int i = 0; i< obj.Size; i++)
            {
                for (int j = 0; j < obj.Size; j++)
                {

                    Console.Write($"{obj.GetElement(i,j)} ");



                }
                Console.WriteLine();

            }



        }


    }
}
