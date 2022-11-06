using System;

namespace Project
{
    class Program
    {
        static int solution(int Y, int A, int B)
        {
            //extract the month
            int daysInStartingMonth = DateTime.DaysInMonth(Y, A);       //number of days for first month
            int daysInFinishingMonth = DateTime.DaysInMonth(Y, B);      //number of days for last month

            //extract day for first monday
            DateTime dt = new DateTime(Y, A, 1);
            while (dt.DayOfWeek != DayOfWeek.Monday)
            {
                dt = dt.AddDays(1);
            }
            //Console.WriteLine(dt.Day);

            int daysInStartingMonthFromFirstMonday = daysInStartingMonth - (dt.Day - 1);
            int numberOfWeeksHoliday = (int)Math.Ceiling((daysInStartingMonthFromFirstMonday + daysInFinishingMonth) / 7.0);

            //Console.WriteLine($"Holidays start on Monday {dt.Day}/{A}/{Y}.\nTotal holiday: {numberOfWeeksHoliday} weeks");
            return numberOfWeeksHoliday;
        }

        static void Main(string[] args)
        {
          //Y=year, A=holiday starting month, B=holiday finishing month
          Console.WriteLine(solution(2014, 2, 3));
          Console.WriteLine(solution(2016, 2, 3));
          Console.WriteLine(solution(2020, 2, 3));
          Console.WriteLine(solution(2023, 2, 3));
        }
    }
}
