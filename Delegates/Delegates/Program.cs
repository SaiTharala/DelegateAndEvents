using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates Problem");
            operations obj = new operations(Delegatedemo.Addition);
            Console.WriteLine("Addition is={0}",obj(22,20));
        }
    }
}
