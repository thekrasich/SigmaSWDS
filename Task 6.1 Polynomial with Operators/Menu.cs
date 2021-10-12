using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Pilynom
{
    class Menu
    {
        

    
          public bool menuStatus = true;
            public string menuChoice;
           
            public Menu()
            {
                menuStatus = true;
            }

            //General
            public void MenuInitialisation()
            {

                MenuChoicesConsolePrint();

            Console.WriteLine("Enter first expression: (in form : x^4 + x + 5 ) ");
            string firstExpr = Console.ReadLine();
            Console.WriteLine("Enter second expression: (in form : x^4 + x + 5 ) ");
            string secondExpr = Console.ReadLine();
            Polynomial result = new Polynomial();
            Polynomial x, y;
            x = Polynomial.Parse(firstExpr);
            y = Polynomial.Parse(secondExpr);


            while (menuStatus)
                {
                    Console.WriteLine("Enter a command: ");

                    menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {

                        case "1":
                       
                        result = result.PolunomAddition(x,y );
                        result.PolynomPrint();
                        break;

                        case "2":


                        result = result.PolynomSubstraction(x, y);
                        result.PolynomPrint();



                        break;
                        case "3":
                        result = result.PolynomMultiplication(x, y);
                        result.PolynomPrint();

                        break;
                        

                        case "0":
                            menuStatus = false;
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Error! Enter command again;");
                            break;

                    }
                }

            }
            public void MenuChoicesConsolePrint()
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1.Add Two Polynomials ");
                Console.WriteLine("2.Substract Two Polynomials ;");
                Console.WriteLine("3.Multiplicate Two Polynomials");
                Console.WriteLine("0. Finish the Program ");
            }

           


        




    }





}

