using Microsoft.VisualStudio.TestTools.UnitTesting;
using NsoupDemo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsoupDemo.BLL.Tests
{
    [TestClass()]
    public class RandomCodeHelperTests
    {
        [TestMethod()]
        public void GenerateRandomCodeTest(int length)
        {
            RandomCodeHelper.GenerateRandomCode(length);
            Assert.Fail();
        }
    }
}