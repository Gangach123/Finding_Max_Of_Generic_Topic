using System;
namespace genericProblems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the generic problems");
            Program findMax = new Program();
            Console.WriteLine($"Maximum number is {findMax.maxLength(569,478, 999)}");
            
            
        }
        private int maxLength(int value1, int value2, int value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;
            }
            else if (value2.CompareTo(value3) > 0 && value2.CompareTo(value1) > 0)
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
