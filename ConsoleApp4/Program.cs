using ConsoleApp4.enums;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //Console.Write("enter the number of day of week\n");
            //int input =int .Parse(Console.ReadLine());
            //daysofweek day = (daysofweek)input;
            //Console.WriteLine($"the day of week is {day}");
            //switch (day) 
            //{
            //    case daysofweek.saturday:
            //    case daysofweek.sunday:
            //        Console.WriteLine("it is weekend");
            //        break;
            //    default:
            //        Console.WriteLine("it is workday");
            //        break;
            //}
            #endregion
            #region ََQ2

            //Console.Write("enter the size of array");
            //int size=int.Parse(Console.ReadLine());
            //int[] number = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"enter element {i + 1} : ");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //double avg = 0;
            //int max = number[0];
            //int min = number[0];
            //for (int i= 0;i  < size;i ++)
            //{
            //    sum += number[i];
            //        if(number[i] > max)
            //        {
            //            max = number[i];
            //        }
            //        if (number[i] < min)
            //        {
            //            min = number[i];
            //        }
            //}
            //avg = sum / size;
            //Console.WriteLine($"the sum of array is {sum}");
            //Console.WriteLine($"the average of array is {avg}");
            //Console.WriteLine($"the max of array is {max}");
            //Console.WriteLine($"the min of array is {min}");
            //for(int i=size-1;i >= 0;i--)
            //{
            //    Console.Write($"{number[i]} ");
            //}

            #endregion
            #region Q3
            //int[,] matrix= new int[3, 4];
            //double classsum = 0;
            //double sum = 0;
            //double studentavg = 0;
            //int total = matrix.GetLength(1);
            //for (int i = 0; i <matrix.Length; i++)
            //{
            //    Console.WriteLine(  $"enter the grade of student {i/total+1} in subject {i%total+1}");
            //    matrix[i/total,i%total]=int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            //    studentavg=sum / 4;
            //    classsum += sum ;
            //   Console.WriteLine($"the average of student {i+1} is {studentavg}");
            //    sum = 0;
            //}
            //double classavg = classsum / (3*4 );
            //Console.WriteLine($"the class average is {classavg}");
            #endregion


        }
    }
}
