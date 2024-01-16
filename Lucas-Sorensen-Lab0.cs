using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a low number: ");
            int lowNum = GetLowNumber();
            int highNum = GetHighNumber(lowNum);
            int difference = highNum - lowNum;

            int[] arr = { 20, 30, 40 };
            int[] arr1 = new int[10];

            arr1[3] = 30;

            for (int i = 0; i < 10; i++)
            {
                arr1[i] = i * 10;
                Console.WriteLine($"The value at index {i} is: {arr1[i]}");
            }

            List<double> ListOfNumbers = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                ListOfNumbers.Add(i * 10);
                Console.WriteLine($"The value at index {i} of the List is: {ListOfNumbers[i]}");
            }

            using (StreamWriter sw = new StreamWriter("/Desktop/number.txt"))
            {
                foreach (double number in ListOfNumbers)
                {
                    sw.WriteLine(number);
                }
            }

            
        }
        public static int GetLowNumber()
        {
            int newlow;
            while(true)
            {
                string userInput = Console.ReadLine();

                bool t = int.TryParse(userInput, out newlow);
                if (t && newlow > 0)
                {
                    return newlow;
                }
                else
                {
                    Console.WriteLine("Invalid input, please re-enter a low +ve number");
                }
            }
        }



        public static int GetHighNumber(int lowNum)
        {
            int newHigh = 0;
            Console.WriteLine("Please enter a high number");
            while(true)
            {
                string userInput = Console.ReadLine();

                bool t = int.TryParse(userInput, out newHigh);
                if (t && newHigh > lowNum)
                {
                    return newHigh;
                }
                else
                {
                    Console.WriteLine($"Invalid input, please re-enter a number greater than: {lowNum}");
                }
            }
        }


        
    }
}
