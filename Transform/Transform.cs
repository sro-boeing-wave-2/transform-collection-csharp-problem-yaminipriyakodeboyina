using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static int doublenum(int item)
        {
            item = item * 2;
            return item;
        }
        public static List<int> Map()
        {
            List<int> numbers= new List<int>();
            List<int> numbers1= new List<int>();
             numbers.Add(1);
			numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            foreach (int item in numbers)
	        {
                numbers.Add(doublenum(item));
	        }
            return numbers;
        }
    }
}
