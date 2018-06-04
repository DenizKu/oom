using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace task4
{
    [TestFixture]

    class Tests
    {
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void SimpleStringTest()
        {
            String a = "abced";
            Assert.AreEqual(a, "abced");
            
        }

    }
}
