using System;
namespace Finding_Max_Of_Generic_Topic
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the generic problems");
            IntMax<int> findMaxInt = new IntMax<int>(569, 478, 999);
            Console.WriteLine(findMaxInt.maxLength(569, 478, 999));
            IntMax<float> findMaxFloat = new IntMax<float>(9.5F, 5.6F, 4.7F);
            Console.WriteLine(findMaxFloat.maxLength(9.5F, 5.6F, 4.7F));
            IntMax<string> findMaxString = new IntMax<string>("Ganga", "Venky", "Siri");
            Console.WriteLine(findMaxString.maxLength("Ganga", "Venky", "Siri"));



            
        }

        
    }

    
}
