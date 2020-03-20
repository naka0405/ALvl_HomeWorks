using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Sportsman
    {
        //private double id;
        private double sumKM;
        private int day;

        public Sportsman(double sumKM, int day)
        {
            SumKM = sumKM;
            Day = day;
        }     




        //public double ID
        //{
        //    get;
        //    set { id =; }

        //}

        public double SumKM
        {
            get { return sumKM; }
            set
            {
                sumKM = value;
            }
        }
       

        public int Day
        {
            get { return day; }
            set
            {
                day = value;
            }

        }
    }
}
