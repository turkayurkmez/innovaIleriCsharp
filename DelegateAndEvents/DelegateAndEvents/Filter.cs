using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
   public static class Filter
    {
      //  public delegate bool criteria(int number);
       public static int[] FilterNumbers(int[] numbers, Func<int,bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (criteria(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
