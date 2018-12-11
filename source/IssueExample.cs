using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTemplate
{
    class IssueExample
    {
        public int solution(int[] A, bool isLinq = false, bool isForEach = false)
        {
            var resultFor = 0;
            for (var i =0; i < A.Length; i++)
            {
                var current = A[i];
                if (current < 100 && current > -100)
                {
                    resultFor += (int)Math.Floor(Math.Sqrt(current));
                }
            }

            return resultFor;
        }

        public int solutionForEach(int[] A)
        {
            var resultForEach = 0;
            foreach (var item in A)
            {
                if (item < 100 && item > -100)
                {
                    resultForEach += (int)Math.Floor(Math.Sqrt(item));
                }
            }

            return resultForEach;
        }

        public int solutionLinq(int[] A)
        {
            return A.Where(i => i < 100 && i > -100).Select(i => (int)Math.Floor(Math.Sqrt(i))).Sum();
        }
    }
}
