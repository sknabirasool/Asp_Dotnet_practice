using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 34, 57, 90, 78, 24, 13, 89, 9 };
            int Count = 0;
            for(int i=0;i< arr.Length;i++)
            {
                if(arr[i]>30)
                {
                    Count += 1;
                }
            }
            int[] brr=new int[Count];
            int index = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] >30)
                {
                    brr[index] = arr[i];
                    index++;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);
            foreach(int i in brr)
            Console.WriteLine(i + " ");
            Console.ReadLine();
        }
    }
}
