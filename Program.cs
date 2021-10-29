using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mustafa");
            isimler.Add("Umut");
            isimler.Add("Berk");
            Console.WriteLine(isimler.Count);
        }
    }
    class MyList<T>
    {
        T[] items;
        T[] tempArray;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }

        public int Count
        {
            get { return items.Length; }

        }


    }
}
