using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string> students = new MyDictionary<int, string>();
            students.Add(499, "Mustafa");
            Console.WriteLine(students.Count);
            students.Add(10,"Mert");
            Console.WriteLine(students.Count);
            students.Add(3, "Ahmet");
        }
    }
    class MyDictionary<TKey,TValue>
    {
        TKey[] tKeys;
        TValue[] tValues;
        public MyList()
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            tempKeyArray = tKeys;
            tKeys = new TKey[tKeys.Length + 1];
            
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                tKeys[i] = tempKeyArray[i];
            }
            tKeys[tKeys.Length - 1] = key;
            
            tempValueArray = tValues;
            tValues = new TValue[tValues.Length + 1];
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                tValues[i] = tempValueArray[i];
            }
            tValues[tValues.Length - 1] = value;
        }

        public int Count
        {
            get { return items.Length; }

        }


    }
}
