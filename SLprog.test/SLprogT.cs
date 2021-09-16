using NUnit.Framework;
using System.Collections.Generic;
using SLprog;

namespace SLprog.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Nuler()
        {
            Assert.That(() => SLprogP.Silab(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Test_Num()
        {
            Assert.That(() => SLprogP.Silab("12345"), Is.Empty);
        }

        [Test]
        public void Test_Emp()
        {
            Assert.That(() => SLprogP.Silab(""), Is.Empty);
        }
        
        [Test]
        public void Test_V()
        {
            Dictionary<char, int> NV = new Dictionary<char, int>
            {
                ['a'] = 1
            };
            Assert.That(() => SLprogP.Silab("a"), Is.EquivalentTo(NV));
        }
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}