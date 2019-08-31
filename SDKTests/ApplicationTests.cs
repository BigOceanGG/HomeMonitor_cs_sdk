using Microsoft.VisualStudio.TestTools.UnitTesting;
using ocean.sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean.sdk.entity;

namespace ocean.sdk.Tests
{
    [TestClass()]
    public class ApplicationTests
    {
        [TestMethod()]
        public void FindAppInfoTest()
        {
            Application app = new Application("http://172.16.2.51:2500/");
            ApplicationResp resp = app.FindAppInfo("1");
            Assert.AreEqual("1", resp.data.list[0].id, "id error");
            //Assert.Fail();
        }
    }
}