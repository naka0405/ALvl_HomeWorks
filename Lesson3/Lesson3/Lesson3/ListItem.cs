﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class ListItem
    {
        public List<Sportsman> ListItems;
        public ListItem()
        {
            ListItems = new List<Sportsman>();
        }

        public void AddSprtsman(Sportsman item)
        {
            ListItems.Add(item);
        }
    }
}
