using System;

namespace open_lab_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            int a = int.Parse(line1);
            int b = int.Parse(line2);
            int c = a + b;
            Console.WriteLine($"Vysledok je {c}");
        }
    }
}
