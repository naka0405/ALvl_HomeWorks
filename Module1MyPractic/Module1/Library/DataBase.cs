using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DataBase
    {
        public static List<Employee> ListItems = new List<Employee>();


        public void AddPerson(Employee item)
        {
            ListItems.Add(item);
        }

        public void AddRangePersons(List<Employee> ListItems)
        {
            foreach (var item in ListItems)
            {
                AddPerson(item);
            }
        }


        public void Print()
        {
            foreach (var item in ListItems)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintFile()
        {
            string a = null;
            foreach (var item in ListItems)
            {
                a += item.ToString() + "\n";
            }
            File.WriteAllText("Output.txt", a);
        }

        public void RemoveItemByName(string name, out bool NotFaund)
        {
            NotFaund = true;
            for (int i = 0; i < ListItems.Count; i++)
            {
                if (ListItems[i].Name.Equals(name))
                {
                    ListItems.Remove(ListItems[i]);
                    NotFaund = false;
                    i--;
                }
            }
        }
    }
}
