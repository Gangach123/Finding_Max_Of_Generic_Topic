using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Max_Of_Generic_Topic
{
    public class IntMax<T>
    {
        public T value1, value2, value3;
       
        

        public IntMax(T value1, T value2,T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public T maxLength<T>(T value1, T value2, T value3)

        {
            if (Comparer<T>.Default.Compare(value1, value2) > 0 && Comparer<T>.Default.Compare(value1, value3) > 0)
            {
                return value1;
            }
            else if (Comparer<T>.Default.Compare(value2, value1) > 0 && Comparer<T>.Default.Compare(value2, value3) > 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }



    }
}
