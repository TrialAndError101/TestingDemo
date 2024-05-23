using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestDemoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //number 1
            bool ifExists = checkIfFileExists("D:\\Projects\\PizzaSalesAPI\\order_details.csv");
            Console.WriteLine("does file exist?:" + ifExists);


            //2
            Console.WriteLine("enter a number > 1000 or < 0 to trigger exception:");
            string input = Console.ReadLine();
            checknumber(input);
            Console.WriteLine("did not trigger");

            //4
            Console.WriteLine("input string for number 4 to convert to int32:");
            string input2 = Console.ReadLine();
            int parsedNumber;
            int.TryParse(input2, out parsedNumber);
            Console.WriteLine("did not trigger an error meaning parsed:" + parsedNumber);





            //6
            try
            {
                Console.WriteLine("input a number:");
                double input4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("input another number:");
                double input5 = Convert.ToDouble(Console.ReadLine());
                double res = input4 / input5;
                Console.WriteLine("Division result:" + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong with the inputs: " + ex.Message);
                throw;
            }


            //7
            try
            {

                Console.WriteLine("input a date:");
                string input6 = Console.ReadLine();
                DateTime dateTime = Convert.ToDateTime(input6);
                Console.WriteLine("new datetime: " + dateTime.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong with the inputs: " + ex.Message);
                throw;
            }

            //8
            try
            {

                Console.WriteLine("input a number to calculate for square root:");
                int input7 = Convert.ToInt32(Console.ReadLine());
                int squareRoot = input7 * input7;
                Console.WriteLine("square root:" + squareRoot);
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong. " + ex.Message);
                throw;
            }


            //9
            try
            {

                Console.WriteLine("input a string:");
                string input8 = Console.ReadLine();
                Console.WriteLine($"upper case of {input8} is {input8.ToUpper()}");
            }
            catch (Exception ex)
            {

                throw;
            }

            //10
            try
            {

                Console.WriteLine("input an int for factorial: ");
                int input9 = Convert.ToInt32(Console.ReadLine());
                int result = 1;
                for (int i = input9; i < input9; i--)
                {
                    result = input9 * result;
                }
                Console.WriteLine("factorial: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong. " + ex.Message);
                throw;
            }


            //3 get array as input and calculate average. input only 5 numbers
            try
            {
                int[] myNum = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("input an int for average computation: ");
                    int input9 = Convert.ToInt32(Console.ReadLine());
                    myNum[i] = input9;
                }
                Console.WriteLine($"the average of inputs is {myNum.Average()}");
            }
            catch (Exception ex )
            {
                Console.WriteLine($"something went wrong {ex.Message}");
                throw;
            }


            //5 //comment or uncomment other codes if you want to test this
            while (true)
            {
                Console.WriteLine("input int for number 5:");
                string input3 = Console.ReadLine();
                try
                {
                    int x = Convert.ToInt32(input3);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("cant convert to int32 " + ex.Message);
                }
            }

        }



        //for number 1
        private static bool checkIfFileExists(string filePath)
        {
            bool res;
            try
            {
                return File.Exists(filePath);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("'Could not find file "))
                {
                    res = false;//returns false if does not exists
                }
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //for number 2
        private static void checknumber(string data)
        {
            bool res;

            if (Convert.ToInt32(data) > 1000 || Convert.ToInt32(data) < 0)
            {
                throw new Exception("hit");
                    
            }
        }
    }
}