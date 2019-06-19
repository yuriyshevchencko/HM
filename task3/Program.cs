using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {

     
                Console.WriteLine("Enter the minimum value of interval");
                int min = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out min) && min > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, the value should be integer and be positive");
                    }
                }

                if (min < 1)
                {
                    Random random = new Random();

                    min = random.Next(1, 20);

                    Console.WriteLine($"The random value - {min} is set");
                }


                Console.WriteLine("Enter the maximum value of interval");
                int max = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out max) && (max - min) >= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, the value should be integer and be positive");
                    }
                }

                if ((max- min)<=10)
                {
                    Random random = new Random();

                    //max = min + 15;
                    max = random.Next(40, 45);

                    Console.WriteLine($"The random value - {max} is set");
                }


                int sum = 0;
                for (int i = min; i <= max; i++)
                {

                    if (i % 3 == 0 && i % 5 != 0)
                    {

                        Console.WriteLine($"This value is divisible by three and not divisible by five: {i}");
                        sum += i;
                    }


                }

                Console.WriteLine($"Summ of all values is {sum}");

            }

        }
    }
}


