using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     public class Employee
    {
        private int _id;
        private string _name;
        private int _age;
        private string _pozition;
        private Teams _comand;
        private int _workHouars;

        public Employee(int id, string name, int age, string pozition, Teams command, int workHouars)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Pozition = pozition;
            this.Command =command;
            this.WorkHouars = workHouars;
        }

        //public Employee(Teams command, int workHouars)
        //{
        //   Command = command;
        //   WorkHouars = workHouars;
        //}

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Pozition
        {
            get { return _pozition; }
            set { _pozition = value; }
        }

        public Teams Command
        {
            get { return _comand; }
            set { _comand = value; }
        }

        public int WorkHouars
        {
            get { return _workHouars; }
            set { _workHouars = value; }
        }

        public override string ToString()
        {
            return $"{nameof(ID)} -{ID,8}|{nameof(Name)}- {Name,20}| {nameof(Pozition)}-{Pozition,10}|{nameof(Command)}-{Command,12}|" +
                $"{nameof(WorkHouars)}-{WorkHouars,5}";
        }
       

    }

}
