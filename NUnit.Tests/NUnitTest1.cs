using System;
using NUnit.Framework;
using NsoupDemo.BLL;

namespace NUnit.Tests
{
    //Nunit   
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



        [Test]
        public void testCharset()
        {
            Assert.AreEqual("utf-8", RandomCodeHelper.GetCharsetFromContentType("text/html;charset=utf-8 "));
            Assert.AreEqual("UTF-8", RandomCodeHelper.GetCharsetFromContentType("text/html; charset=UTF-8"));
            Assert.AreEqual("ISO-8859-1", RandomCodeHelper.GetCharsetFromContentType("text/html; charset=ISO-8859-1"));
            Assert.AreEqual(null, RandomCodeHelper.GetCharsetFromContentType("text/html"));
            Assert.AreEqual(null, RandomCodeHelper.GetCharsetFromContentType(null));
            Assert.AreEqual(null, RandomCodeHelper.GetCharsetFromContentType("text/html;charset=Unknown"));
        }
    }
}