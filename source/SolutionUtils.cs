using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTemplate
{
    static class SolutionUtils
    {
        public static int SumSubsequence(int[] source, int startIndex, int length)
        {
            if(startIndex + length > source.Length)
            {
                throw new ArgumentException("startIndex + length more than source array length.");
            }

            var result = 0;

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += source[i];
            }

            return result;
        }

    }
}
