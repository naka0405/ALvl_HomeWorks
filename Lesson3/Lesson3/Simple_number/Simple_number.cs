using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDLL


{
    public class Simple_number
    {
        public static string SimpleNumber(int a)
        {
            var flag = true;
            string result = null;
            if (a > 1)
            {
                for (var i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        flag = false;                        
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag == true)
            {               
                result = $"\nNumber {a} is simple";
            }
            else                
                result = $"\nNumber {a} isn't simple";

            return result;
        }



        public static List<int> CreateList(int a, int b)//create list of numbers in range(a,b)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i <= b - a; i++)
            {
                numbers.Add(a + i);

            }
            return numbers;
        }

        public static List<int> Replace(List<int> numbers, int c, int s)//replace number in the list by condition
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                if ((numbers[j]) % c == 0 && (numbers[j]) % s == 0)
                    Console.Write("FIZZBUZZ" + " ");
                else if ((numbers[j]) % c == 0)
                    Console.Write("FIZZ" + " ");
                else if ((numbers[j]) % s == 0)
                    Console.Write("Buzz" + " ");
                else
                    Console.Write(numbers[j] + " ");
            }
            return numbers;
        }

        public static List<string> FizzBuzz(int range1, int range2, int mult1, int mult2)
    {
        List<string> numbers = new List<string>();
        string FB = " ";
        for (int i = range1; i <= range2; i++)
        {
            FB = i % mult1 == 0 && i % mult2 == 0 ? "FizzBuzz" : ((i % mult1 == 0) ? "Fizz" : (i % mult2 == 0) ? "Buzz" : i.ToString());
                numbers.Add(FB);
        }
        return numbers;
    }

        public static void FizzBuzzString(int range1, int range2, int mult1, int mult2)
        {
            string FB = " ";
            for (int i = range1; i <= range2; i++)
            {
                FB = i % mult1 == 0 && i % mult2 == 0 ? "FizzBuzz" + " " : ((i % mult1 == 0) ? "Fizz" + " " : (i % mult2 == 0) ? "Buzz" + " " : i.ToString() + " ");
                Console.Write(FB); ;
            }
        }

        public static double [,]SumKM(ref double[,]ArrItems, double Run, int percent, double allKM, ref int j)
        {
            double Sum = Run;
            for (int i = 2; ; i++)
            {
                Sum +=Math.Round( Sum * percent / 100,2);
                i++;
                if (Sum > allKM)
                {
                    AddItemsToDblArr(ref ArrItems, ref j, Sum, i);
                    
                    PrntAnswer(i,Sum, allKM); 
                    break;
                }
            }            
            return ArrItems;
        }

        public static string[,] SumKmToStrArr(ref string[,] ArrItems, double Run, int percent, double allKM, int j)
        {
            double Sum = Run;
            for (int i = 2; ; i++)
            {
                Sum += Math.Round(Sum * percent / 100, 2);
                i++;
                if (Sum > allKM)
                {
                    AddItemsToStringArr(ref ArrItems, j, Sum, i);

                    PrntAnswer(i,Sum, allKM); 
                    break;
                }
            }
            return ArrItems;
        }

        public static void PrntAnswer(int i, double Sum, double allKm)
        {
            Console.WriteLine($"By the {i + 1} day the run will be {Sum}km that is bigger then  was planned ({allKm})");
        }

        public static double [,] CreateArray()
        {
            double[,] arrSprtmans = new double[10, 3];            

            return arrSprtmans;
        }

        public static string[,] CreateArrayStr()
        {
            string[,] arrSprtmans = new string[10, 3];
            arrSprtmans[0, 0] = "N:";
            arrSprtmans[0, 1] = "allSumKm";
            arrSprtmans[0, 2] = "Days";

            return arrSprtmans;
        }

        public static string[,] AddItemsToStringArr( ref string[,] arrSprtmans, int j, double allSum, int days)
        {
            arrSprtmans[j, 0] = j.ToString();
            arrSprtmans[j , 1] = allSum.ToString();
            arrSprtmans[j , 2] = days.ToString();

            return arrSprtmans;
        }

        public static double[,] AddItemsToDblArr(ref double[,] arrSprtmans, ref int j, double allSum, int days)
        {
            arrSprtmans[j-1, 0] = j;
            arrSprtmans[j-1, 1] = allSum;
            arrSprtmans[j-1, 2] = days;

            return arrSprtmans;
        }

        public static void PrntArray(double[,] array)
        {            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrntStrArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");                    
                }
                Console.WriteLine();
            }
        }

        public static void PrntErrMes()
        {
            Console.WriteLine("Wrong format!! Try again...");
        }
            
           







    }
}
