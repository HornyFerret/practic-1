using System;

namespace Практика_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Деление числа на разряды.");
            Console.Write("введите пятизначное число:");
            
            string s1 = Console.ReadLine();
           
            
            char ch1 = s1[0];
            Console.WriteLine("1 циферка {0}",ch1);
            char ch2 = s1[1];
            Console.WriteLine("2 циферка {0}", ch2);
            char ch3 = s1[2];
            Console.WriteLine("3 циферка {0}", ch3);
            char ch4 = s1[3];
            Console.WriteLine("4 циферка {0}", ch4);
            char ch5 = s1[4];
            Console.WriteLine("5 циферка {0}", ch5); 
        }
    }
}
