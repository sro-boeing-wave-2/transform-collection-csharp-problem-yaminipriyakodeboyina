using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        
        public static List<int> Map(this int[] num, Func<int,int>twice)
        {
            List <int> numbers= new List<int>();
            foreach (int item in num)
	        {
                numbers.Add(twice(item));
	        }
            return numbers;
        }
    }
}
