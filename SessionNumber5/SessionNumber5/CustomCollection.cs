using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber5
{
    internal class CustomCollection<T> where T : struct
    {
        private T[] _values;
        private int lastIndex = 0;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > lastIndex)
                {
                    throw new IndexOutOfRangeException("invalid index");
                }
                return _values[index];  
            }
            set
            {
                if (index < 0 || index > _values.Length)
                {
                    throw new IndexOutOfRangeException("invalid index");
                }
                _values[index] = value;
                lastIndex++ ;
            }
        }
        public CustomCollection(int size) { 
            _values = new T[size];
        }

        public void Add(T value)
        {
            _values[lastIndex] = value;
            lastIndex++;
        }

        public T GetValue(int index)
        {
            return _values[index];
        }

        public void Clear()
        {
            _values = new T[_values.Length];
        }


    }
}
