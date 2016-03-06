using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P117
{
    class Program
    {
        public static void Reset (int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

        public static void Input(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter value at coords (" + i + ", " + j + ")");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void Output(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int PrintSumOfRows(int[,] arr)
        {
            int sum = 0;
            int totalSum = 0;
            string res = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                res += "The sum in row " + i + " is " + sum + "\n";
                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine(res);
            return totalSum;
        }

        public static int PrintSumOfCol(int[,] arr)
        {
            int sum = 0;
            int totalSum = 0;
            string res = "";
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }
                res += "The sum in col " + i + " is " + sum + "\n";
                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine(res);
            return totalSum;
        }

        public static int GetSumOfOuterShell(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[0, i] + arr[(arr.GetLength(0) - 1), i];
            }
            for (int i = 1; i < arr.GetLength(1) - 1; i++)
            {
                sum += arr[i, 0] + arr[i, arr.GetLength(1) - 1];
            }
            Console.WriteLine("The sum of the outer shell is: " + sum);
            return sum;
        }

        public static int GetSumMainDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine("The sum of the main diagonal is: " + sum);
            return sum;
        }

        public static int GetSumAboveMainDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - i - 1; j++)
                {
                    sum += arr[i, j + i + 1];
                }
            }
            Console.WriteLine("The sum above the main diagonal is: " + sum);
            return sum;
        }

        public static void GetSumBelowMainDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("The sum below the main diagonal is: " + sum);
        }

        public static void GetSumSecondaryDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, arr.GetLength(1) - 1 - i];
            }
            Console.WriteLine("The sum of the secondary diagonal is: " + sum);
        }

        public static void GetSumBelowSecondaryDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j < arr.GetLength(0))
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("The sum below the secondary diagonal is: " + sum);
        }

        public static void GetSumAboveSecondaryDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j < arr.GetLength(0) - 1)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("The sum above the secondary diagonal is: " + sum);
        }

        const int N = 5;

        static void Main(string[] args)
        {
            int[,] arr = new int[N, N];
            Input(arr);
            Output(arr);
            PrintSumOfRows(arr);
            PrintSumOfCol(arr);
            GetSumOfOuterShell(arr);
            GetSumMainDiagonal(arr);
            GetSumAboveMainDiagonal(arr);
            GetSumBelowMainDiagonal(arr);
            GetSumSecondaryDiagonal(arr);
            GetSumBelowSecondaryDiagonal(arr);
            GetSumAboveSecondaryDiagonal(arr);
        }
    }
}
//Enter value at coords(0, 0)
//    25
//    Enter value at coords(0, 1)
//    6
//    Enter value at coords(0, 2)
//    35
//    Enter value at coords(0, 3)
//    20
//    Enter value at coords(0, 4)
//    15
//    Enter value at coords(1, 0)
//    48
//    Enter value at coords(1, 1)
//    95
//    Enter value at coords(1, 2)
//    62
//    Enter value at coords(1, 3)
//    77
//    Enter value at coords(1, 4)
//    23
//    Enter value at coords(2, 0)
//    24
//    Enter value at coords(2, 1)
//    1
//    Enter value at coords(2, 2)
//    2
//    Enter value at coords(2, 3)
//    5
//    Enter value at coords(2, 4)
//    6
//    Enter value at coords(3, 0)
//    56
//    Enter value at coords(3, 1)
//    55
//    Enter value at coords(3, 2)
//    42
//    Enter value at coords(3, 3)
//    89
//    Enter value at coords(3, 4)
//    91
//    Enter value at coords(4, 0)
//    22
//    Enter value at coords(4, 1)
//    20
//    Enter value at coords(4, 2)
//    50
//    Enter value at coords(4, 3)
//    40
//    Enter value at coords(4, 4)
//    60
//    25 6 35 20 15
//    48 95 62 77 23
//    24 1 2 5 6
//    56 55 42 89 91
//    22 20 50 40 60
//    The sum in row 0 is 101
//    The sum in row 1 is 305
//    The sum in row 2 is 38
//    The sum in row 3 is 333
//    The sum in row 4 is 192

//    The sum in col 0 is 175
//    The sum in col 1 is 177
//    The sum in col 2 is 191
//    The sum in col 3 is 231
//    The sum in col 4 is 195

//    The sum of the outer shell is: 541
//    The sum of the main diagonal is: 271
//    The sum above the main diagonal is: 340
//    The sum below the main diagonal is: 358
//    The sum of the secondary diagonal is: 171
//    The sum below the secondary diagonal is: 543
//    The sum above the secondary diagonal is: 372
