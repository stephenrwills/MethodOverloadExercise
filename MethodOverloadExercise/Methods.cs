using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadExercise
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return(x + y);
        }
               
        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }

        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x + y;

            if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString(); 
            }

        }
    }   
}
