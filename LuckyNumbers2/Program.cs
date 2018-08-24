using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a starting number");
            int minNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a ending number");
            int maxNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(minNumber + " " + maxNumber);

            int[] userNum = new int[6];

            Console.WriteLine("Please enter six numbers");

            for (int i = 0; i < userNum.Length; i++)
            {
                int inputTest = int.Parse(Console.ReadLine());

                while (inputTest < minNumber || inputTest >= maxNumber)
                {
                    Console.WriteLine("Please enter a value greater than {0} and less than the {1}", minNumber, maxNumber);
                    inputTest = int.Parse(Console.ReadLine());
                }

                userNum[i] = inputTest;
                //Console.WriteLine(userNum[i]);
            } 
                int[] ranArray = new int[6];
                Random r = new Random();

                for (int j = 0; j < ranArray.Length; j++)
                {
                    ranArray[j] = r.Next(minNumber, maxNumber);
                    Console.WriteLine("Lucky Number: {0}" ,ranArray[j]);
                }


            }
           
    }
}
