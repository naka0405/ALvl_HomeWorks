using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {

        public static void PrntErrMes()
        {
            Console.WriteLine("Wrong format!! Try again...");
        }

        public static void PrntMenu()
        {
            Console.WriteLine("What do you want to do now?\n\t1-add new item of chocolate;\n\t" +
                   "2-remove chocolate by title;\n\t" +
                   "3-find chocolate by title;\n\t4-print all collection of chocolate;\n\t5-check expiration date by index;" +
                   "\n\t6- Clear console;");
        }

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


        static void Main(string[] args)
        {
            string title;
            string production;
            int weight;
            string kind;
            int percentCocoa = 0;
            DateTime dateProd;
            int idItem = 0;
            int length = 0;

            string anothItem = "y";

            var allChocolate = new Collection();


            allChocolate.AddRangeItems(new List<Chocolate>
            {
                new Chocolate("Alenka", "Biskvit", 85, "milk", 70,  new DateTime(2020, 12, 24)),
                new Chocolate("Roshen", "Roshen", 100, "milk", 75, new DateTime(2019, 04, 03)),//(04, 07, 2019)
                new Chocolate("Skazki Pushkina", "Biskvit", 85, "milk", 80, new DateTime(2020, 12, 12)),
                new Chocolate("Alenka", "Biskvit", 85, "milk", 70,  new DateTime(2022, 12, 03)),
            });

            while (anothItem.Equals("y"))
            {
                PrntMenu();
                string choise = Console.ReadLine();
                int choiseNum = 0;
                while (!int.TryParse(choise, out choiseNum) || choiseNum > 6 || choiseNum < 0)
                {
                    PrntErrMes();
                    PrntMenu();
                    choise = Console.ReadLine();
                }

                switch (choiseNum)
                {
                    case (1):
                        Console.Write("Enter title:");
                        title = Console.ReadLine();

                        Console.Write("Enter production:");
                        production = Console.ReadLine();

                        Console.WriteLine("Enter weight/gramm:");
                        string weightStr = (Console.ReadLine());
                        while (!int.TryParse(weightStr, out weight) || weight<0)
                        {
                            PrntErrMes();
                            Console.WriteLine("Enter weight/gramm:");
                            weightStr = Console.ReadLine();
                        }

                        Console.Write("Enter kind:");
                        kind = Console.ReadLine();

                        Console.Write("Enter % cocoa:");
                        string percentCocoaStr = Console.ReadLine();
                        while (!int.TryParse(percentCocoaStr, out percentCocoa) || percentCocoa <= 0)
                        {
                            PrntErrMes();
                            Console.Write("Enter % cocoa:");
                            percentCocoaStr = Console.ReadLine();
                        }

                        Console.Write("Enter date of expiration. (format: day/month/year:)");
                        string dateProdStr = Console.ReadLine();
                        while (!DateTime.TryParse(dateProdStr, out dateProd))
                        {
                            PrntErrMes();
                            Console.Write("Enter date of production (format: day/month/year:)");
                            dateProdStr = Console.ReadLine();
                        }
                        //Console.WriteLine(dateProd);

                        Chocolate chokNew = new Chocolate(title, production, weight, kind, percentCocoa, dateProd);
                        allChocolate.AddItem(chokNew);

                        PrntContinueMenu(ref anothItem);
                        //Console.WriteLine("Do you want to add another item? (press y/n)");
                        //Console.WriteLine("Do you want to continue? (press y/n)");
                        //anothItem = Console.ReadLine();
                        //while (!anothItem.Equals("y") && !anothItem.Equals("n"))
                        //{
                        //    PrntErrMes();
                        //    Console.WriteLine("Do you want to continue? (press y/n)");
                        //    anothItem = Console.ReadLine();
                        //}
                        break;

                    case (2):
                        Console.WriteLine("Enter title for removing:");
                        title = Console.ReadLine();
                        allChocolate.RemoveItemByTitle1(title, out bool NotFaund);
                        if (NotFaund == true)
                        {
                            Console.WriteLine("Such an item  wasn't found!");
                        }
                        allChocolate.PrintCollection();

                        PrntContinueMenu(ref anothItem);
                        break;

                    case (3):
                        Console.WriteLine("Enter title for search:");
                        title = Console.ReadLine();
                        Collection.PrintList1(allChocolate.FindItemByTitle(title));
                        PrntContinueMenu(ref anothItem);
                        break;

                    case (4):
                        allChocolate.PrintCollection();
                        PrntContinueMenu(ref anothItem);
                        break;

                    case (5):
                        length = allChocolate.GetLengthCollection();
                        Console.WriteLine($"Count={length}.  Enter the index to search (from 0 to {length - 1}):");
                        string idStr = Console.ReadLine();

                        while (!int.TryParse(idStr, out idItem) && idItem >= length)
                        {
                            PrntErrMes();
                            Console.WriteLine($"Count={length + 1}.  Enter the index to search:");
                            idStr = Console.ReadLine();
                        }

                        Console.WriteLine(allChocolate.FindItemByID(idItem).ToString());
                        allChocolate.FindItemByID(idItem).GetProdExpiration(out bool IsExpire);
                        if (IsExpire == true)
                        {
                            Console.WriteLine("Deadline for implementation was expire!!");
                        }
                        else
                            Console.WriteLine($"Deadline for implementation will come in {allChocolate.FindItemByID(idItem).GetProdExpiration(out IsExpire).ToString()} days");

                        PrntContinueMenu(ref anothItem);
                        break;

                    case (6):
                        Console.Clear();
                        PrntContinueMenu(ref anothItem);
                        break;
                }

                if (anothItem.Equals("n"))
                {
                    Console.WriteLine("The end!");
                    break;
                }
            }
            Console.WriteLine("\n\nExample of work with indexators:");
            ChokltArray arrayCh = new ChokltArray();
            arrayCh[0] = new Chocolate { Title = "Mousse&Blueberry" };
            arrayCh[1] = new Chocolate { Title = " Millenium" };
            Chocolate chklt1 = arrayCh[0];
            Console.WriteLine(chklt1.Title);

            Chocolate chklt2 = new Chocolate();
            
            chklt2["Title"] = "Corona";
            chklt2["Production"] = "PKJvb..OI";

            Console.WriteLine(chklt2.Production);

            Console.ReadKey();





        }
    }
}

