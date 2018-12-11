using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CodilityTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LinqVsForEachVsFor>();

            Console.ReadLine();
        }
    }

    public class LinqVsForEachVsFor
    {
        private int[] input;
        private List<int> inputlist;

        private int length = 100000000;
        private IssueExample _issue = new IssueExample();

        [IterationSetup]
        public void SetUp()
        {
            input = TestsUtils.GenerateRandomArray(length, -2, 2);
            inputlist = input.ToList();
        }

        [Benchmark]
        public int LinqCase() => _issue.solutionLinq(input);

        [Benchmark]
        public int ForEachCase() => _issue.solutionForEach(input);

        [Benchmark]
        public int ForCase() => _issue.solution(input);
    }
}
