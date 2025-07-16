using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;

namespace UnitTest_TOP_OCR.dbService
{
    public class TestDBContext : DbContext
    {
        public TestDBContext() : base("name=TestDataBase")
        {

        }

        public TestDBContext(DbConnection connection) : base(connection, true)
        {

        }
        public DbSet<Test_Model> TestModel { get; set; }
    }
}
