using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5._1_Sigma
{
    class StringText
    {

        private string[] _text;
        private int _amount;


        public StringText(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Parameters cannot be null or negative integrer", nameof(amount));
            }

            _amount = amount;
            _text = new string[_amount];



            Console.WriteLine("Enter text:");

            for (int i = 0; i  <_amount; i++)
            {

                _text[i] = Console.ReadLine();

            }

        }


        public void StringTextReplaceFeatures()
        {
            int[,] indexes = new int[3, 100];
            int size = 0;
            string[] result = new string[_amount];




            //Finding #
            for(int i = 0; i < _amount; i++)
            {

                for (int j = 0; j < _text[i].Length; j++ ){

                    if (_text[i][j] == '#')
                    {
                        indexes[0, size] = i;
                        indexes[1, size] = j;
                        size++;
                    }


                }


            }

            //Replacing

            int counter2 = 0;
            int counter = size + 1;

            for (int i = 0; i < _amount; i++)
            {

                for (int j = 0; j < _text[i].Length; j++)
                {
                    if(_text[i][j] == '#')
                    {

                        if (counter2<counter/2) // REWORK
                        {
                            result[i] += '<';
                            
                        }
                        else
                        {
                            result[i] += '>';

                        }

                        counter2++;
                    }
                    else
                    {
                        result[i] += _text[i][j];
                    }
                    
                
                    


                }


            }



            for(int i = 0; i < _amount; i++)
            {

                Console.WriteLine(result[i]);

            }




            




        }


        public void StringTextPrinter()
        {

            for (int i = 0; i < _amount ; i++){

                Console.WriteLine(_text[i]);


            }



        }





    }
}
