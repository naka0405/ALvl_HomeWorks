using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace Module1
{
    class Program
    {
        public static void PrntContinueMenu(ref char anothItem)
        {
            Console.WriteLine("Do you want to continue? (press y/n)");
           
            while (!char.TryParse(Console.ReadLine(), out anothItem)&& anothItem != ('y') && anothItem != ('n'))
            {
                PrntErrMes();
                Console.WriteLine("Do you want to continue? (press y/n)");
            }
        }

        public static void PrntErrMes()
        {
            Console.WriteLine("Wrong format!! Try again...");
        }

        public static void ReadNumberFromConsole(out int number)
        {
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                PrntErrMes();
            }
        }

        public static void ReadNumberForMenu(out int number,  int itemOfMenu)
        {
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0|| number> itemOfMenu)
            {
                PrntErrMes();
            }
        }

        public static string ValidationInputString(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Incorrect! Your string is empty!");
                input = Console.ReadLine();
            }
            return input;
        }

        public static Teams ChooseTeam()
        {
            Console.WriteLine("Please choose command (0- RDF,1-HJK, 2-TYUI1):");
            int NumCustom = 0;
            while (!int.TryParse(Console.ReadLine(), out NumCustom) ||
                !Enum.IsDefined(typeof(Teams), NumCustom))
            {
                PrntErrMes();
            }
             return (Teams)NumCustom;           
        }

        

        static void Main(string[] args)
        {
            char anotherItem= ('y');
            int id = 0;
            string name = " ";
            string pozition = " ";
            Teams command ;
            int age = 0;
            int workHours = 0;
            int itemOfMenu = 4;
            //int counter = -1;
             var ListEmployee = new DataBase();
            ListEmployee.AddRangePersons(new List<Employee>{
                new Employee(123123,"Nikiforova Anastasia", 32, "manager", Teams.HJK, 12),
                new Employee(456789,"Shkurkina anisia", 18, "manager", Teams.TYUI, 14),
                 new Employee(123178,"Nikiforova Ania", 32, "manager",Teams.TYUI, 28),
                new Employee(458989,"Shkurkina Ylia", 18, "manager", Teams.RDF, 56),
                 new Employee(123123,"Nikiforova Anastasia", 32, "manager",Teams.RDF, 19),
                new Employee(456789,"Shkurkina anisia", 18, "manager", Teams.HJK, 45),
                new Employee(789741,"Popov Evgenij",40, "Leader", Teams.HJK, 15),
            }); 

            Console.WriteLine("Programm of employee's accounting.");
            while (anotherItem == ('y'))
            {
               
                Console.WriteLine("You can choose your action:\n\t1- Create new employee & add item into the base;" +
                       "\n\t2- Print all database;\n\t3- Remove person from base;\n\t4- Exit the program;");
                ReadNumberForMenu(out int number,itemOfMenu);
                switch (number)
                {
                    case (1):
                        Console.WriteLine("Enter new ID:");
                        ReadNumberFromConsole(out id);

                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        ValidationInputString(name);

                        Console.WriteLine("Enter age:");
                        ReadNumberFromConsole(out age);

                        Console.WriteLine("Enter pozition:");
                        pozition = Console.ReadLine();
                        ValidationInputString(pozition);

                        Console.WriteLine("Enter  title of command:");

                        command= ChooseTeam();                       

                        Console.WriteLine("Enter count of worked houars:");
                        ReadNumberFromConsole(out workHours);

                        Console.WriteLine("Create new employee");
                        Employee newItem =Skills.CreatePerson(id, name, age, pozition, command, workHours);
                        ListEmployee.AddPerson(newItem);
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (2):
                        Skills.PrintBase(ListEmployee);
                        //ListEmployee.Print();
                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (3):
                        ListEmployee.Print();
                        Console.WriteLine("Choose person for removing:");
                        
                        name = Console.ReadLine();
                        ListEmployee.RemoveItemByName(name, out bool NotFaund);
                        if (NotFaund == true)
                        {
                            Console.WriteLine("Such person  wasn't found!");
                        }
                        ListEmployee.Print();

                        PrntContinueMenu(ref anotherItem);
                        break;

                    case (4):
                        anotherItem = 'n';
                        break;
                }

            }
            Console.WriteLine("The end!");

            Console.WriteLine("Count worked Hours by command(I varient)");
            string countHours = Skills.CountHours(ListEmployee);
            Console.WriteLine(countHours);

            Console.WriteLine("Count worked Hours by command(II varient)");
            var en = Enum.GetNames(typeof(Teams));
            Skills.CountHours1(ListEmployee, en);
            Console.WriteLine("DataBase has saved in OUTPUT.txt");

            ListEmployee.PrintFile();

        }
    }
}
