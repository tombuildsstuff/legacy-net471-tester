using System;
using NUnit.Framework;

namespace ExampleApp
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      var result = Environment.GetEnvironmentVariable("RESULT");
      Assert.True(result == "pass");
    }
  }
}