using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5._2_Sigma
{
    class GridImage
    {
        private int[,,] _3dObject;
        private int _x, _y, _z;
        

        public GridImage(int x ,int y , int z)
        {
            Random rand = new Random();
            if(x>0 && y>0 && z > 0)
            {
                _x = x;
                _y = y;
                _z = z;
            }
            else
            {
                throw new ArgumentException("Parameters cannot be null or negative integrer");
            }






            _3dObject = new int[x, y, z];



            for(int i = 0; i < _x; i++)
            {
                for(int j = 0; j<_y; j++)
                {
                    for(int k = 0; k < _z; k++)
                    {

                        _3dObject[i, j, k] = rand.Next(0,2);

                    }

                }

            }


        }


        public int getXElement(int y , int z)
        {
            for (int i = 0; i < _x; i++)
            {
                if (_3dObject[i,y,z] == 1)
                {
                    return 1;
                }
            }
            return 0;


        }

        public int getYElement(int x, int z)
        {
            for (int i = 0; i < _y; i++)
            {
                if (_3dObject[x, i,z] == 1)
                {
                    return 1;
                }
            }
            return 0;
        }

        public int getZElement(int x, int y)
        {
            for (int i = 0; i < _z; i++)
            {
                if (_3dObject[x, y, i] == 1)
                {
                    return 1;
                }
            }
            return 0;
        }



        //[i,j,k
        public void GridShadowByXY()
        {
            int[,] xy = new int[_x,_y];

            for (int x = 0; x < _x; x++)
            {
                for (int y = 0; y < _y; y++)
                {
                    xy[x, y] = getZElement(x,y);
                }
            }

            GridShadowPrinter(xy, _x, _y);

        }
        //[i,j,k
        public void GridShadowByYZ()
        {
            int[,] yz = new int[_y, _z];

            for (int y = 0; y < _y; y++)
            {
                for (int z = 0; z < _z; z++)
                {
                    yz[y, z] = getXElement(y, z);
                }
            }

            GridShadowPrinter(yz, _y, _z);

        }
        //[i,j,k
        public void GridShadowByXZ()
        {

            int[,] xz = new int[_x, _z];

            for (int x = 0; x < _x; x++)
            {
                for (int z = 0; z < _z; z++)
                {
                    xz[x, z] = getYElement(x, z);
                }
            }

            GridShadowPrinter(xz, _x, _z);




        }


        public void GridShadowPrinter(int[,] matrix, int x , int y)
        {
            for(int i = 0; i < x; i++)
            {
                for(int j = 0;  j < y; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();

            }



        }










    }
}
