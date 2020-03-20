using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1_Libr;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //решение для трехкратного ввода переменных
            //int counter = 0;
            //string aStrng1 = " ";
            //string aStrng2 = " ";
            //while (counter < 3)
            //{
            //    Console.WriteLine("Enter first number:");
            //    aStrng1 = Console.ReadLine();
            //    if (Int32.TryParse(aStrng1, out int c1))
            //    {

            //    }
            //    else
            //    {
            //        if (counter != 2)
            //        {
            //            Console.WriteLine("Uncorrect format! Please input number:");
            //            counter++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("End!");
            //            counter = 3;
            //        }
            //    }
            //    Console.WriteLine("Enter second number:");
            //    aStrng2 = Console.ReadLine();
            //    if (Int32.TryParse(aStrng2, out int c2))
            //    {
            //        Console.WriteLine(c1 + c2);
            //        counter = 3;
            //    }
            //    else
            //    {
            //        if (counter != 2)
            //        {
            //            Console.WriteLine("Uncorrect format! Please input number:");
            //            counter++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("End!");
            //            counter = 3;
            //        }
            //    }
            //}
            //int n = 0;
            //while (n < 5)
            //{

            //    Console.WriteLine(n);
            //    n++;
            //}
            
            char YN = 'Y';
                while (YN == 'Y' || YN == 'y')
                {
                    int num_a = 0;
                    int num_b = 0;
                    int num_c = 0;
                    double x1 = 0;
                    double x2 = 0;

                for (int i = 0; i < 3; i++)
                {
                    // CustomMethods.InputNum("a", num_a);
                    Console.Write("Input number a (a!=0): ");
                    string a = Console.ReadLine();
                    while (!int.TryParse(a, out num_a) || (num_a == 0))
                    {
                        Console.Write("Incorrect format! Input number a:");
                        a = Console.ReadLine();

                        i++;
                        if (i == 3)
                            goto M;
                    }
                        i = 0;

                    Console.Write("Input number b: ");
                    string b = Console.ReadLine();
                    while (!int.TryParse(b, out num_b))
                    {
                        Console.Write("Incorrect format! Input number b: ");
                        b = Console.ReadLine();
                        i++;
                        if (i == 3)
                            goto M;
                    }
                    i = 0;

                    Console.Write("Input number c: ");
                    string c = Console.ReadLine();
                    while (!int.TryParse(c, out num_c))
                    {
                        Console.Write("Incorrect format! Input number c: ");
                        c = Console.ReadLine();
                        i++;
                        if (i == 3)
                            goto M;
                    }            
                } 
            
                Console.WriteLine($"\n\t{num_a}x^2+{num_b}x+{num_c}=0");

                //ax^2+bx+c=0
                //D=b^2-4ac
                //D<0 -нет корней
                //D=0 - 1 корень х1= х2= -b/2a
                //D>0 - 2 корня х1, х2
                //x1= (-b+Sqr(D))/2a
                //x2= (-b-Sqr(D))/2a
                //ax^2+bx+c=a(x-x1)(x-x2)  linear factors
                //Дискриминант, х1, х1 и х2, вывод линейного уравнения           
                int D = CustomMethods.Dscrmnt(num_a, num_b, num_c);
                Console.WriteLine($"Discriminant = {D}");

                if (D < 0)
                {
                    Console.WriteLine("No roots");
                }
                else if (D == 0)
                {
                    CustomMethods.Root_x1(num_a, num_b, out x1);
                    Console.WriteLine($"x1 = x2 = {x1}");

                    CustomMethods.PrntLineFctrs_1(x1, num_b, num_c, num_a);
                }
                else
                {
                    CustomMethods.Roots(num_b, D, num_a, out x1, out x2);
                    Console.WriteLine($"x1 = {x1};  x2 = {x2}");
                    
                    CustomMethods.PrntLineFctrs_2(x1, x2, num_b, num_c, num_a);
                }

                Console.WriteLine("\n\tDo you want to solve the another equation? Press Y or N");
                YN = Convert.ToChar(Console.ReadLine());

            M: Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("\n\tYou entered the wrong number format!!! The End!\n");
                break;
            }

        }
    }
}

