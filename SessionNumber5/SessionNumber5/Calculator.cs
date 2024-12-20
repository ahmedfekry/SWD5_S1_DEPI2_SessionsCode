using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber5
{
    internal class Calculator<T> where T : class
    {
        public T Add(T x,T y)
        {
            return (dynamic)x + (dynamic)y;
        }
    }
}
