using System;

namespace Pin_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Collector pinCollector = new Collector();
            pinCollector.Start();
        }
    }
}
