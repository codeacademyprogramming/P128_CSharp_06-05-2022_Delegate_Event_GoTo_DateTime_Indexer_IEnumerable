using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P128GoToDateTimeIndexerIEnumerable
{
    class MyCollection<T> : IEnumerable
    {
        T[] _arr;

        public int MyCount { get => _arr.Length; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > _arr.Length - 1)
                {
                    throw new IndexOutOfRangeException("Gonderilen Index Deyeri Yanlisdir");
                }

                return _arr[index];
            }
            set
            {
                if (index < 0 || index > _arr.Length - 1)
                {
                    throw new IndexOutOfRangeException("Gonderilen Index Deyeri Yanlisdir");
                }
                _arr[index] = value;
            }
        }

        public MyCollection()
        {
            _arr = new T[0];
        }

        public void Add(T obj)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = obj;
        }

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }

        //public T Get(int index)
        //{
        //    if (index < 0 || index > _arr.Length-1)
        //    {
        //        throw new IndexOutOfRangeException("Gonderilen Index Deyeri Yanlisdi");
        //    }

        //    return _arr[index];
        //}
    }
}
