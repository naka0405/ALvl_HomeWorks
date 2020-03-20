using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Collection
    {
        private List<Chocolate> allChklt;

        public Collection()
        {
            allChklt = new List<Chocolate>();
        }



        public void AddItem(Chocolate item)//I want  the static...
        {
            allChklt.Add(item);
        }

        public void AddRangeItems(List<Chocolate> allChklts)
        {
            foreach (var item in allChklts)
            {
                AddItem(item);
            }
        }

        public int GetLengthCollection()
        {
            int Length = allChklt.Count();

            return Length;
        }

        public List<Chocolate> GetAllList()
        {
            return allChklt;
        }

        public void PrintCollection()//(List<Chocolate> allchklts)
        {
            foreach (var item in allChklt)
                Console.WriteLine(item);
        }


        public static void PrintList1(List<Chocolate> allChklt)//(List<Chocolate> allchklts)
        {
            foreach (var item in allChklt)
                Console.WriteLine(item);
        }


        public void RemoveItemByTitle1(string title, out bool NotFaund)
        {
            NotFaund = true;
            for (int i = 0; i < allChklt.Count; i++)
            {
                if (allChklt[i].Title.Equals(title))
                {
                    allChklt.Remove(allChklt[i]);
                    NotFaund = false;
                    i--;
                }
                //else

            }
        }

        public List<Chocolate> FindItemByTitle(string title)
        {
            List<Chocolate> result = new List<Chocolate>();

            for (int i = 0; i < allChklt.Count; i++)
            {
                if (allChklt[i].Title.Contains(title))
                {
                    result.Add(allChklt[i]);
                }
            }
            return result;
        }

        public Chocolate FindItemByID(int idItem)
        {
            Chocolate result = allChklt[idItem];
            return result;
        }
    }

}
