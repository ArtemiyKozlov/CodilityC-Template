using NUnit.Framework;

namespace CodilityTemplate
{
    [TestFixture]
    class TestsExample
    {
        private IssueExample _issue;

        [SetUp]
        public void SetUp()
        {
            _issue = new IssueExample();
        }

        [Test]
        public void Correctness1()
        {
            var expected = 14;

            var input = new int[] { 4, 9, 16, 25, 150 };

            var result = _issue.solution(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 4, 9, 16, 25, 150 }, ExpectedResult = 14)]
        public int Correctness2(int[] input)
        {
            return _issue.solution(input);
        }

        static object[] TestsCase =
        {
            new object[] { new int[] { 4, 9, 16, 25, 150 }, 14 },
            new object[] { new int[] { 4, 9, 16, 25, 36, 150 }, 20 },
            new object[] { new int[] { 4, 9, 16, 25, 1, 150 }, 15 },
        };

        [Test, TestCaseSource("TestsCase")]
        public void Correctness3(int[] input, int expected)
        {
            var result = _issue.solution(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Performance()
        {

        }
    }
}
