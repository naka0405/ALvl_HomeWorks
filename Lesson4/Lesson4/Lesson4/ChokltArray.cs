using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class ChokltArray
    {
            Chocolate[] chArr;
            public ChokltArray()
            {
                chArr = new Chocolate[4];
            }


            public Chocolate this[int index]
        {
            get
            {
                return chArr[index];
            }
            set
            {
                chArr[index] = value;
            }
        }

    }
}
