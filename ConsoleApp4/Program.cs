using ConsoleApp4.enums;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            Console.Write("enter the number of day of week\n");
            int input =int .Parse(Console.ReadLine());
            daysofweek day = (daysofweek)input;
            Console.WriteLine($"the day of week is {day}");
            switch (day) 
            {
                case daysofweek.saturday:
                case daysofweek.sunday:
                    Console.WriteLine("it is weekend");
                    break;
                default:
                    Console.WriteLine("it is workday");
                    break;
            }
            #endregion



        }
    }
}
