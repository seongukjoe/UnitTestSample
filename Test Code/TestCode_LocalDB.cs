
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UnitTest_TOP_OCR.dbService;
using System;
using System.Data.Entity;

namespace UnitTest_TOP_OCR.Test_Code
{
    [TestClass]
    public class TestCode_LocalDB
    {
        public TestDBContext _context;
        public TestModel_Repository _repos;
        [TestInitialize]
        public void Initialize_LocalDB()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TestDBContext>());
            _context = new TestDBContext();
            _context.Database.Initialize(force: true);
            _repos = new TestModel_Repository(_context);

        }
        [TestMethod]
        public void TestLocalDB_Add_TestItem()
        {
            Test_Model item = new Test_Model
            {
                Name = "Local Item#1",
                CreatedAt = DateTime.Now
            };
            _repos.Add(item);
            var saved = _repos.GetAllList().FirstOrDefault();
            Assert.IsNotNull(saved);
            Assert.AreEqual("Local Item#1", saved.Name);

        }
        [TestMethod]
        public void TestLocalDB_GetAll_TestItem()
        {
            var items = _repos.GetAllList();
            int a = 1;
            Assert.IsNotNull(items);
            Assert.IsTrue(items.Any());
        }
    }
}
