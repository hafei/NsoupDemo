using Microsoft.VisualStudio.TestTools.UnitTesting;
using NsoupDemo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace NsoupDemo.BLL.Tests
{
    [TestClass()]
    public class NsoupUtilTests
    {
        [TestMethod()]
        public void GetDocumentTest(string url)
        {
            NsoupUtil nsoup = new NsoupUtil(url);

            var doc = nsoup.GetDocument();
            //Console.WriteLine();
            Assert.IsNotNull(doc);
        }
    }
}