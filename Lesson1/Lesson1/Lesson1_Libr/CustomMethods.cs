using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Libr
{
    public class CustomMethods
    {
        public static string InputNum(string a, int intNum)
        {
            Console.Write("Input number a (a!=0): ");
            a = Console.ReadLine();
            while (!int.TryParse(a, out intNum) || (intNum == 0))
            {
                Console.Write("Incorrect format! Input number a:");
                a = Console.ReadLine();
            }
            return a;
        }
        public static int Dscrmnt(int num_a, int num_b, int num_c)
        {
            int D = (int)Math.Pow((double)num_b, 2) - 4 * num_a * num_c;            
            return D;
        }

        //public static double Root_x1(int num_a, int num_b)
        //{
        //    double x1 = Math.Round((double)(-num_b) / 2 * num_a, 3);
        //    double x2 = x1;
        //    Console.WriteLine($"x1=x2={x1}");
        //    return x1;
        //}

        public static void Root_x1(int num_a, int num_b, out double x1)
        {
            x1 = Math.Round((double)(-num_b) / 2 * num_a, 3);
            double x2 = x1;                        
        }

        public static void Roots(int num_b, int D, int num_a ,out double x1, out double x2)
        {
           x1 = Math.Round((-num_b + Math.Sqrt(D)) / (2 * num_a), 3);
            
            //Console.WriteLine($"x1={x1:F3}"); 
           x2 = Math.Round((-num_b - Math.Sqrt(D)) / (2 * num_a), 3);           
        }

        public static string ReplaceSign_x1(double x1)
        {
            string sign_x1 = (x1 > 0 && x1 != 0) ? ($"(x - { x1})") : ($"(x + {0 - x1})");
            return sign_x1;
        }

        public static string ReplaceSign_x2(double x2)
        {
            string sign_x2 = (x2 > 0 && x2 != 0) ? ($"(x - { x2})") : ($"(x + {0 - x2})");
            return sign_x2;
        }

        public static string ReplaceSign_b(int num_b)
        {
            string sign_b = (num_b > 0 && num_b != 0) ? ($"+{num_b}") : ($"{num_b}");
            return sign_b;
        }

        public static string ReplaceSign_c(int num_c)
        {
            string sign_c = (num_c > 0 && num_c != 0) ? ($"+{num_c}") : ($"{num_c}");
            return sign_c;
        }

        public static void ReplaceSign_bc(int num_b, int num_c, out string sign_b, out string sign_c)
        {    
            sign_b = (num_b > 0 && num_b != 0) ? ($"+{num_b}") : ($"{num_b}");         
            sign_c = (num_c > 0 && num_c != 0) ? ($"+{num_c}") : ($"{num_c}");                       
        }

        public static void PrntLineFctrs_1(double x1,int num_b,  int num_c, int num_a) 
        {
            string sign_x1 = ReplaceSign_x1(x1);
            string sign_b = ReplaceSign_b(num_b);
            string sign_c = ReplaceSign_c(num_c); 
            Console.WriteLine($"\n{num_a}x^2{sign_b}x{sign_c} = {num_a}{sign_x1}{sign_x1}={num_a}{sign_x1}^2");
        }

        public static void PrntLineFctrs_2(double x1, double x2, int num_b, int num_c, int num_a) 
        {
            string sign_x1 = ReplaceSign_x1(x1);
            string sign_x2 = ReplaceSign_x2(x2);
            string sign_b;
            string sign_c;
            ReplaceSign_bc(num_b, num_c, out sign_b, out sign_c);

            //string sign_b = ReplaceSign_b(num_b);
            //string sign_c = ReplaceSign_c(num_c);
            Console.WriteLine($"\n{num_a}x^2{sign_b}x{sign_c} = {num_a}{sign_x1}{sign_x2}");             
        }       
    }
}
