using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_ALevel
{
    class Program
    {

        //создать структуру, которая бы описывала геометрическую фигуру (четырёхугольник, например).
        //Она должна содержать минимальную необходимую информацию для описания этой фигуры + метод вывода информации о фигуре.
        //Меню с добавлением их в массив, вывода списка фигур и одной конкретной по индексу. 
        //Для продвинутых: метод вывода информации вывести в интерфейс и обьединить несколько подобных структур с помощью нег
        //(добавьте тогда поле название - только для чтения) в одну коллекцию.

        public struct Rectangle : IPrint// Hight, Width
        {
            public double hight;
            public double width;
            public double Area { get { return hight * width; } }

            public Forms FormOfFigure;

            public void Print()
            {
                Console.WriteLine($"Figure: {FormOfFigure,10}| {nameof(hight)}- {hight,7}| {nameof(width)}- {width,7}| Area = {Area,8}|");
            }

            //public Rectangle(double height, double width, Forms form)
            //{
            //    this.hight  = height;
            //    this.width = width;
            //    this.FormOfFigure = form;
            //}
        }


        //public struct Square : IPrint
        //{
        //    public double side;
        //    public double Area { get { return side * side; } }

        //    public Forms FormOfFigure => Forms.Square;

        //    public void Print()
        //    {
        //        Console.WriteLine($":Square {nameof(side)}- {side}, Area = {Area}");
        //    }
        //}

        //public struct Arr:IPrint
        //{

        //    public object[] arr1;
        //    public void Print()
        //    {
        //        int counter = 1;
        //        for(int i=0; i<arr1.Length; i++)
        //        {
        //            Console.WriteLine(arr1[i]);
        //        }

        //    }

        //}

        public static Rectangle CreateFigure(double hight, double width, Forms form)
        {
            Rectangle rectangleItem = new Rectangle();
            rectangleItem.hight = hight;
            rectangleItem.width = width;
            rectangleItem.FormOfFigure = form;
            return rectangleItem;
        }

        public static void AddTOArray(ref int counter, Rectangle item, Rectangle[] figuresArr)
        {
            counter++;
            figuresArr[counter] = item;
        }


        //public static void AddTOArrObj(int counter,object item, object[] figuresArr)
        //{

        //    figuresArr[counter] = item;
        //}
        public static void PrintArr(Rectangle[] figuresArr, int counter)
        {
            Console.WriteLine($"\n\t\tArray of figures consists {counter + 1} items");
            for (int i = 0; i <= counter; i++)
            {
                figuresArr[i].Print();

            }
        }

        public static void PrintOnesItemFromArr(Rectangle[] figuresArr, int counter)
        {
            figuresArr[counter].Print();
        }

        public static void PrntErrMes()
        {
            Console.WriteLine("Wrong format!! Try again...");
        }


        public static void InputMenuFigure(out Forms CustomFigure)
        {
            Console.WriteLine("Please choose, which figure, do you want to create (1-Square, 2- Rectangle):");
            int NumCustomFigure = 0;
            while (!int.TryParse(Console.ReadLine(), out NumCustomFigure) ||
                !Enum.IsDefined(typeof(Forms), NumCustomFigure))
            {
                PrntErrMes();
            }
            CustomFigure = (Forms)NumCustomFigure;
            //Console.WriteLine(NumCustomFigure);
            //Console.WriteLine(CustomFigure);
            //return CustomFigure;
        }

        public static void ReadNumberFromConsole(out double hight)
        {
            while (!double.TryParse(Console.ReadLine(), out hight) || hight <= 0)
            {
                PrntErrMes();
            }
        }

        public static void ReadNumberFromConsole(int itemOfMenu, out int number)
        {
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > itemOfMenu)
            {
                PrntErrMes();
            }
        }

        public static void PrntContinueMenu(ref char anothItem)
        {
            Console.WriteLine("Do you want to continue? (press y/n)");
            anothItem = Convert.ToChar(Console.ReadLine());
            while (anothItem != ('y') && anothItem != ('n'))
            {
                PrntErrMes();
                Console.WriteLine("Do you want to continue? (press y/n)");
                anothItem = Convert.ToChar(Console.ReadLine());
            }
        }



        static void Main(string[] args)
        {
            //int n;
            //Increase(out n);
            //Console.WriteLine(n);
            //int n2=10;
            //Decrease(ref n2);
            //Console.WriteLine(n2);
            //int a = 1;
            //Console.WriteLine(a++);
            //Console.WriteLine(a);
            //Console.WriteLine(++a);
            //Console.WriteLine(a);
            //Console.WriteLine($"Postfix decrement { a--}");
            //Console.WriteLine(a);

            //HomeWork__________________________________________________________________________

            Rectangle[] arrOfFigures = new Rectangle[10];
           
            Forms CustomFigure;
            double hight = 0;
            double width = 0;
            int countInArr = -1;
            char anotherItem = 'y';
            int itemOfMenu = 4;
           
            while (anotherItem == ('y'))
            {
                if (countInArr < 0)
                {
                    Console.WriteLine("Press 1- to create your figure & add it to the array:");
                }
                else
                {
                    Console.WriteLine("You can choose your action:\n\t1- Create your figure & add it to the array;" +
                        "\n\t2- Print one of saved figures by index;\n\t3- Print all of saved figures;\n\t4- Exit the program;");
                }
                ReadNumberFromConsole(itemOfMenu, out int number);
                switch (number)
                {

                    case (1):
                        InputMenuFigure(out CustomFigure);
                        if (CustomFigure == Forms.Square)
                        {
                            Console.WriteLine("Enter side length:");
                            ReadNumberFromConsole(out hight);
                            width = hight;
                        }
                        else
                        {
                            Console.WriteLine("Enter hight of rectangle:");
                            ReadNumberFromConsole(out hight);
                            Console.WriteLine("Enter width of rectangle:");
                            ReadNumberFromConsole(out width);
                        }
                        var newFigure = CreateFigure(hight, width, CustomFigure);
                        //var newFigure=Rectangle.CreateFigure(hight, width, CustomFigure);

                        newFigure.Print();
                        AddTOArray(ref countInArr, newFigure, arrOfFigures);
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (2):
                        Console.WriteLine($"\n\t\tArray of figures consists {countInArr + 1} items\n" +
                            $"Input index of figure? which do you want to print (from 0 to {countInArr}):");
                        ReadNumberFromConsole(countInArr, out number);
                        PrintOnesItemFromArr(arrOfFigures, countInArr);

                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (3):
                        PrintArr(arrOfFigures, countInArr);
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (4):
                        anotherItem = 'n';
                        break;

                    default:
                        PrntErrMes();
                        ReadNumberFromConsole(itemOfMenu, out number);
                        PrntContinueMenu(ref anotherItem);
                        break;
                }
            }
            Console.WriteLine("The End!");

        }
        //static void Increase(out int number)
        //{
        //    number=10;
        //}

        //static void Increase(int number)
        //{
        //    number = 10;
        //}

        //static void Decrease( ref int number)
        //{
        //    number--;
        //}
    }
    //public class Car
    //{
    //    public Car(string PlateNumber)
    //}
}
