using newUnique;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace jkh
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
			MainClass gfds = new MainClass();
			List<char> expectedOutPut = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

			Assert.AreEqual(expectedOutPut, MainClass.UniqueCharacters("aaabbbccccde"));
        }

		[Test()]
        public void TestCase2()
        {
            MainClass gfds = new MainClass();
            List<char> expectedOutPut = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

            Assert.AreEqual(expectedOutPut, MainClass.UniqueCharacters("aaabbbccccdef"));
        }
    }
}
