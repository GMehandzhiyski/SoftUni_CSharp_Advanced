using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;
        private int count;

        public Box()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return count; }
            //set { count = value; }
        }

        public void Add(T item) 
        {
            items.Add(item);
        }

     public void Copmare(T element) 
     {
            foreach (var item in items)
            {
                if (item.CompareTo(element) > 0) 
                {
                    count++;
                }
            }
        }
    }
}
