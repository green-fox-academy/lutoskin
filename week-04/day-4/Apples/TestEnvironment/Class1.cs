using System;
using NUnit.Framework;

namespace TestEnvironment
{
	[TestFixture]

	public class Class1
	{
		[TestCase]
		public void Method()
		{
			Assert.AreEqual(1, 1);
		}
	}
}
