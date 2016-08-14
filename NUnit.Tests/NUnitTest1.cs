using System;
using NUnit.Framework;
using NsoupDemo.BLL;

namespace NUnit.Tests
{
    [TestFixture]
    public class NUnitTest1
    {
        //支持参数化测试 Nunit
        [TestCase(3)]  
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(0)]
        public void TestMethod1(int length)
        {
            var result = RandomCodeHelper.GenerateRandomCode(length);
            Console.WriteLine(length+" "+result);
            Assert.AreEqual(result.Length, length);
        }

        

    }
}