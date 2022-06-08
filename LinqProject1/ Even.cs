using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
    class Even
    {
        static void main()
        {
            int[] numbers = { 5, 4, 8, 10, 30, 15, 7, 3, 9, 2, 8 };
            var EvenNumber = from num in numbers
                             where IsEven(num)
                             select num;
            foreach(int num in numbers)
            {
                Console.WriteLine(num+" ");
            }

        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
