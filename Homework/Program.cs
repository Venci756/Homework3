using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of persons.");
            bool howMany = int.TryParse(Console.ReadLine(), out var userInput);
            string[] arrayOfNames = new string[userInput];
            string[] arrayOfLastNames = new string[userInput];

            if (howMany)
            {
                for (int i = 0; i < arrayOfNames.Length; i++)
                {
                    Console.WriteLine("Enter name.");
                    arrayOfNames[i] = Console.ReadLine();

                    Console.WriteLine("Enter last name.");
                    arrayOfLastNames[i] = Console.ReadLine();

                }

                for (int i = 0; i < arrayOfLastNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {arrayOfNames[i]}  {arrayOfLastNames[i]}.");
                }

                string longestName = "";
                for (int i = 0; i < arrayOfNames.Length; i++)
                {
                    if (arrayOfNames[i].Length > longestName.Length)
                    {
                        longestName = arrayOfNames[i];
                    }
                }
                Console.WriteLine($"The person with the longest name is {longestName}.");

                string longestLastName = "";
                for (int i = 0; i < arrayOfLastNames.Length; i++)
                {
                    if (arrayOfLastNames[i].Length > longestLastName.Length)
                    {
                        longestLastName = arrayOfLastNames[i];
                    }
                }
                Console.WriteLine($"The person with the longest last name is {longestLastName}.");

                string shortestName = arrayOfNames[0];
                for (int i = 0; i < arrayOfNames.Length; i++)
                {
                    if (arrayOfNames[i].Length < shortestName.Length)
                    {
                        shortestName = arrayOfNames[i];
                    }
                }
                Console.WriteLine($"The person with the shortest name is {shortestName}.");

                string shortestLastName = arrayOfLastNames[0];
                for (int i = 0; i < arrayOfLastNames.Length; i++)
                {
                    if (arrayOfLastNames[i].Length < shortestLastName.Length)
                    {
                        shortestLastName = arrayOfLastNames[i];
                    }
                }
                Console.WriteLine($"The person with the shortest last name is {shortestLastName}.");

                int sumOfNamesLength = 0;
                int sumOfLastNamesLength = 0;
                for (int i = 1; i < arrayOfNames.Length; i++)
                {
                    sumOfNamesLength = arrayOfNames[i - 1].Length + arrayOfNames[i].Length;
                    sumOfLastNamesLength = arrayOfLastNames[i - 1].Length + arrayOfLastNames[i].Length;
                }



                float averageOfNames = sumOfNamesLength / arrayOfNames.Length;
                float averageOfLastNames = sumOfLastNamesLength / arrayOfNames.Length;
                Console.WriteLine($"The average length of the names is {averageOfNames}.");
                Console.WriteLine($"The average length of the last names is {averageOfLastNames}.");


            }
            else Console.WriteLine("Please enter a valid number.");
        }
    }
}
