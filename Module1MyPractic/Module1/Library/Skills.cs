using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Skills
    {
        public  static Employee CreatePerson(int id, string name, int age, string pozition, Teams command, int workHouars)
        {
            Employee person = new Employee(id, name, age, pozition, command, workHouars);
            return person;
        }

        public  static DataBase GetAllList(DataBase a)
        {
            return a;
        }

        public static void PrintBase (DataBase a)
        {
            for (int i=0; i<DataBase.ListItems.Count; i++)
            {
                Console.WriteLine(DataBase.ListItems[i] );
            }
        }

        public static string CountHours(DataBase a)
        {
            int Hours1 = 0;
            int Hours2 = 0;
            int Hours3 = 0;
           
            for(int i=0; i<DataBase.ListItems.Count; i++)
            {
                if(DataBase.ListItems[i].Command.Equals(Teams.HJK))
                {
                    Hours1 += DataBase.ListItems[i].WorkHouars;
                }
                else if (DataBase.ListItems[i].Command.Equals(Teams.RDF))
                {
                    Hours2+= DataBase.ListItems[i].WorkHouars;
                }
                else if (DataBase.ListItems[i].Command.Equals(Teams.TYUI))
                {
                    Hours3 += DataBase.ListItems[i].WorkHouars;
                }
            }
            string workedHours = ($"{nameof(Teams.HJK)}- {Hours1.ToString()}\n{nameof(Teams.RDF)} -{Hours2.ToString()}\n" +
                $"{nameof(Teams.TYUI)}-{Hours3.ToString()}");
            return workedHours;
        }
        //Enum.GetNames(typeof(MyEnum)).Length;
        public static void CountHours1(DataBase c, string[]ar)
        {  
            int L = Enum.GetNames(typeof(Teams)).Length;
            for (int i=0; i< L;i++)
            {
                int h1 = 0;
                string en = Enum.GetNames(typeof(Teams))[i].ToString();
                for (int j=0; j<DataBase.ListItems.Count; j++)
                {
                    if(DataBase.ListItems[j].Command.ToString()==(en))
                    {
                        h1 += DataBase.ListItems[j].WorkHouars;                        
                    }
                }              
               Console.WriteLine($"{en}-{h1}");
            }
            //string a = $"{nameof(Teams.HJK)}-{h1}";
            //return a;
        }




    }
}
