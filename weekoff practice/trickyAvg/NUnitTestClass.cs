using NUnit.Framework;
using System;
namespace trickyAvg
{
    [TestFixture()]
    public class NUnitTestClass
    {
		[Test()]
        public void TestCase()
        {
			int[] numbers = new int[] { 1, 5, 9, 2, 3, 18, 4, -3 };
			Assert.AreEqual(7.5, Program.TrickyAverage(numbers));
        }

        [Test()]
		public void TestCase2()
		{
			int[] numbers2 = new int[] { 2, 8, 13, 3, 9, 28, 49 };
            Assert.AreEqual(15.5, Program.TrickyAverage(numbers2));
		}
    }
}
