using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
     class getdata
    {
        static void main()
        {
            var words = new List<string> { "Harii", "vara", "subbu", "money", "chandu", "safi", "veera" };
            var res = from word in words
                      where word.StartsWith('s') || word.StartsWith('v')
                      select word;
            foreach (var word in res)
            {
                Console.ReadLine(word);
            }
        }
    }
}
