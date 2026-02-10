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
            #region Q4
            //double result = 0;
            //Console.WriteLine("enter the value of the first param");
            //double num=double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the value of the second param");
            //double num2=double.Parse(Console.ReadLine());
            //Console.WriteLine("choose the operation +,-,*,/");
            //char op=char.Parse(Console.ReadLine());

            //if(op == '+')
            //{
            //    result= add(num, num2);
            //    Console.WriteLine("resutl = " + result);    
            //}
            //else if(op == '-')
            //{
            //    result=subtract(num, num2);
            //    Console.WriteLine("resutl = " + result);
            //}
            //else if (op == '*')
            //{
            //    result = multiply(num, num2);
            //    Console.WriteLine("resutl = " + result);
            //}
            //else if (op == '/')
            //{
            //    result = divide(num, num2);
            //    Console.WriteLine("resutl = " + result);
            //}
            //else
            //{
            //    Console.WriteLine("invalid operator");
            //}
            #endregion
            #region Q5
            //double area;
            //double circumference;
            //Console.WriteLine("enter the radius of the circle");
            //double radius=double.Parse(Console.ReadLine());
            //CalculateCircle(radius, out area, out circumference);
            //Console.WriteLine($"the area of the circle is {area}");
            //Console.WriteLine($"the circumference of the circle is {circumference}");
            #endregion
            #region Q6
            //Console.WriteLine("enter the number of students");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr=new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"enter the score of student{i+1} :");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    grades grade=   getgrade(arr[i]);
            //    Console.WriteLine($"the grade of student {i+1} his score is {arr[i]} is {grade}");
            //}
            //double avg = calculateavg(arr);
            //Console.WriteLine($"the average score of the class is {avg}");
            // int max = calculatemax(arr);
            //Console.WriteLine($"the max score of the class is {max}");
            //int min = calculatemin(arr);
            //Console.WriteLine($"the min score of the class is {min}");
            #endregion


        }
        #region Q4
        //static double add(double x, double y) 
        //{ 
        //return x+ y;
        //}
        //static double subtract(double x, double y) 
        //{
        //    return x - y;
        //}
        //static double multiply(double x, double y)
        //{
        //    return x * y;
        //}
        //static double divide(double x, double y)
        //{
        //    if ( y==0)
        //    {
        //        Console.WriteLine("error can not divide by 0 "); 
        //        return 0;
        //    }
        //    return x / y;
        //}
        #endregion
        #region Q5
        //static void CalculateCircle(double radius,out double area,out double circumference)
        //{
        //    area = Math.PI * radius * radius;
        //    circumference = 2 * Math.PI * radius;
        //}
        #endregion
        #region Q6
        //static grades getgrade(double score)
        //{
        //    if (score >= 90) return grades.A;
        //    else if(score >= 80) return grades.B;
        //    else if(score >= 70) return grades.C;
        //    else if(score >= 60) return grades.D;
        //    else return grades.F;
        //}
        //static double calculateavg(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum / arr.Length;
        //}
        //static int calculatemax(int[] arr)
        //{
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    return max;
        //}
        // static int calculatemin(int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //    }
        //    return min;
        //}
        #endregion
    }
}
