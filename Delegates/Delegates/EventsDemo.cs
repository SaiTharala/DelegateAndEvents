using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate void DelEventHandler();
    class EventsDemo
    {
        public static void India()
        {
            Console.WriteLine("India\n");
        }
        public static void UK()
        {
            Console.WriteLine("UK\n");
        }
        public static void Sydney()
        {
            Console.WriteLine("Sydney\n");
        }
    }
}