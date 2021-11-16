using System;
using System.Collections.Generic;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            MyItem item = new MyItem(3);
            myList.Add(item);

            myList.Add(new MyItem(3));


            MyList myList2 = new MyList()
            {
                new MyItem(2),
                new MyItem(1),
                new MyItem(5),
                new MyItem(8)
            };

            myList2.Clear();
            myList.Contains(item);

            var a = "Privet";
            var b = "Privet";
            var c = "Poka";

            
        }
    }
}
