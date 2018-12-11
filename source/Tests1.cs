using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodilityTemplate
{
    [TestFixture]
    class Tests1
    {
        private Issue1 _issue;

        [SetUp]
        public void SetUp()
        {
            _issue = new Issue1();
        }

        [Test]
        public void Correctness()
        {

        }

        [Test]
        public void Performance()
        {

        }
    }
}
