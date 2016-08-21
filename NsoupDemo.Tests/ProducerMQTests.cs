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
    public class ProducerMQTests
    {
        [TestMethod()]
        public void EmitTest()
        {
            new ProducerMQ().Emit();
            Assert.Fail();
        }

        [TestMethod()]
        public void ReceiveTest()
        {
            new ProducerMQ().Receive();
            Assert.Fail();
        }
    }
}