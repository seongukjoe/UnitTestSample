using Effort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UnitTest_TOP_OCR.dbService;
using System;
using System.Data.Entity;

namespace UnitTest_TOP_OCR
{
    [TestClass]
    public class TestCode_Repository
    {
        public TestDBContext _context;
        public TestModel_Repository _repos;


        [TestInitialize]
        public void Initialize()
        {
            var connection = DbConnectionFactory.CreateTransient();
            _context = new TestDBContext(connection);
            _repos = new TestModel_Repository(_context);
        }
        [TestMethod]
        public void TestEffort_Add_TestItem()
        {
            Test_Model item = new Test_Model
            {
                Name = "Item#1",
                CreatedAt = DateTime.Now
            };

            _repos.Add(item);
            var saved = _repos.GetAllList().FirstOrDefault();
            Assert.IsNotNull(saved);
            Assert.AreEqual("Item#1", saved.Name);
        }

    }
}
