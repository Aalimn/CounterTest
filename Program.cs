using System;

namespace CounterTest
{
    public class Mainclass
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("Name is: {0} = Value is: {1}", c.Name, c.Value);
            }
        }
        public static void Main(string[] args)
        {
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0]; 
            for (int i = 0; i < 4; i++)
            {
                myCounters[0].increment();
            }
            for (int i = 0; i < 5; i++)
            {
                myCounters[1].increment();
            }
            Mainclass.PrintCounters(myCounters);
            myCounters[2].Reset();
            Mainclass.PrintCounters(myCounters);
            Console.ReadLine();
        }      
    }
}
