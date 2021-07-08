using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> cars = new MyDictionary<string, int>();
            cars.Add("Faaliyet", 100);
            cars.Add("Halojen", 100);
            Console.WriteLine("Total cars brand:" + cars.Count);
            foreach (var car in cars.Values)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
