using System;
using Effort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_TOP_OCR.dbService
{
    [TestClass]
    public class test1_Effort
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void Add_TestModelData_Save_InMemory()
        {
            var connection = DbConnectionFactory.CreateTransient();

        }
    }
}
