using NUnit.Framework;
using System;
using Numerizer.Core.Contracts;

namespace Numerizer.Core.Test
{
    [TestFixture()]
    public class Test
    {
        IDehumanizer dehumanizer = new PTBRDehumanizer();

        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(0, dehumanizer.DehumanizeCardinal("zero"));
        }
    }
}
