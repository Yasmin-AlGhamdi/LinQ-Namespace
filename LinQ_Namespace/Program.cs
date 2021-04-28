using System;
using System.Linq;
using System.Collections.Generic;

namespace LinQ_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> nums = new List<int> { 1, 22, 4, 55, 2, 6, 7 };
            List<string> names = new List<string> { "Layan", "Lamya", "Yasmin" };

            var students = from name in names
                           where name.StartsWith('L')
                           select name;
            /*
            var result = from num in nums
                         where num > 1 //  6 & num < 22
                         orderby num descending
                         select num;
            */

            foreach(var res in students)
            {
                Console.WriteLine(res + " ");
            }



            Console.ReadKey();
        }
    }
}
