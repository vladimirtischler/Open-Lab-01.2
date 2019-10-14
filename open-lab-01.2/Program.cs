using System;

namespace open_lab_01._2
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return (a + b);
        }
        
       
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = Sum(a, b);
            
            Console.WriteLine($"Vysledok je {c}");
        }
    }
}
