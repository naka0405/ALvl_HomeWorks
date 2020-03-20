using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {      

        static void Main(string[] args)
        {
            //// Console.WriteLine("Class Work:");
            //    //        //double a = 5;
            //    //        //double b = 10;
            //    //        ClassWork2702.CW2702 d = new ClassWork2702.CW2702();

            //    //        //var f = d.Minus(a, b);
            //    //        var f1 = d.Minus(55, 10);
            //    //        Console.WriteLine((f1));
            //    //        Console.WriteLine(test.CustomMath.Check(3));
            //    //        Console.WriteLine( CheckNumber.Checker.CheckNum(8)); 
            //    //         LibraryDLL.Simple_number.SimpleNumber(21);
            //    //        Console.WriteLine(g);
            //    //Console.WriteLine("________________________________________________________________________________");

            Console.WriteLine("\n\tTask \"FIZZBUZZ:\"");
            Console.WriteLine("Please, enter start number for range:");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine("Please, enter start number for range:");
            }

                Console.WriteLine("Please, enter Last number for range:");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b ))
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine("Please, enter Last number for range:");
            }
             
            var v = LibraryDLL.Simple_number.CreateList(a, b);

            Console.WriteLine(("Please, enter first simple multiplier:"));
            int c;
            while(! int.TryParse(Console.ReadLine(), out c))
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine(("Please, enter first simple multiplier:"));
            }

            Console.WriteLine(("Please, enter second simple multiplier:"));
            int s;
            while(! int.TryParse(Console.ReadLine(), out s))
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine(("Please, enter second simple multiplier:"));
            }
        

            Console.WriteLine("Do you want to know, are multiplier simple? (Y\\N)");
            string smplM = Console.ReadLine();
            switch (smplM)
            {
                case ("y"):
                    Console.WriteLine(LibraryDLL.Simple_number.SimpleNumber(c));
                    Console.WriteLine(LibraryDLL.Simple_number.SimpleNumber(s));
                    break;
                case ("n"):
                    break;
            }

            Console.WriteLine("\n\nI varient of solve \"FIZZBUZZ\":\n");//with 2 methods: create List, replace items
            LibraryDLL.Simple_number.Replace(v, c, s);

            Console.WriteLine("\n\nII varient of solve \"FIZZBUZZ\":\n");//with 1 method: create list<string> and write in by loop

            foreach (var n in (LibraryDLL.Simple_number.FizzBuzz(a, b, c, s)))
                Console.Write(n + " ");

            Console.WriteLine("\n\nIII varient of solve \"FIZZBUZZ\":\n");//with 1 method: write in string by loop
            LibraryDLL.Simple_number.FizzBuzzString(a, b, c, s);

            Console.WriteLine();

            Console.WriteLine(" _________________________________________________________________________________________________________");
            Console.WriteLine("\n\tTask \"SKIER\":");//1 varient with double array
            string YN = "Y";
            int counter = 0;
            double[,] arr = LibraryDLL.Simple_number.CreateArray();
            while (YN == "y" || YN == "Y")
            {
                Console.WriteLine("Please, enter how kilometers had skier run in a first day :");
                double Run;
                while (!double.TryParse(Console.ReadLine(), out Run))
                {
                    LibraryDLL.Simple_number.PrntErrMes(); //Console.WriteLine("Wrong format!! Try again...");
                    Console.WriteLine("Please, enter how kilometers had skier run in a first day :");
                }

                Console.WriteLine("Please, enter % increase in run every day:");
                int percent;
                //int percent=
                while (!int.TryParse(Console.ReadLine(), out percent))
                {
                    LibraryDLL.Simple_number.PrntErrMes();
                    Console.WriteLine("Please, enter % increase in run every day:");
                }

                Console.WriteLine("Please, enter number runned kilometers:");
                double allKM;
                while (!double.TryParse(Console.ReadLine(), out allKM))
                {
                    LibraryDLL.Simple_number.PrntErrMes();
                    Console.WriteLine("Please, enter number runned kilometers:");
                }
                counter++;
                arr = LibraryDLL.Simple_number.SumKM(ref arr, Run, percent, allKM, ref counter);
               
                Console.WriteLine("Do you want to calculate another sportsman? \npress Y or N");
                YN = Console.ReadLine();
            }

            Console.WriteLine("Do you want to see all List with items?");
            YN = Console.ReadLine();
            while (YN != "y" && YN != "n")
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine("Do you want to see all List with items?");
                YN = Console.ReadLine();
            }

            if (YN == "Y" || YN == "y")
            {
                LibraryDLL.Simple_number.PrntArray(arr);
            }
            else
                Console.WriteLine("End programm!");


            Console.WriteLine("II varient of program with string array:");////2 varient with string array
            Console.WriteLine("\n\tTask \"SKIER II\":");
            string YN1 = "Y";
            int counter1 = 0;
            string[,] arr1 = LibraryDLL.Simple_number.CreateArrayStr();
            while (YN1 == "y" || YN1 == "Y")
            {
                Console.WriteLine("Please, enter how kilometers had skier run in a first day :");
                double Run1;
                while (!double.TryParse(Console.ReadLine(), out Run1))
                {
                    LibraryDLL.Simple_number.PrntErrMes(); //Console.WriteLine("Wrong format!! Try again...");
                    Console.WriteLine("Please, enter how kilometers had skier run in a first day :");
                }

                Console.WriteLine("Please, enter % increase in run every day:");
                int percent1;
                //int percent=
                while (!int.TryParse(Console.ReadLine(), out percent1))
                {
                    LibraryDLL.Simple_number.PrntErrMes();
                    Console.WriteLine("Please, enter % increase in run every day:");
                }

                Console.WriteLine("Please, enter number runned kilometers:");
                double allKM1;
                while (!double.TryParse(Console.ReadLine(), out allKM1))
                {
                    LibraryDLL.Simple_number.PrntErrMes();
                    Console.WriteLine("Please, enter number runned kilometers:");
                }
                counter1++;
                arr1 = LibraryDLL.Simple_number.SumKmToStrArr(ref arr1, Run1, percent1, allKM1, counter1);

                Console.WriteLine("Do you want to calculate another sportsman? \npress Y or N");
                YN1 = Console.ReadLine();
            }

            Console.WriteLine("Do you want to see all List with items?");
            YN1 = Console.ReadLine();
            while (YN1 != "y" && YN1 != "n")
            {
                LibraryDLL.Simple_number.PrntErrMes();
                Console.WriteLine("Do you want to see all List with items?");
                YN1 = Console.ReadLine();
            }

            if (YN1 == "Y" || YN1 == "y")
            {
                LibraryDLL.Simple_number.PrntStrArray(arr1);
            }
            else
                Console.WriteLine("End programm!");
        }
    }
}
