using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesonet_task
{
    class Program
    {
        //Recursion for egg drop
        static int eggDrop(int eggs, int floors)
        {
            if (floors == 1 || floors == 0)
                return floors;
            int min = int.MaxValue;
            int res;
            //starting from the first floor
            // and using recursion for upping the floor for the drop
            // returning the minimum floor
            for (int i = 1; i <= floors; i++)
            {
                res = Math.Max(eggDrop(eggs - 1, i - 1), eggDrop(eggs, floors - i));
                if (res < min)
                    min = res;
            }
            return min + 1;
        }
        static void Main(string[] args)
        {
            int floors = 4, eggs = 2;
            Console.WriteLine("Highest floor is: " + eggDrop(eggs, floors)  + " when number of eggs used " + eggs + " n number of floors " + floors);
        }
    }
}
