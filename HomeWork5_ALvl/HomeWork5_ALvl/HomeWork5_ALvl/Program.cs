using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_ALvl
{
    class Program
    {

        public static void PrntContinueMenu(ref string anothItem)
        {
            Console.WriteLine("Do you want to continue? (press y/n)");
            anothItem = Console.ReadLine();
            while (!anothItem.Equals("y") && !anothItem.Equals("n"))
            {
                PrntErrMes();
                Console.WriteLine("Do you want to continue? (press y/n)");
                anothItem = Console.ReadLine();
            }
        }


        static int ReadNumberFromConsole(out int number, int condition)
        {
            //int condition;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > condition)
            {
                PrntErrMes();
            }
            return number;
        }


        public static void PrntErrMes()
        {
            Console.WriteLine("Wrong format!! Try again...");
        }

        
        public static void PrntMatrix(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " " + (array[i, j] < 10 ? " " : ""));
                }
                Console.WriteLine();
            }
        }  


        static void Main(string[] args)
        {
            // Создать программу для работы с квадратной матрицей.

            //Пользователь вводит N(размерность), после чего создается квадратная(N x N) матрица и заполняется случайными целыми числами.
            //На выбор пользователю дается неск.операций:

            //1) Вывести матрицу
            //2) Ввести N и сгенерировать новую матрицу
            //3) Выйти из программы

            //Optional: Транспонирование матрицы
            //Optional: Вывести верхнюю / нижнюю треугольную матрицу
            //Optional so zvezdochkoi: хранить все введенные матрицы в зубчатом массиве и выводить по просьбе пользователя

            Console.WriteLine("Enter the number ( 5-30) that defines the dimension of the matrix:");
            ReadNumberFromConsole(out int N, 30);
            int[,] array = new int[N, N];
            int[][,] multArray = new int[10][,];            
            int counter = -1;//numOfArray in jugged array
            string anotherItem = "y";
            
            LibraryDLL.Skills.CreateMatrix(N, ref array);
            LibraryDLL.Skills.CreateMultDimensArr(ref counter, array, ref multArray);
            int a = multArray[counter][0, 1];
            int b = array[1, 1];            
            while (anotherItem.Equals("y"))
            {
                Console.WriteLine("You may choose your action:\n\t1- Print matrix;" +
                    "\n\t2- To set a new value to dimension & create new matrix;\n\t3- To transpose matrix;" +
                    "\n\t4- Output the upper / lower triangular matrix;\n\t5- Print one of saved matrix;\n\t6- Exit the program;");
                ReadNumberFromConsole(out int number, 7);
                switch (number)
                {

                    case (1):
                        PrntMatrix(array);
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (2):
                        Console.WriteLine("Enter the number ( 5-30) that defines the dimension of the matrix:");
                        ReadNumberFromConsole(out N, 30);

                        LibraryDLL.Skills.CreateMatrix(N, ref array);
                        LibraryDLL.Skills.CreateMultDimensArr(ref counter, array, ref multArray);
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (3):
                        PrntMatrix(LibraryDLL.Skills.TransposeMatrix(array));
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (4):

                        PrntMatrix(LibraryDLL.Skills.GetTriangularMatrixLower(array));
                        Console.WriteLine();
                        PrntMatrix(LibraryDLL.Skills.GetTriangularMatrixUpper(array));
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (5):
                        Console.WriteLine($"Enter the number of matrix, which you want to print (from 1 to {counter + 1})");
                        ReadNumberFromConsole(out N, counter + 1);
                        PrntMatrix(multArray[N - 1]);
                        array = multArray[N - 1];

                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (6):
                        Console.WriteLine("The End!");
                        break;
                    default:
                        PrntErrMes();
                        ReadNumberFromConsole(out number, 7);
                        PrntContinueMenu(ref anotherItem);
                        break;
                }
                Console.WriteLine("The End!");
            }
        }
    }
}
