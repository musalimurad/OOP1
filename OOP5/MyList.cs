using System;

namespace Generic
{
    class MyList<T>
    {
        T[] items;
        public  MyList()
        {
            items = new T[0];
           
        }

        //public void add(t item)
        //{
        //    t[] temparray = items;
        //    items = new t[items.length + 1];
        //    for (int i = 0; i < items.length; i++)
        //    {
        //        items[i] = temparray[i];
        //    }
        //    items[items.length - 1] = item;
        //    console.writeline($" name: {item} added successfully!");
        //}
    }
}
