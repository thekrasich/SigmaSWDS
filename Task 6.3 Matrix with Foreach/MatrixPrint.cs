using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6._3_Sigma_Matrix
{
    class MatrixPrint
    {
        public void PrintMatrix(Matrix obj)
        {

            for (int i = 0; i < obj.Size; i++)
            {
                for (int j = 0; j < obj.Size; j++)
                {

                    Console.Write($"{obj.GetElement(i, j)} ");



                }
                Console.WriteLine();

            }



        }

      



















    }
}
