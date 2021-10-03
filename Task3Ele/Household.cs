using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace Sigma_Task_3_electricity_accounting
{

    class Household
    {


        //Data
        public int amount;
        private int quarter;
        private int number;
        private string name;
        private int[,] counterReadings = new int[2, 3]; //quatrer = 3 mnths


        //Functions

        //Constructors 

       public Household()
        {

            this.name = "Noname";
            this.number = 0;
            for(int i = 0; i < 2; i++)
            {
                this.counterReadings[0, i] = 0;
                this.counterReadings[1, i] = 0;
            }



        }







        //Properties

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 0)
                {
                    number = value;
                }
                else
                {
                    number = 0;
                }


            }


        }


        public string Name
        {
            set
            {
                value = name;
            }
            get
            {
                return name;
            }
        }

        //General

        public void ReadFromFile(string filePath, Household[] pool)
        {

            using (TextReader reader = File.OpenText(filePath))
            {

                amount = int.Parse(reader.ReadLine());
                if(amount < 0)
                {
                    amount = 1;
                }




                quarter = int.Parse(reader.ReadLine());
                if(quarter>=1 && quarter <= 4)
                {

                }
                else
                {
                    quarter = 1;
                }

                //Initialisation
                for(int i = 0;  i < amount; i++)
                {
                    pool[i] = new Household();
                }



                for(int i =0 ; i < amount; i++) 
                {
                   
                    pool[i].number = int.Parse(reader.ReadLine());
                    if (number < 0)
                    {
                        number = 1;
                    }


                    pool[i].name = reader.ReadLine();



                   
                    for(int j = 0; j <3; j++)
                    {
                        pool[i].counterReadings[0, j] = int.Parse(reader.ReadLine());
                        pool[i].counterReadings[1, j] = int.Parse(reader.ReadLine());
                    }
                    

                }











              
            }




        }

     
        public  void HouseholdsPrint(int amount, Household[] pool)
        {
            string output;
           
            string firstMonth ="";
            string secondMonth="";
            string thirdMonth="";



            Console.WriteLine($"Quarter: {quarter}");
            Console.WriteLine($"Amount of Households: {amount}");
            Console.WriteLine();

            for(int i = 0; i <amount; i++)
            {

                output = $"############## Household index: {i} ############## \n#Number of Appartment: {pool[i].number} \n#Name of Owner: {pool[i].name}";
                Console.WriteLine(output);


                //QUARTERS
                switch (quarter)
                {
                    case 1:
                        firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(1);
                        secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(2);
                        thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(3);
                        break;
                    case 2:
                        firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(4);
                        secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(5);
                        thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(6);
                        break;
                    case 3:
                        firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(7);
                        secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(8);
                        thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(9);
                        break;
                    case 4:
                        firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(10);
                        secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(11);
                        thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(12);
                        break;
                }

                //string name = DateTimeFormatInfo.CurrentInfo.GetMonthName(1);                


                //TEST
            
                output = $"#Readings: \t {firstMonth} \t {secondMonth}\t {thirdMonth} \n#Input:  \t {pool[i].counterReadings[0, 0]} \t {pool[i].counterReadings[0, 1]} \t {pool[i].counterReadings[0, 2]} " +
                    $"\n#Output: \t {pool[i].counterReadings[1, 0]} \t {pool[i].counterReadings[1, 1]} \t {pool[i].counterReadings[1, 2]}";
                Console.WriteLine(output);

                output = $"###################################################";
                Console.WriteLine(output);
                


               

                Console.WriteLine();



            }


        }


        public void HouseholdPrint(int index, Household[] pool)
        {



            string output;
            string firstMonth = "";
            string secondMonth = "";
            string thirdMonth = "";



            Console.WriteLine($"Quarter: {quarter}");
            Console.WriteLine();



            output = $"############## Household index: {index} ############## \n#Number of Appartment: {pool[index].number} \n#Name of Owner: {pool[index].name}";
            Console.WriteLine(output);


            //QUARTERS
            switch (quarter)
            {
                case 1:
                    firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(1);
                    secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(2);
                    thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(3);
                    break;
                case 2:
                    firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(4);
                    secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(5);
                    thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(6);
                    break;
                case 3:
                    firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(7);
                    secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(8);
                    thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(9);
                    break;
                case 4:
                    firstMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(10);
                    secondMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(11);
                    thirdMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(12);
                    break;
            }

            //string name = DateTimeFormatInfo.CurrentInfo.GetMonthName(1);                


            output = $"#Readings: \t {firstMonth} \t {secondMonth}\t {thirdMonth} \n#Input:  \t {pool[index].counterReadings[0, 0]} \t {pool[index].counterReadings[0, 1]} \t {pool[index].counterReadings[0, 2]} " +
                $"\n#Output: \t {pool[index].counterReadings[1, 0]} \t {pool[index].counterReadings[1, 1]} \t {pool[index].counterReadings[1, 2]}";
            Console.WriteLine(output);

            output = $"###################################################";
            Console.WriteLine(output);


            Console.WriteLine();










        }

        public void HouseholdsMaxDebd(int amount , Household[] pool, double price)
        {

            double[] debts = new double[50];
            int index = 0;

            if (price <= 0)
            {
                price = 5;
            }



            for(int i = 0; i < 50; i++)
            {
                debts[i] = 0;
            }


            for(int i =0; i <amount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    debts[i] += (pool[i].counterReadings[1, j] - pool[i].counterReadings[0, j])*price;

                }

            }


            for(int i = 0;  i< amount; i++)
            {
                if (debts[i] > debts[i + 1])
                {
                    index = i;
                }
               

            }





            Console.WriteLine($"Name of Owner with the biggest debt is: {pool[index].name}, debt is {debts[index]}");



        }

        public void HouseholdWithoutEnergyUsage(int amount, Household[] pool)
        {

            for (int i = 0; i < amount; i++)
            {

                for(int j = 0; j<3; j++)
                {
                    if ((pool[i].counterReadings[1, j] - pool[i].counterReadings[0, j]) == 0 )
                    {

                        Console.WriteLine($"Household without energy use in certain month has index: {i}");


                    }


                }






            }





        }


        public void HouseHoldMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Print All Households; ");
            Console.WriteLine("2 - Print Selected Household;");
            Console.WriteLine("3 - Household With The Biggest Debt;");
            Console.WriteLine("4 - Household Without Energy Usage;");
            Console.WriteLine("10 - Exit;");
        }








        //Destructor
        ~Household() { }

    }
}
