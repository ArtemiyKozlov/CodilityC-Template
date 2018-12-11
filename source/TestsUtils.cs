using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTemplate
{
    public static class TestsUtils
    {
        static public int[] GenerateRandomArray(int length, int min, int max)
        {
            var r = new Random();

            return Enumerable.Repeat(0, length).Select(i => r.Next(min, max)).ToArray();
        }

    }
}
