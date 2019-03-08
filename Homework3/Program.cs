using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            // {
            //Console.WriteLine("Enter the length of the Collection");

            //int.TryParse(Console.ReadLine(), out var userInput);


            //var collection = new object[userInput];

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    Console.WriteLine("Enter Name Surname and Year of the user");
            //    collection[i] = Console.ReadLine();
            //}

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Read();
            // }

            Console.WriteLine("Enter the number of persons.");
            bool howMany = int.TryParse(Console.ReadLine(), out var userInput);
            DateTime[] arrayOfUserInputDates = new DateTime[userInput];

            for (int i = 0; i < arrayOfUserInputDates.Length; i++)
            {

                Console.WriteLine("Enter year of birth.");
                bool howManyYears = int.TryParse(Console.ReadLine(), out var year);
                Console.WriteLine("Enter month of birth.");
                bool howManyMonths = int.TryParse(Console.ReadLine(), out var month);
                Console.WriteLine("Enter day of birth.");
                bool howManyDays = int.TryParse(Console.ReadLine(), out var day);
                arrayOfUserInputDates[i] = new DateTime(year, month, day);

            }
            TimeSpan[] arrayOfDates = new TimeSpan[userInput];
            var firstDate = DateTime.Now;
            for (int i = 0; i < arrayOfUserInputDates.Length; i++)
            {
                var someDate = firstDate - arrayOfUserInputDates[i];
                arrayOfDates[i] = someDate;
                Console.WriteLine($"The timespan of the person with the date of birth {arrayOfUserInputDates[i]} is {someDate}");



            }

            TimeSpan emptySpan = new TimeSpan();
            for (int i = 0; i < arrayOfDates.Length; i++)
            {
                if (arrayOfDates[i] > emptySpan)
                {
                    emptySpan = arrayOfDates[i];
                }
            }

            Console.WriteLine($"The person with the timespan of {emptySpan} is the oldest.");







        }
    }
}
