using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
     class checkloop
    {
        
        static void main()
        {
            int[] numbers = { 15, 7, 39, 13, 20, 17, 1, 10 ,23};
            var firstNumbers=numbers.TakeWhile(x => x >10);
            Console.WriteLine("first numbers greater than 10");
            foreach(int number in firstNumbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
