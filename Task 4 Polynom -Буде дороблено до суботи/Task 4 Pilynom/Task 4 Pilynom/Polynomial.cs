using System;


namespace Task_4_Pilynom
{
    class Polynomial
    {

        //Data

        private double[] _coefficients = new double[100];
        private int _power;


        //Functions

        //Constructors

        public Polynomial()
        {
            _power = 1;
            for (int i = 0; i < _power; i++)
            {
                _coefficients[i] = 0;
            }
        }

        public Polynomial(int power, int[] coefficients)
        {
            if (power > 0)
            {
                _power = power;
            }
            else
            {
                _power = 1;
            }

            for (int i = 0; i < _power; i++)
            {

                _coefficients[i] = coefficients[i];

            }



        }

        public Polynomial(int power)
        {
            if (power > 0)
            {
                _power = power;
            }
            else
            {
                _power = 1;
            }

            for (int i = 0; i < _power; i++)
            {

                _coefficients[i] = 0;

            }
        }



        //General






        //Indexator for coefficient
        public double this[int index]
        {
            get
            {
                return _coefficients[index];
            }
            set
            {

                if (value > 0 && _power > index)
                {
                    _coefficients[index] = value;
                }
                if (value > 0 && index > _power)
                {
                    _power = index;
                    _coefficients[index] = value;

                }
                if (value == 0)
                {
                    //"Delete"
                    _coefficients[index] = value;

                }
                if (value == 0 && index < _power)
                {
                    //Nothing
                }

                _coefficients[index] = value;



            }
        }

        public void PolunomAddition(Polynomial alpha, Polynomial beta)
        {

            if (alpha._power >= beta._power)
            {

                for (int i = 0; i < beta._power; i++)
                {
                    alpha._coefficients[i] += beta._coefficients[i];
                }

            }
            else
            {

                for (int i = 0; i < alpha._power; i++)
                {
                    beta._coefficients[i] += alpha._coefficients[i];
                }


            }




        }

        public void PolynomSubstraction(Polynomial alpha, Polynomial beta)
        {

            if (alpha._power >= beta._power)
            {

                for (int i = 0; i < beta._power; i++)
                {
                    alpha._coefficients[i] -= beta._coefficients[i];
                }

            }
            else
            {

                for (int i = 0; i < alpha._power; i++)
                {
                    beta._coefficients[i] -= alpha._coefficients[i];
                }


            }



        }
        //REWORK
        public void PolynomMultiplication(Polynomial alpha, Polynomial beta)
        {

            for (int i = 0; i < alpha._power; ++i)
            {
                for (int j = 0; j < beta._power; ++j)
                {
                    alpha._coefficients[i + j] += alpha._coefficients[i] * beta._coefficients[j];
                }
            }

            alpha._power = alpha._power + beta._power;


        }

        //TEST + REWORK
        public void PolynomPrint()
        {

            for (int i = _power; i > 0; i--)
            {
                Console.Write($"{_coefficients[i - 1]}x^{i} + ");


            }


        }














        //Parse
        public static Polynomial Parse(string input)
        {
            Polynomial result = new Polynomial();
            string redStr = "";
            string[] powerStr = new string[100];
            int size = 0;
            string[] coefficientsStr = new string[100];
            int counter = 0;
           

            //Get rid of spaces
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    redStr += input[i];


                }
            }

           
            //Findind the power
            for (int i = 0; i < redStr.Length; i++)
            {


                int index;
                if (redStr[i] == '^' )
                {

                    index = i+1;
                    for(;index<redStr.Length ;index++)
                    {
                       if( redStr[index] == '1' || redStr[index] == '2' || redStr[index] == '3' || redStr[index] == '4' || redStr[index]=='5' || redStr[index] == '6' || redStr[index] == '7' || redStr[index] == '8' || redStr[index] == '9'|| redStr[index] == '0')
                       {
                            powerStr[size] += redStr[index];



                       }
                        else
                        {
                            size++;
                            break;
                        }
                    }


                   
             
                }
                else if (redStr[i] == 'x' && redStr[i+1] != '^')
                {
                    powerStr[size] += '1';
                    size++;
                }
               // coeff without x will be seen in array
               
                
                

            }





            //Findind the coeffs REWORK first + second elemenets
            for (int i = 0; i < redStr.Length; i++)
            {


                int index;
                if (redStr[i] == 'x')
                {

                    index = i;
                    for (; index >0; index--)
                    {
                        if (index > 0)
                        {


                            if (redStr[index - 1] == '1' || redStr[index - 1] == '2' || redStr[index - 1] == '3' || redStr[index - 1] == '4' || redStr[index - 1] == '5' || redStr[index - 1] == '6' || redStr[index - 1] == '7' || redStr[index - 1] == '8' || redStr[index - 1] == '9' || redStr[index - 1] == '0' || redStr[index - 1] == '.')
                            {
                                coefficientsStr[counter] += redStr[index - 1];



                            }
                            else if (redStr[index - 1] == '-')
                            {
                                coefficientsStr[counter] += '-';
                                counter++;
                                break;
                            }
                            else 
                            {
                                counter++;
                                break;
                            }
                        }
                       
                    }




                }
               


            }
            //For c 
            for (int i = redStr.Length-1; i > 0; i--)
            {

                if (redStr[i] == '1' || redStr[i] == '2' || redStr[i] == '3' || redStr[i] == '4' || redStr[i] == '5' || redStr[i] == '6' || redStr[i] == '7' || redStr[i] == '8' || redStr[i] == '9' || redStr[i] == '.')
                {
                    coefficientsStr[counter] += redStr[i];

                    

                }
                else if (redStr[i] == '-')
                {
                    coefficientsStr[counter] += '-';
                    counter++;
                    break;
                }
                else if (redStr[i] == '+')
                {
                    counter++;
                    break;
                }




            }





            //Convert -> int
            int[] coeffs = new int[100];
            int[] powers = new int[100];
            string[] newCoeffStr = new string[100];
           
            for(int i = 0; i<size; i++)
            {
                powers[i] = Convert.ToInt32(powerStr[i]);

            }


            //reverse
            for (int i = 0; i < counter; i++)
            {
                for (int j = coefficientsStr[i].Length-1;  j!=0 ; j-- )
                {
                    newCoeffStr[i] += coefficientsStr[i][j];
                }
               
            }


           



            //Test
            Console.WriteLine("Coeffs:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(newCoeffStr[i]);
            }
            Console.WriteLine("Power:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(powers[i]);
            }






















            result._power = powers[0];
          

            //Test
            Console.WriteLine(redStr);
           // Console.WriteLine(powerStr);
           
            return result;
        }


        //Destructor
        ~Polynomial() { }
    }
}
