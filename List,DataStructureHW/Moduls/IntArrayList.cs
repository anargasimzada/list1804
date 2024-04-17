using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_DataStructureHW.Moduls
{
    internal class IntArrayList
    {
        int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void Remove(int value)
        {

        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public int this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
        public void IndexOf(int num)
        {
            for(int i = 0;i < _arr.Length;i++)
            {
                if(_arr[i] == num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Count++;
                }
            }
        }

    }
}
