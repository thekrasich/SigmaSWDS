using System;

namespace Task_5._2_Sigma
{
    class Program
    {
        static void Main(string[] args)
        {



            GridImage example = new GridImage(4, 4, 4);

            Console.WriteLine("Grid shadow by XY:");
            example.GridShadowByXY();
            Console.WriteLine("Grid shadow by XZ:");
            example.GridShadowByXZ();
            Console.WriteLine("Grid shadow by YZ:");
            example.GridShadowByYZ();

        }
    }
}
